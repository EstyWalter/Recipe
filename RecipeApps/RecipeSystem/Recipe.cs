using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

namespace RecipeSystem
{

    public class Recipe
    {
        public static DataTable SearchByRecipeName(string recipename)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable SearchRecipeInfo(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetCuisineDataTable()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetUsersDataTable()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
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
