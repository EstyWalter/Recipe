using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookbookData : Form
    {
        BindingSource bindsource = new();
        int cookbookid = 0;
        DataTable dtcookbook = new();
        DataTable dtrecipe = new();
        DataTable dtcookbookrecipe = new();

        public frmCookbookData()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            btnDelete.Click += BtnDelete_Click;
            gRecipeEdit.CellContentClick += GRecipeEdit_CellContentClick;
            this.Shown += FrmCookbookData_Shown;
            this.FormClosing += FrmCookbookData_FormClosing;
        }

        public void ShowForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookidval;
            dtcookbook = Cookbook.GetCookbook("CookbookGet", "@CookbookId", cookbookidval);
            bindsource.DataSource = dtcookbook;
            if (cookbookidval == 0)
            {
                dtcookbook.Rows.Add();
                Enablebtn(false);
            }
            DataTable dtusers = Users.GetUsersDataTable();
            WindowsFormsUtility.SetControlBinding(txtBookName, bindsource);
            WindowsFormsUtility.SetControlBinding(cbxBookActive, bindsource);
            DataTable dtUsers = Users.GetUsersDataTable();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtcookbook, "Users");
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            this.Text = GetCookbookDesc();
        }

        private void FrmCookbookData_Shown(object? sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dtcookbookrecipe = Cookbook.GetCookbook("CookbookRecipeGet", "@CookbookId", cookbookid);
            gRecipeEdit.DataSource = dtcookbookrecipe;
            dtrecipe = Recipe.GetRecipe("@All", 1, 1);
            WindowsFormsUtility.AddComboBoxToGrid(gRecipeEdit, dtrecipe, "Recipe", "RecipeName");
            WindowsFormsUtility.FormatGridForEdit(gRecipeEdit, "CookbookRecipe");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipeEdit, "Delete");
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                this.Text = GetCookbookDesc();
                Enablebtn(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        //  private bool SaveRecipe()
        //{/
        //    bool b = false;
        //   string value = GetCellValue();
        // if (value != "")
        // {
        //     try
        //    {
        /// //Application.UseWaitCursor = true;
        /// if(gRecipeEdit.CurrentCell.RowIndex != null)
        ///{
        ///    int currentRowIndex = gRecipeEdit.CurrentCell.RowIndex;
        ///    int nextRowIndex = currentRowIndex + 1;
        ///    if (nextRowIndex >= gRecipeEdit.Rows.Count)
        ///    {
        ///        nextRowIndex = currentRowIndex;
        ///    }
        ///    int currentColIndex = gRecipeEdit.CurrentCell.ColumnIndex;
        ///    gRecipeEdit.CurrentCell = gRecipeEdit.Rows[nextRowIndex].Cells[currentColIndex];
        ///}
        ///    
        ///    cookbookid = Cookbook.FindCookbookId(dtcookbook);
        ///    Cookbook.SaveRecipe(dtcookbookrecipe, cookbookid);
        ///    b = true;
        ///}
        ///catch (Exception ex)
        ///{
        ///    MessageBox.Show(ex.Message, "Cookbook");
        ///}
        ///finally
        ///{
        ///    Application.UseWaitCursor = false;
        // ///  }
        //  }
        //return b;



        private bool SaveRecipe()
        {
            try
            {
                Application.UseWaitCursor = true;

                if (!gRecipeEdit.EndEdit())
                {
                    return false;
                }
                gRecipeEdit.BindingContext[gRecipeEdit.DataSource]
                    ?.EndCurrentEdit();

                for (int i = dtcookbookrecipe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = dtcookbookrecipe.Rows[i];
                    if (row.RowState != DataRowState.Deleted &&
                        (row.IsNull("RecipeId") ||
                         !int.TryParse(row["RecipeId"].ToString(), out int id) ||
                         id <= 0))
                    {
                        dtcookbookrecipe.Rows.Remove(row);
                    }
                }

                if (dtcookbookrecipe.Rows.Count == 0)
                {
                    return false;
                }
                cookbookid = Cookbook.FindCookbookId(dtcookbook);
                if (cookbookid <= 0)
                {
                    MessageBox.Show("Please save the cookbook first.", "Cookbook");
                    return false;
                }
                Cookbook.SaveRecipe(dtcookbookrecipe, cookbookid);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
                return false;
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                var returns = MessageBox.Show("Are you sure you want to delete the cookbook", Application.ProductName, MessageBoxButtons.YesNoCancel);
                if (returns == DialogResult.Yes)
                {
                    Cookbook.Delete("CookbookDelete", "@CookbookId", cookbookid);
                    this.Close();
                }
                else if (returns == DialogResult.No)
                {
                    this.Close();
                }

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

        private string GetCellValue(int row = 0)
        {
            string s = "";
            if (gRecipeEdit.Rows[row].Cells[0].Value != null)
            {
                return s != gRecipeEdit.Rows[row].Cells[0].Value.ToString() ? "not empty" : s;
            }
            return s;
        }

        private void DeleteRecipeFromCookbook(int row)
        {

            int id = WindowsFormsUtility.GetIdFromGrid(gRecipeEdit, row, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    Cookbook.Delete("CookbookRecipeDelete", "@CookbookRecipeId", id);
                    gRecipeEdit.Rows.RemoveAt(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipeEdit.Rows.Count)
            {
                string value = GetCellValue(row);
                if (value != "")
                {
                    gRecipeEdit.Rows.RemoveAt(row);
                }

            }

        }

        private void Enablebtn(bool b)
        {
            btnSaveRecipe.Enabled = b;
            btnDelete.Enabled = b;
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "cookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "BookName");
            }
            return value;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveRecipe();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void GRecipeEdit_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeFromCookbook(e.RowIndex);
        }

        private void FrmCookbookData_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook) || SQLUtility.TableHasChanges(dtcookbookrecipe))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing? ", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        b = SaveRecipe();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }


    }
}
