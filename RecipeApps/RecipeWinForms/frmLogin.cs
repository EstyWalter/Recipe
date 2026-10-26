using System.Configuration;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool currentstatus = false;
        public frmLogin()
        {
            InitializeComponent();
            btnOk.Click += BtnOk_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text = this.Text + " DEV";
#endif
            txtUserId.Text = Properties.Settings.Default.UserId;
            this.ShowDialog();
            Properties.Settings.Default.UserId = txtUserId.Text;
            Properties.Settings.Default.Save();
            return currentstatus;
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";
#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                dbManager.SetConnectionString(connstring, true, txtUserId.Text, txtPassword.Text);
                currentstatus = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid login. Try again.", Application.ProductName);
            }
           
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
