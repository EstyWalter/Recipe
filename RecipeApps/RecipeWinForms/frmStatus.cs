using CPUFramework;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace RecipeWinForms
{
    public partial class frmStatus : Form
    {
        BindingSource bindsource = new();
        DataTable dt = new();
        int recipeid;
        public frmStatus()
        {
            InitializeComponent();
            btnArchived.Click += BtnDates_Click;
            btnDrafted.Click += BtnDates_Click;
            btnPublished.Click += BtnDates_Click;
        }

        public void BindData(int id)
        {
            recipeid = id;
            dt = Recipe.GetRecipe("@RecipeId", id);
            bindsource.DataSource = dt;
            DisableButtons();
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblStatuses, bindsource);
        }

        private void BtnDates_Click(object? sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            string s = btn.Text;
            var response = MessageBox.Show("Are you sure you want to change this recipe to " + s + "?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            else if (response == DialogResult.Yes)
            {
                try
                {

                    switch (btn.Name)
                    {
                        case "btnDrafted":
                            ClearOldStatus("DatePublished");
                            ClearOldStatus("DateArchived");
                            SaveNewStatus(txtDateDrafted);
                            Recipe.Save(dt);
                            break;
                        case "btnPublished":
                            SaveNewStatus(txtDatePublished);
                            ClearOldStatus("DateArchived");
                            Recipe.Save(dt);
                            break;
                        case "btnArchived":
                            SaveNewStatus(txtDateArchived);
                            Recipe.Save(dt);
                            break;
                    }
              
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    dt = Recipe.GetRecipe("@RecipeId", recipeid);
                    bindsource.DataSource = dt;
                    DisableButtons();
                }
            }

        }

        private void ClearOldStatus(string columnname)
        {
            dt.Rows[0][columnname] = DBNull.Value;
        }

        private void SaveNewStatus(TextBox txt)
        {
            txt.Text = DateTime.Now.ToString();
        }

        private void DisableButtons()
        {
            btnDrafted.Enabled = true;
            btnPublished.Enabled = true;
            btnArchived.Enabled = true;
            
            string s = SQLUtility.GetValueFromFirstRowAsString(dt, "Statuses");
            switch (s)
            {
                case "Drafted":
                    btnDrafted.Enabled = false;
                    break;
                case "Published":
                    btnPublished.Enabled = false;
                    break;
                case "Archived":
                    btnArchived.Enabled = false;
                    break;
            }
        }

    }
}

