namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuRecipesList.Click += MnuRecipesList_Click;
            mnuRecipesNewRecipes.Click += MnuRecipesNewRecipes_Click;
            mnuFileDashBoard.Click += MnuFileDashBoard_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuDataMaintenanceEditData.Click += MnuDataMaintenanceEditData_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuCookbooksNewCookBooks.Click += MnuCookbooksNewCookBooks_Click;
            mnuCookbooksAutoCreate.Click += MnuCookbooksAutoCreate_Click;
            mnuRecipesClone.Click += MnuRecipesClone_Click;
            mnuWindowsCascade.Click += MnuWindowsCascade_Click;
            mnuWindowsTile.Click += MnuWindowsTile_Click;
            this.Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new() { StartPosition = FormStartPosition.CenterParent };
            bool succes = f.ShowLogin();
            if(succes == false)
            {
                this.Close();
                Application.Exit();
                return;
            }
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);
            if (b == false)
            {
                Form? frmnew = null;
                if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    frmnew = f;
                }
                if(frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    frmnew = f;
                }
                if (frmtype == typeof(frmStatus))
                {
                    frmStatus f = new();
                    frmnew = f;
                    f.BindData(pkvalue);
                }
                if (frmtype == typeof(frmRecipeData))
                {
                    frmRecipeData f = new();
                    frmnew = f;
                    f.ShowForm(pkvalue);
                }
                if(frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    frmnew = f;
                }
                if (frmtype == typeof(frmCookbookData))
                {
                    frmCookbookData f = new();
                    frmnew = f;
                    f.ShowForm(pkvalue);
                }
                if (frmtype == typeof(frmMeal))
                {
                    frmMeal f = new();
                    frmnew = f;
                }
                if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    frmnew = f;
                }
                if (frmtype == typeof(frmAutoCreateCookbook))
                {
                    frmAutoCreateCookbook f = new();
                    frmnew = f;
                }
                if(frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    frmnew = f;
                }
                if (frmnew != null)
                {
                    frmnew.MdiParent = this;
                    frmnew.WindowState = FormWindowState.Maximized;
                    frmnew.FormClosed += Frmnew_FormClosed;
                    frmnew.TextChanged += Frmnew_TextChanged;
                    frmnew.Show();
                }
            }
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Frmnew_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Frmnew_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void MnuWindowsTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuWindowsCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuRecipesNewRecipes_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeData));
        }

        private void MnuRecipesList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuFileDashBoard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuCookbooksNewCookBooks_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookData));
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }

        private void MnuDataMaintenanceEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMeal));
        }
        private void MnuRecipesClone_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuCookbooksAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }

    }
}
