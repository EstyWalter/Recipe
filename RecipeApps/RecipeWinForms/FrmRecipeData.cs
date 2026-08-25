using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class FrmRecipeData : Form
    {
        DataTable dtRecipe;
        public FrmRecipeData()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
        }

        public void ShowForm(int recipeid)
        {
            dtRecipe = Recipe.SearchRecipeInfo(recipeid);
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            Debug.Print(dtRecipe.Rows.Count.ToString());
            DataTable dtUsers = Recipe.GetUsersDataTable();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtRecipe, "Users");
            DataTable dtCuisine = Recipe.GetCuisineDataTable();
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtStatuses, dtRecipe);
            this.Show();
        }

        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                int id = (int)dtRecipe.Rows[0]["RecipeId"];
                Recipe.Delete(id, dtRecipe);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
         
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
      
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
            this.Close();
        }

    }
}
