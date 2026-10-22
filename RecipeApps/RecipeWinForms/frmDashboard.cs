using System.CodeDom;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {

        BindingSource bindsource = new();
        public frmDashboard()
        {
            InitializeComponent();
            BindData();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetControlBinding(gDashboard, bindsource);
            DataTable dt = Dashboard.GetDashboard();
            gDashboard.DataSource = dt;
            gDashboard.ReadOnly = true;
            gDashboard.AllowUserToAddRows = false;
            gDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void OpenForm(Type frm)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frm);
            }
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMeal));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

    }
}
