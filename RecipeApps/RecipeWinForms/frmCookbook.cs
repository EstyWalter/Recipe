using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        public frmCookbook()
        {
            InitializeComponent();
            GetCookbookList();
            gCookbook.CellDoubleClick += GCookBook_CellDoubleClick;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbook.KeyDown += GCookbook_KeyDown;
        }

        private void GetCookbookList()
        {
            DataTable dtCookbook = Cookbook.GetCookbook("CookbookGet", "@List", 1);
            gCookbook.DataSource = dtCookbook;
            WindowsFormsUtility.FormatGridSearchResults(gCookbook, "Cookbook");
        }

        private void ShowCookbookDataForm(int RowIndex)
        {
            if(RowIndex != -1)
            {
                int id = 0;
                if (RowIndex > -2)
                {
                    id = (int)gCookbook.Rows[RowIndex].Cells["CookbookId"].Value;
                }
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookData), id);
                }
            }

        }

        private void GCookBook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookDataForm(e.RowIndex);
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookDataForm(-2);
        }

        private void GCookbook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbook.SelectedRows.Count > 0)
            {
                ShowCookbookDataForm(gCookbook.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }
    }
}
