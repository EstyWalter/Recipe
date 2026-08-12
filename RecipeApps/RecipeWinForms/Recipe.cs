using CPUFramework;
using System.Data;
using System.Diagnostics;
using System.Security.AccessControl;
namespace RecipeWinForms
{
    public partial class Recipe : Form
    {
        public Recipe()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            FormatGrid();
        }

        private void SearchRecipe(string RecipeName)
        {
            string sql = "select RecipeId, RecipeName, DateDrafted, DatePublished, DateArchived, Calories, Statuses from Recipe r where r.RecipeName like '%" + RecipeName + "%'";
            Debug.Print(sql);
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int RowIndex)
        {
            int id = (int)gRecipe.Rows[RowIndex].Cells["RecipeId"].Value;
            FrmRecipeData frm = new FrmRecipeData();
            frm.ShowForm(id);
        }

        private void FormatGrid()
        {
            gRecipe.AllowUserToAddRows = false;
            gRecipe.ReadOnly = true;
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchRecipe(txtRecipe.Text);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }
    }
}
