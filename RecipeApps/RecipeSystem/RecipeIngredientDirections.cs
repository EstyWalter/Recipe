using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class RecipeIngredientDirections
    {
        public static DataTable GetDataTableWithId(string sprocname, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            cmd.Parameters["@RecipeId"].Value = id;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetDataTable(string sprocname)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveTable(DataTable dt, string sprocname, int recipeid, string tableid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, sprocname);
        }

        public static void DeleteFromTable(string sprocname, string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            cmd.Parameters[tablename].Value = id;
            SQLUtility.GetDataTable(cmd);
        }
    }
}






