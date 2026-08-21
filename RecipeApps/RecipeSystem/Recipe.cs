using System.Data;
using System.Diagnostics;

namespace RecipeSystem
{
  
    public class Recipe
    {
        public static DataTable SearchByRecipeName(string recipename)
        {
            string sql = "select Recipeid, recipename from recipe where recipename like '%" + recipename + "%' ";
            Debug.Print(sql);
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable SearchRecipeInfo(int recipeid)
        {
            string sql = "select r.RecipeId, r.cuisineId, c.CuisineType, r.UsersId, u.UserName, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived, r.Calories, r.Statuses, r.PictureRecipe from Recipe r join Users u on  u.UsersId = r.UsersId join Cuisine c on c.cuisineId = r.cuisineId where recipeid = " + recipeid;
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetCuisineDataTable()
        { 
          return SQLUtility.GetDataTable("select cuisineId, CuisineType from Cuisine");
        }

        public static DataTable GetUsersDataTable()
        {
            return SQLUtility.GetDataTable("select u.UsersId, u.UserName from Users u");
        }

        public static void Save(DataTable dtRecipe)
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

        public static void Delete(int id, DataTable dtrecipe)
        {
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
