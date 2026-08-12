using CPUFramework;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class FrmRecipeData : Form
    {
        public FrmRecipeData()
        {
            InitializeComponent();
        }

        private void DataBinding(TextBox txt, string ColoumnName, DataTable dt)
        {
            txt.DataBindings.Add("Text", dt, ColoumnName);
        }

        private void Dates(TextBox txt)
        {
            if(txt.Text == "")
            {
                txt.ReadOnly = false;
            }
        }

        private void Dates()
        {
            Dates(txtDatePublished);
            Dates(txtDateDrafted);
            Dates(txtDateArchived);
        }

        public void ShowForm(int RecipeId)
        {
            string sql = "select RecipeId, RecipeName, DateDrafted, DatePublished, DateArchived, Calories, Statuses, PictureRecipe from Recipe r where RecipeId = " + RecipeId;
            DataTable dt = SQLUtility.GetDataTable(sql);
            Debug.Print(dt.Rows.Count.ToString());
            DataBinding(txtDateDrafted, "DateDrafted", dt);
            DataBinding(txtDatePublished, "DatePublished", dt);
            DataBinding(txtDateArchived, "DateArchived", dt);
            DataBinding(txtRecipeName, "RecipeName", dt);
            DataBinding(txtCalories, "Calories", dt);
            DataBinding(txtStatuses, "Statuses", dt);
            this.Show();
            Dates();
        }

    }
}
