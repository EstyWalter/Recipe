using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class DataMaintenance
    {
        public static DataTable GetDataList(string tabletype)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tabletype + "Get");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void DeleteRow(int id, string tabletype)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tabletype + "Delete");
            SQLUtility.SetParamValue(cmd, "@" + tabletype + "Id", id);
            SQLUtility.GetDataTable(cmd);
        }
         
        public static void UpdateTable(DataTable dtlist, string tabletype)
        {
            SQLUtility.SaveDataTable(dtlist, tabletype + "Update");
        }
    }
}
