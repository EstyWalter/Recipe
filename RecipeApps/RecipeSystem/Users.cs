using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
   public static class Users
    {
        public static DataTable GetUsersDataTable()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = 0;
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
