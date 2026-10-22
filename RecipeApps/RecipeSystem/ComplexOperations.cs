using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class ComplexOperations
    {
        public static DataTable CloneRecipe(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CloneRecipe");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable AutoCreateCookbook(int usersid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            cmd.Parameters["@UsersId"].Value = usersid;
            return SQLUtility.GetDataTable(cmd);
        }

        public static int GetId(DataTable dt, string coloumnnameid)
        {
          return SQLUtility.GetValueFromFirstRowAsInt(dt, coloumnnameid);
        }


    }
}
