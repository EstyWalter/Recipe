using CPUFramework;
using NUnit.Framework.Legacy;
using System.Data;
using System.Runtime.CompilerServices;

namespace RecipeTest
{
    public class RecipeTests
    {
        [SetUp]
        public void Setup()
        {
            dbManager.SetConnectionString("Server = tcp:esty.database.windows.net,1433; Initial Catalog = HeartyHearthDB; Persist Security Info = False; User ID = Estyadmin; Password =Hiitsme!" +
            "; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
        }

        private int Recipeid()
        {
            return SQLUtility.GetFirstColumnsFirstRowValueInt("SELECT TOP 1 RecipeID FROM Recipe");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = Recipeid();
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            TestContext.WriteLine("a id from HeartyHearthdb in table Recipe = " + recipeid);
            TestContext.WriteLine("Ensure that app loads Recipeid " + recipeid);
            DataTable dtRecipe = Recipe.SearchRecipeInfo(recipeid);
            int loadedid = (int)dtRecipe.Rows[0]["Recipeid"];
            ClassicAssert.IsTrue(loadedid == recipeid, "Recipeid from database" + recipeid + "does not = " + loadedid + "from RecipeApp");
            TestContext.WriteLine("loadedid = " + loadedid + " The RecipeInfo has loaded the correct info from dbHeartyHearth");
        }

        [Test]

        [TestCase("c")]
        [TestCase("jjjj")]
        public void SearchRecipeByName(string characters)
        {
            TestContext.WriteLine("search for recipes containing these characters " + characters);
            DataTable dt = Recipe.SearchByRecipeName(characters);
            Assume.That(dt.Rows.Count > 0, "can't run test no recipes in dbHeartyHearth or no Recipes matching " + characters);
            if (dt.Rows.Count > 0)
            {
                string LoadedRecipeName = dt.Rows[0]["recipename"].ToString();
                ClassicAssert.That(LoadedRecipeName.ToLower(), Does.Contain(characters.ToLower()));
                TestContext.WriteLine("Loaded RecipeName = " + LoadedRecipeName + " it contains the characters specified (" + characters + ")");
            }
        }


        [Test]
        [TestCase("Cuisineid")]
        [TestCase("Usersid")]
        [TestCase("calories")]
        public void SaveInfoForRecipewithInt(string columnname)
        {
            int recipeid = Recipeid();
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            int updatedvalue = SQLUtility.GetFirstColumnsFirstRowValueInt("select min(" + columnname + ") from recipe");
            int value = SQLUtility.GetFirstColumnsFirstRowValueInt("select " + columnname + " from recipe where recipeid = " + recipeid);
            if (updatedvalue == value)
            {
                updatedvalue = SQLUtility.GetFirstColumnsFirstRowValueInt("select max(" + columnname + ") from recipe");
            }
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " = " + value);

            DataTable dtRecipe = Recipe.SearchRecipeInfo(recipeid);
            dtRecipe.Rows[0][columnname] = updatedvalue;
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " needs to be updated to " + updatedvalue);
            Recipe.Save(dtRecipe);
            value = SQLUtility.GetFirstColumnsFirstRowValueInt("select " + columnname + " from recipe where recipeid = " + recipeid);
          
