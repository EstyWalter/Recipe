using CPUFramework;
using System.Data;
using System.Diagnostics;
using CPUWindowsFormFramework;

namespace RecipeWinForms
{
    public partial class FrmRecipeData : Form
    {
        DataTable dtRecipe;
        public FrmRecipeData()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
        }

        public void ShowForm(int RecipeId)
        {
            string sql = "select r.RecipeId, r.cuisineId, c.CuisineType, r.UsersId, u.UserName, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived, r.Calories, r.Statuses, r.PictureRecipe \r\nfrom Recipe r \r\njoin Users u \r\non u.UsersId = r.UsersId \r\njoin Cuisine c \r\non c.cuisineId = r.cuisineId where r.RecipeId = " + RecipeId;
            dtRecipe = SQLUtility.GetDataTable(sql);
            if (RecipeId == 0)
            {
                dtRecipe.Rows.Add();
            }
            Debug.Print(dtRecipe.Rows.Count.ToString());
            DataTable dtCuisine = SQLUtility.GetDataTable("select cuisineId, CuisineType from Cuisine");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            DataTable dtUsers = SQLUtility.GetDataTable("select UsersId, UserName from Users");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtRecipe, "Users");
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtStatuses, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update Recipe set ",
                  $"CuisineId = '{r["CuisineId"]}', ",
                  $"UsersId = '{r["UsersId"]}', ",
                  $"DateDrafted = '{r["DateDrafted"]}', ",
                  $"RecipeName = '{r["RecipeName"]}', ",
                  $"Calories = '{r["Calories"]}' ",
                  $"where RecipeId = {r["RecipeId"]} "
                  );
            }
            else
            {
                sql = "insert Recipe(CuisineId, UsersId, DateDrafted, RecipeName, Calories)";
                sql += $"select '{r["CuisineId"]}', '{r["UsersId"]}','{r["DateDrafted"]}', '{r["RecipeName"]}', '{r["Calories"]}'";
            }
            Debug.Print("----------");
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

    }
}
