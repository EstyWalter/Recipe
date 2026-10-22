using System.Data;

namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        DataTable dtrecipe = new();
        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            WindowsFormsUtility.SetListBinding(lstRecipeName, dtrecipe, dtrecipe, "Recipe");
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
           dtrecipe = Recipe.GetRecipe("@All", 1);
        }

        private void CloneRecipe()
        {
            Application.UseWaitCursor = true;
            try
            {
                int id = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
                ComplexOperations.CloneRecipe(id);
                BindData();
                int newid = ComplexOperations.GetId(dtrecipe, "RecipeId");
                OpenForm(newid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clone Recipe");
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
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeData), newid);
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }
   
    }
}