            ClassicAssert.IsTrue(updatedvalue == value, "The recipe where recipeid = " + recipeid + " " + columnname + " = " + value + " does not = " + updatedvalue);
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " = " + updatedvalue);
        }


        [Test]
        [TestCase("Cuisineid")]
        [TestCase("Usersid")]
        [TestCase("calories")]
        public void SaveInvalidInfoForRecipewithInt(string columnname)
        {
            int recipeid = Recipeid();
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            //int updatedvalue = SQLUtility.GetFirstColumnsFirstRowValueInt("select min(" + columnname + ") from recipe");
            int updatedvalue = -1;
            int value = SQLUtility.GetFirstColumnsFirstRowValueInt("select " + columnname + " from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " = " + value);

            DataTable dtRecipe = Recipe.SearchRecipeInfo(recipeid);
            dtRecipe.Rows[0][columnname] = updatedvalue;
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " cannot be updated to " + updatedvalue);
           Exception ex = Assert.Throws<Exception>(()=> Recipe.Save(dtRecipe));
    
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        [TestCase("RecipeName", "I am updated")]
        [TestCase("DateDrafted", "1-1-2000 12:00:00 AM")]

        public void SaveInfoForRecipestring(string columnname, string updatedvalue)
        {
            int recipeid = Recipeid();
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            string value = SQLUtility.GetFirstColumnsFirstRowValue("select " + columnname + " from recipe where recipeid = " + recipeid, "string").ToString();
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " = " + value);

            DataTable dtRecipe = Recipe.SearchRecipeInfo(recipeid);
            if (columnname == "RecipeName")
            {
                updatedvalue = updatedvalue + DateTime.Now;
            }
            dtRecipe.Rows[0][columnname] = updatedvalue;
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " needs to be updated to " + updatedvalue);
     
            Recipe.Save(dtRecipe);
            value = SQLUtility.GetFirstColumnsFirstRowValue("select " + columnname + " from recipe where recipeid = " + recipeid, "string").ToString();

            if (columnname == "DateDrafted")
            {
                DateTime dateupdatedvalue = Convert.ToDateTime(updatedvalue);
                DateTime datevalue = Convert.ToDateTime(value);
                ClassicAssert.IsTrue(dateupdatedvalue == datevalue, "The recipe where recipeid = " + recipeid + " " + columnname + " = " + datevalue + " does not = " + dateupdatedvalue);
            }
            else
            {
                ClassicAssert.IsTrue(updatedvalue == value, "The recipe where recipeid = " + recipeid + " " + columnname + " = " + value + " does not = " + updatedvalue);
            }
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " = " + updatedvalue);
        }

        [Test]
        [TestCase("RecipeName")]
        [TestCase("DateDrafted")]
        public void SaveInvalidInfoForRecipestring(string columnname)
        {
            int recipeid = Recipeid();
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            string updatevalue = "";
            string value = SQLUtility.GetFirstColumnsFirstRowValue("select " + columnname + " from recipe where recipeid = " + recipeid, "string").ToString();
            if(columnname == "DateDrafted")
            {
                updatevalue = DateTime.Now.ToString();
            }
            else
            {
               updatevalue = SQLUtility.GetFirstColumnsFirstRowValue("select " + columnname + " from recipe where recipeid <> " + recipeid, "string").ToString();
               
            }
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " = " + value);
            DataTable dtRecipe = Recipe.SearchRecipeInfo(recipeid);
            dtRecipe.Rows[0][columnname] = updatevalue;
            TestContext.WriteLine("The recipe where recipeid = " + recipeid + " " + columnname + " needs to fail when trying to update to " + updatevalue);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dtRecipe));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        [TestCase("1/1/2000", "great recipe", 222)]
        public void InsertNewRecipe(DateTime datedrafted, string recipename, int calories)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int usersid = SQLUtility.GetFirstColumnsFirstRowValueInt("select top 1 usersid from users");
            int cuisineid = SQLUtility.GetFirstColumnsFirstRowValueInt("select top 1 cuisineid from cuisine");
            recipename = recipename + DateTime.Now;
            Assume.That(usersid > 0, "cant run test no users in dbHeartyHearth");
            Assume.That(cuisineid > 0, "cant run test no users in dbHeartyHearth");
            TestContext.WriteLine("Insert recipe with recipename (" + recipename + ") ");
            r["CuisineId"] = cuisineid;
            r["UsersId"] = usersid;
            r["DateDrafted"] = datedrafted;
            r["RecipeName"] = recipename;
            r["Calories"] = calories;

            Recipe.Save(dt);
            int newid = SQLUtility.GetFirstColumnsFirstRowValueInt("select * from Recipe r where r.RecipeName = '" + recipename + "' ");
            ClassicAssert.IsTrue(newid > 0, "cant insert recipe with recipename " + recipename);
            TestContext.WriteLine("recipe with recipename (" + recipename + ") was inserted into dbHeartyhearth");
        }

        [Test]
        public void FailToDeleteRecipeWhenViolatingBusinessRule()
        {
            int recipeid = SQLUtility.GetFirstColumnsFirstRowValueInt("select recipeid from recipe r where statuses = 'Published' or (statuses = 'Archived' and datediff(day, isnull(DatePublished, DateDrafted),  DateArchived) <= 30)");
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            TestContext.WriteLine("do not delete recipe where recipeid = " + recipeid);
            DataTable dt = SQLUtility.GetDataTable("select recipeid from recipe r where recipeid =" + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(recipeid, dt));
            TestContext.WriteLine(ex.Message);
        }


        [Test]
        public void DeleteRecipe()
        {
            int recipeid = SQLUtility.GetFirstColumnsFirstRowValueInt("select recipeid from recipe r where statuses = 'Drafted'");
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            TestContext.WriteLine("delete recipe where recipeid = " + recipeid);
            DataTable dt = SQLUtility.GetDataTable("select * from recipe r where recipeid = " + recipeid);
            Recipe.Delete(recipeid, dt);
            DataTable dtaftersave = SQLUtility.GetDataTable("select * from recipe r where recipeid = " + recipeid);
            ClassicAssert.IsTrue(dtaftersave.Rows.Count == 0, "Recipe where recipeid = " + recipeid + " is not deleted from dbHeartyhearth");
            TestContext.WriteLine("recipe where recipeid = " + recipeid + " is deleted");
        }

        [Test]
        public void FailToDeleteRecipeWithFK()
        {
            int recipeid = Recipeid();
            Assume.That(recipeid > 0, "No recipes in HearthyHearthdb can't run the test");
            TestContext.WriteLine("do not delete recipe, where recipeid = " + recipeid);
            DataTable dt = SQLUtility.GetDataTable("select * from recipe r where recipeid = " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(recipeid, dt)); 
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        [TestCase("Users")]
        [TestCase("Cuisine")]
        public void GetListForFK(string tablename)
        {
            int rowsintable = SQLUtility.GetFirstColumnsFirstRowValueInt("select total = count(*) from " + tablename);
            Assume.That(rowsintable > 0, "No " + tablename + " in HearthyHearthdb can't run the test");
            TestContext.WriteLine("Number of " + tablename + " in db " + rowsintable);
            TestContext.WriteLine("Ensure that number of rows returned by app matches " + rowsintable);
            DataTable dt;
            if (tablename == "Users")
            {
                dt = Recipe.GetUsersDataTable();
            }
            else
            {
                dt = Recipe.GetCuisineDataTable();
            }
            ClassicAssert.IsTrue(dt.Rows.Count > 0, "Number of rows in " + tablename + " = " + dt.Rows.Count, "number of rows returned by app (" + dt.Rows.Count + ") <> does not = " + rowsintable);
            TestContext.WriteLine("Number of rows in " + tablename + " = " + dt.Rows.Count);
        }
    }
}
