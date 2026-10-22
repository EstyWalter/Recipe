using System.Data;

namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtUsers = new();
        BindingSource bindsource = new();
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            BindData();
            dtUsers = Users.GetUsersDataTable();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtcookbook, "Users");
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            dtcookbook = Cookbook.GetCookbook("CookbookGet", "@All", 1);
            bindsource.DataSource = dtcookbook;
        }

        private void AutoCreateCookbook()
        {
            Application.UseWaitCursor = true;
            try
            {
                int id = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
                dtcookbook = ComplexOperations.AutoCreateCookbook(id);
                BindData();
                int newid = ComplexOperations.GetId(dtcookbook, "CookbookId");
                OpenForm(newid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }

        private void OpenForm(int newid)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookData), newid);
            }
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreateCookbook();
        }


    }
}
