using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{

    public class Recipe
    {

        public static DataTable GetRecipe(string parametername, int paramvalue, int paramvalue2 = 0)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters[parametername].Value = paramvalue;
            cmd.Parameters["@IncludeBlank"].Value = paramvalue2;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void Save(DataTable dtRecipe)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("cannot call recipe save method because there are no rows in table");
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(int id, DataTable dtrecipe)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            cmd.Parameters["@RecipeId"].Value = id;
            SQLUtility.GetDataTable(cmd);
        }

        public static int FindRecipeId(DataTable dtRecipe)
        {
            return SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
        }
    }
}
