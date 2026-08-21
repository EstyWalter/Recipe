using System.Data;
namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            WindowsFormsUtility.FormatGridSearchResults(gRecipe);
        }

        private void SearchRecipe(string recipename)
        {
            DataTable dt = Recipe.SearchByRecipeName(recipename);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int RowIndex)
        {
            int id = 0;
            if(RowIndex > -1)
            {
                id = (int)gRecipe.Rows[RowIndex].Cells["RecipeId"].Value;
            }
            FrmRecipeData frm = new FrmRecipeData();
            frm.ShowForm(id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchRecipe(txtRecipe.Text);
        }
    }
}
