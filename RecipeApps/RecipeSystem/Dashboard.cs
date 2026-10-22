using System.Data;

namespace RecipeSystem
{
    public class Dashboard
    {
        public static DataTable GetDashboard()
        {
            return SQLUtility.GetDataTable(SQLUtility.GetSqlCommand("DashboardGet"));
        }
      
    }
}
