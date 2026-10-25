using CPUFramework;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipeData : Form
    {
        DataTable dtRecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtingredient = new();
        DataTable dtMeasurement = new();
        DataTable dtdirections = new();
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;

        public frmRecipeData()
        {
            InitializeComponent();
            this.Shown += FrmRecipeData_Shown;
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            btnStepsSave.Click += BtnStepsSave_Click;
            btnIngredientsSave.Click += BtnIngredientsSave_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gSteps.DataError += DataError;
            gIngredients.DataError += DataError;
            this.FormClosing += FrmRecipeData_FormClosing;
        }

        public void ShowForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeidval;
            dtRecipe = Recipe.GetRecipe("@RecipeId", recipeidval);
            bindsource.DataSource = dtRecipe;
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtStatuses, bindsource);
            if (recipeidval == 0)
            {
                EnableBtn(false);
                dtRecipe.Rows.Add();
            }
            Debug.Print(dtRecipe.Rows.Count.ToString());
            DataTable dtUsers = Users.GetUsersDataTable();
            WindowsFormsUtility.SetListBinding(lstUserName, dtUsers, dtRecipe, "Users");
            DataTable dtCuisine = Cuisine.GetCuisineDataTable();
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            this.Text = GetRecipeDesc();
        }

        private void FrmRecipeData_Shown(object? sender, EventArgs e)
        {
            BindGingredients(recipeid);
            BindGsteps(recipeid);
        }

        public void BindGingredients(int id)
        {
            dtrecipeingredient = RecipeIngredientDirections.GetDataTableWithId("RecipeIngredientGet", id);
            dtMeasurement = RecipeIngredientDirections.GetDataTable("MeasurementGet");
            dtingredient = RecipeIngredientDirections.GetDataTable("IngredientGet");
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, dtingredient, "Ingredient", "Ingredientname");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, dtMeasurement, "Measurement", "MeasurementType");
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "Ingredients");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, "Delete");
        }

        public void BindGsteps(int id)
        {
            dtdirections = RecipeIngredientDirections.GetDataTableWithId("DirectionsGet", id);
            gSteps.DataSource = dtdirections;
            WindowsFormsUtility.FormatGridForEdit(gSteps, "Direction");
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, "Delete");
        }

        private void EnableBtn(bool b)
        {
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                int id = (int)dtRecipe.Rows[0]["RecipeId"];
                Recipe.Delete(id, dtRecipe);
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

        private bool Save()
        {
            Application.UseWaitCursor = true;
            bool b = false;
            try
            {
                Recipe.Save(dtRecipe);
                b = true;
                this.Text = GetRecipeDesc();
                EnableBtn(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private string GetCellValue(DataGridView grid, int row = 0)
        {
            string s = "";
            try
            {
                s = grid.Rows[row].Cells[0].Value.ToString();
            }
            catch
            {
                s = "";
            }
            return s;
        }

        private void DeleteDirections(int rowindex)
        {
            if (rowindex >= 0)
            {
                int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowindex, "DirectionsId");
                if (id > 0)
                {
                    try
                    {
                        RecipeIngredientDirections.DeleteFromTable("DirectionsDelete", "@DirectionsId", id);
                        gSteps.Rows.RemoveAt(rowindex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
                else if (id < gSteps.Rows.Count)
                {
                    string s = GetCellValue(gSteps, rowindex);
                    if (s != "")
                    {
                        gSteps.Rows.RemoveAt(rowindex);
                    }
                }
            }
        }

        private void DeleteRecipeIngredient(int rowindex)
        {
            if (rowindex >= 0)
            {
                int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeIngredientId");
                if (id > 0)
                {
                    try
                    {
                        RecipeIngredientDirections.DeleteFromTable("RecipeIngredientDelete", "@RecipeIngredientId", id);
                        gIngredients.Rows.RemoveAt(rowindex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
                else if (id < gIngredients.Rows.Count)
                {
                    string s = GetCellValue(gIngredients, rowindex);
                    if (s != "")
                    {
                        gIngredients.Rows.RemoveAt(rowindex);
                    }
                }
            }
        }

        private bool IngredientSave()
        {
            Application.UseWaitCursor = true;
            bool b = false;
            try
            {
                recipeid = Recipe.FindRecipeId(dtRecipe);
                RecipeIngredientDirections.SaveTable(dtrecipeingredient, "RecipeIngredientUpdate", recipeid, "RecipeId");
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private bool StepsSave()
        {
            Application.UseWaitCursor = true;
            bool b = false;
            try
            {
                RecipeIngredientDirections.SaveTable(dtdirections, "DirectionsUpdate", recipeid, "RecipeId");
                b = true;
                EnableBtn(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void ChangeStatus()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmStatus), recipeid);
            }
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            }
            return value;
        }

        private void BtnIngredientsSave_Click(object? sender, EventArgs e)
        {
            IngredientSave();
        }

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {
            StepsSave();
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteDirections(e.RowIndex);
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
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

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeStatus();
        }

        private void FrmRecipeData_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtRecipe) || SQLUtility.TableHasChanges(dtrecipeingredient) || SQLUtility.TableHasChanges(dtdirections))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing? ", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = IngredientSave();
                        b = StepsSave();
                        b = Save();
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

        private void DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            WindowsFormsUtility.DataError();
        }
    }
}
