using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Users, Cuisine, Ingredient, Measurment, course }

        TableTypeEnum currenttable = TableTypeEnum.Users;

        DataTable dtlist = new();
        public frmDataMaintenance()
        {
            InitializeComponent();
            optUsers.Click += Opt_Click;
            optMeasurments.Click += Opt_Click;
            optCuisine.Click += Opt_Click;
            optCourse.Click += Opt_Click;
            optIngredient.Click += Opt_Click;
            gData.CellContentClick += GData_CellContentClick;
            btnSave.Click += BtnSave_Click;
            BindData(currenttable);
        }

        private void BindData(TableTypeEnum tableType)
        {
            currenttable = tableType;
            gData.Columns.Clear();
            dtlist = DataMaintenance.GetDataList(tableType.ToString());
            gData.DataSource = dtlist;
            WindowsFormsUtility.FormatGridForEdit(gData, tableType.ToString());
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, "Delete");
        }

        private void Opt_Click(object? sender, EventArgs e)
        {
            foreach (Control c in pOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
                optCourse.Tag = TableTypeEnum.course;
                optCuisine.Tag = TableTypeEnum.Cuisine;
                optIngredient.Tag = TableTypeEnum.Ingredient;
                optUsers.Tag = TableTypeEnum.Users;
                optMeasurments.Tag = TableTypeEnum.Measurment;
            }
        }

        private string GetCellValue(int row, int coloumn)
        {
            return gData.Rows[row].Cells[coloumn].Value.ToString();
        }

        private void DeleteData(int row)
        {
            string value = GetCellValue(row, 1);
            if (value != "")
            {
                int id = WindowsFormsUtility.GetIdFromGrid(gData, row, currenttable.ToString() + "id");
                if (id > 0)
                {
                    try
                    {
                        if(currenttable == TableTypeEnum.Users)
                        {
                            var response = MessageBox.Show("Are you sure you want to delete this user and all related recipes, meals and cookbooks?", "Recipe", MessageBoxButtons.YesNo);
                            if (response == DialogResult.No)
                            {
                                return;
                            }
                        }
                        DataMaintenance.DeleteRow(id, currenttable.ToString());
                        gData.Rows.RemoveAt(row);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
                else if (id < gData.Rows.Count)
                {
                    gData.Rows.RemoveAt(row);
                }

            }
        }

        private bool SaveData(TableTypeEnum tableType)
        {
            bool b = false;
            DataMaintenance.UpdateTable(dtlist, tableType.ToString());
            return b; 
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }

        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteData(e.RowIndex);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            SaveData(currenttable);
        }

    }
}
