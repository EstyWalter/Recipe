using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class Cookbook
    {

        public static DataTable GetCookbook(string sprocname, string paramname, int value)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            cmd.Parameters[paramname].Value = value;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void Save(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                throw new Exception("cannot call Cookbook save method because there are no rows in table");
            }
            DataRow r = dt.Rows[0];
            SQLUtility.SaveDataRow(r, "CookBookUpdate");
        }

        public static void SaveRecipe(DataTable dt, int cookbookid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["CookbookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }

        public static void Delete(string Sprocname, string tableid, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(Sprocname);
            cmd.Parameters[tableid].Value = id;
            SQLUtility.GetDataTable(cmd);
        }

        public static int FindCookbookId(DataTable dtcookbook)
        {
            return SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
        }
    }
}
