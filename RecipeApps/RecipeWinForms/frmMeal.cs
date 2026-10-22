using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmMeal : Form
    {
        public frmMeal()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            DataTable dtmeal = Meal.GetMealList();
            gMeal.DataSource = dtmeal;
            WindowsFormsUtility.FormatGridSearchResults(gMeal, "Meal");
        }
    }
}
