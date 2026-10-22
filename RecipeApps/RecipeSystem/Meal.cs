using System.Data;

namespace RecipeSystem
{
    public class Meal
    {
        public static DataTable GetMealList()
        {
            return SQLUtility.GetDataTable(SQLUtility.GetSqlCommand("MealList"));
        }

    }
}
