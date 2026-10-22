using System.Data;
namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {

        public frmRecipe()
        {
            InitializeComponent();
            ListRecipes();
            WindowsFormsUtility.FormatGridSearchResults(gRecipe, "Recipe");
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            gRecipe.KeyDown += GRecipe_KeyDown;
        }

        private void ListRecipes()
        {
            DataTable dt = Recipe.ListRecipes();
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int RowIndex)
        {
            int id = 0;
            if (RowIndex > -1)
            {
              id = (int)gRecipe.Rows[RowIndex].Cells["RecipeId"].Value;
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
              ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeData), id);
            }
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipe.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipe.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

    }
}
