#nullable enable
using CPUFramework;
using RecipeSystem;
using System.Configuration;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace RecipeTest
{

    public class RecipeTests
    {

        [SetUp]
        public void Setup()
        {
            var config = global::System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(
                new ExeConfigurationFileMap { ExeConfigFilename = Path.Combine(TestContext.CurrentContext.TestDirectory, "App.test.config") },
                ConfigurationUserLevel.None);

            dbManager.SetConnectionString(config.ConnectionStrings.ConnectionStrings["liveconn"]?.ConnectionString
                ?? throw new InvalidOperationException("Missing liveconn in App.test.secret.config."), true);

        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = Recipeid();
            DataTable dtRecipe = LoadRecipeById(recipeid);

            Assert.That(Recipe.FindRecipeId(dtRecipe), Is.EqualTo(recipeid));
        }


        [TestCase("CuisineId")]
        [TestCase("UsersId")]
        [TestCase("Calories")]
        public void SaveInfoForRecipewithInt(string columnname)
        {
            WithNewRecipe(recipeid =>
            {

                bizRecipe rec = new();
                DataTable dtRecipe = LoadRecipeById(recipeid);
                int currentValue = Convert.ToInt32(dtRecipe.Rows[0][columnname]);
                int updatedValue = GetDifferentIntValue(columnname, currentValue);

                dtRecipe.Rows[0][columnname] = updatedValue;
                rec.Save(dtRecipe);

                Assert.That(ReadRecipeValue(recipeid, columnname), Is.EqualTo(updatedValue));
            });
        }

        [TestCase("CuisineId")]
        [TestCase("UsersId")]
        [TestCase("Calories")]
        public void SaveInvalidInfoForRecipewithInt(string columnname)
        {
            WithNewRecipe(recipeid => AssertInvalidSave(recipeid, columnname, -1));
        }

        [TestCase("RecipeName")]
        [TestCase("DateDrafted")]
        public void SaveInfoForRecipestring(string columnname)
        {
            WithNewRecipe(recipeid =>
            {
                bizRecipe rec = new();
                DataTable dtRecipe = rec.Load(recipeid);
                object updatedValue = columnname == "RecipeName"
                    ? (object)CreateTestName("Updated recipe")
                    : new DateTime(2000, 1, 2);

                dtRecipe.Rows[0][columnname] = updatedValue;
                rec.Save(dtRecipe);

                Assert.That(ReadRecipeValue(recipeid, columnname), Is.EqualTo(updatedValue));
            });
        }

        [TestCase("RecipeName")]
        [TestCase("DateDrafted")]
        public void SaveInvalidInfoForRecipestring(string columnname)
        {
            WithNewRecipe(recipeid =>
            {
                if (columnname == "DateDrafted")
                {
                    AssertInvalidSave(recipeid, columnname, DateTime.Today.AddDays(1));
                }
                else
                {
                    int otherRecipeId = Recipeid(recipeid);
                    object duplicateName = ReadRecipeValue(otherRecipeId, "RecipeName");
                    AssertInvalidSave(recipeid, columnname, duplicateName);
                }
            });
        }

        [Test]
        public void FailToDeleteRecipeWhenViolatingBusinessRule()
        {
            int recipeid = SQLUtility.GetFirstColumnsFirstRowValueInt(@"
                select coalesce(min(RecipeId), 0)
                from Recipe
                where Statuses = 'Published'
                   or (Statuses = 'Archived'
                       and datediff(day, isnull(DatePublished, DateDrafted), DateArchived) <= 30)");

            Assume.That(recipeid, Is.GreaterThan(0), "No recipe matches the deletion business rule.");
            AssertDeleteRejected(recipeid);
        }

        [Test]
        public void DeleteRecipe()
        {
            WithNewRecipe(recipeid =>
            {

                bizRecipe rec = new();
                DataTable dtRecipe = LoadRecipeById(recipeid);

                rec.Delete(dtRecipe);

                Assert.That(RecipeExists(recipeid), Is.False, $"Recipe {recipeid} still exists.");
            });
        }

        [Test]
        public void FailToDeleteRecipeWithFK()
        {
            int recipeid = SQLUtility.GetFirstColumnsFirstRowValueInt(@"
                select coalesce(min(r.RecipeId), 0)
                from Recipe r
                where r.Statuses = 'Drafted'
                  and exists (select 1 from CookbookRecipe cr where cr.RecipeId = r.RecipeId)");

            Assume.That(recipeid, Is.GreaterThan(0), "No drafted recipe is linked to a cookbook.");
            AssertDeleteRejected(recipeid);
        }

        [TestCase("Users")]
        [TestCase("Cuisine")]
        public void GetListForFK(string tablename)
        {
            int expectedCount = SQLUtility.GetFirstColumnsFirstRowValueInt($"select count(*) from {tablename}");
            DataTable actual = tablename == "Users"
                ? Users.GetUsersDataTable()
                : Cuisine.GetCuisineDataTable();

            Assert.That(actual.Rows.Count, Is.EqualTo(expectedCount));
        }


        [TestCase("Ingredient")]
        [TestCase("Recipe")]
        public void GetList(string tablename)
        {
            int expectedCount = SQLUtility.GetFirstColumnsFirstRowValueInt($"select count(*) from {tablename}");
            int i = 0;
            if (tablename == "Ingredient")
            {
                bizIngredient ing = new();
                var lst = ing.GetList();
                i = lst.Count();
            }
            else
            {
                bizRecipe rec = new();
                var lst = rec.GetList();
                i = lst.Count();
            }
            
            string msg = $"The expected amount of {tablename}s is {expectedCount}. {tablename} is equal to {i}";
            TestContext.WriteLine(msg);
            Assert.That(i, Is.EqualTo(expectedCount), msg);
        }

        [Test]
        public void LoadSetsRecipeName()
        {
            bizRecipe rec = new();
            int recipeId = Recipeid();

            DataTable dtRecipe = rec.Load(recipeId);

            Assert.That(dtRecipe.Rows.Count, Is.EqualTo(1),
                $"Expected one row for recipe {recipeId}.");

            string expectedName = dtRecipe.Rows[0].Field<string>("RecipeName")!;

            Assert.That(rec.RecipeName, Is.EqualTo(expectedName),
                $"RecipeName should match the loaded row for recipe {recipeId}.");
        }

        [Test]
        public void SearchRecipe()
        {
            bizRecipe rec = new();
            string? recipename = SQLUtility.GetFirstColumnsFirstRowValue("select recipename from recipe", "string").ToString();
            var lst = rec.Search(recipename);
        }


        private static int Recipeid(int excludedRecipeId = 0)
        {
            int recipeid = SQLUtility.GetFirstColumnsFirstRowValueInt(
                $"select coalesce(min(RecipeId), 0) from Recipe where RecipeId <> {excludedRecipeId}");

            Assume.That(recipeid, Is.GreaterThan(0), "No suitable recipe exists in the test database.");
            return recipeid;
        }

        private static DataTable LoadRecipeById(int recipeid)
        {
            bizRecipe r = new();
            DataTable dtRecipe = r.Load(recipeid);
            string msg = $"Expected one row for RecipeId {recipeid}.";
            Assert.That(dtRecipe.Rows.Count, Is.EqualTo(1), msg);
            TestContext.WriteLine(msg);
            return dtRecipe;
        }

        private static object ReadRecipeValue(int recipeid, string columnname)
        {
            DataTable data = SQLUtility.GetDataTable(
                $"select {columnname} from Recipe where RecipeId = {recipeid}");

            Assert.That(data.Rows.Count, Is.EqualTo(1));
            return data.Rows[0][columnname];
        }

        private static int GetDifferentIntValue(string columnname, int currentValue)
        {
            if (columnname == "Calories")
            {
                return currentValue == 250 ? 251 : 250;
            }

            string tableName = columnname == "CuisineId" ? "Cuisine" : "Users";
            int updatedValue = SQLUtility.GetFirstColumnsFirstRowValueInt(
                $"select coalesce(min({columnname}), 0) from {tableName} where {columnname} <> {currentValue}");

            Assume.That(updatedValue, Is.GreaterThan(0), $"Add a second row to {tableName} to run this test.");
            return updatedValue;
        }

        private static void AssertInvalidSave(int recipeid, string columnname, object invalidValue)
        {

            bizRecipe rec = new();
            object originalValue = ReadRecipeValue(recipeid, columnname);
            DataTable dtRecipe = LoadRecipeById(recipeid);
            dtRecipe.Rows[0][columnname] = invalidValue;

            var error = Assert.Catch(() => rec.Save(dtRecipe));
            TestContext.WriteLine(error?.Message);
            Assert.That(ReadRecipeValue(recipeid, columnname), Is.EqualTo(originalValue));
        }

        private static void AssertDeleteRejected(int recipeid)
        {

            bizRecipe rec = new();
            DataTable dtRecipe = LoadRecipeById(recipeid);

            var error = Assert.Catch(() => rec.Delete(dtRecipe));
            TestContext.WriteLine(error?.Message);
            Assert.That(RecipeExists(recipeid), Is.True, $"Recipe {recipeid} should still exist.");
        }

        private static bool RecipeExists(int recipeid)
        {
            int count = SQLUtility.GetFirstColumnsFirstRowValueInt(
                $"select count(*) from Recipe where RecipeId = {recipeid}");
            return count == 1;
        }

        private static void WithNewRecipe(
            Action<int> runTest, string? recipeName = null, int calories = 222, DateTime? dateDrafted = null)
        {

            bizRecipe rec = new();
            int usersid = SQLUtility.GetFirstColumnsFirstRowValueInt(
                "select coalesce(min(UsersId), 0) from Users");
            int cuisineid = SQLUtility.GetFirstColumnsFirstRowValueInt(
                "select coalesce(min(CuisineId), 0) from Cuisine");
            Assume.That(usersid, Is.GreaterThan(0), "Add a user to the test database.");
            Assume.That(cuisineid, Is.GreaterThan(0), "Add a cuisine to the test database.");

            string testName = recipeName ?? CreateTestName("Test recipe");
            string escapedName = EscapeSqlText(testName);
            DataTable dtRecipe = SQLUtility.GetDataTable("select * from Recipe where 1 = 0");
            DataRow row = dtRecipe.NewRow();
            row["CuisineId"] = cuisineid;
            row["UsersId"] = usersid;
            row["DateDrafted"] = dateDrafted ?? new DateTime(2000, 1, 1);
            row["RecipeName"] = testName;
            row["Calories"] = calories;
            dtRecipe.Rows.Add(row);

            int recipeid = 0;
            try
            {
                rec.Save(dtRecipe);
                recipeid = SQLUtility.GetFirstColumnsFirstRowValueInt(
                    $"select coalesce(min(RecipeId), 0) from Recipe where RecipeName = N'{escapedName}'");

                Assert.That(recipeid, Is.GreaterThan(0), $"Recipe {testName} was not inserted.");
                runTest(recipeid);
            }
            finally
            {
                if (recipeid > 0)
                {
                    SQLUtility.ExecuteSQL($"delete from Recipe where RecipeId = {recipeid}");
                }
                else
                {
                    SQLUtility.ExecuteSQL($"delete from Recipe where RecipeName = N'{escapedName}'");
                }
            }
        }

        private static string CreateTestName(string prefix)
        {
            return $"{prefix} {Guid.NewGuid():N}";
        }

        private static string EscapeSqlText(string value)
        {
            return value.Replace("'", "''");
        }
    }
}
