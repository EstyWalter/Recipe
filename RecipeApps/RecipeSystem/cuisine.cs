using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public static class Cuisine
    {

        public static DataTable GetCuisineDataTable()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
