namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileDashBoard = new ToolStripMenuItem();
            mnuRecipe = new ToolStripMenuItem();
            mnuRecipesList = new ToolStripMenuItem();
            mnuRecipesNewRecipes = new ToolStripMenuItem();
            mnuRecipesClone = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbooksList = new ToolStripMenuItem();
            mnuCookbooksNewCookBooks = new ToolStripMenuItem();
            mnuCookbooksAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuDataMaintenanceEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuWindowsCascade = new ToolStripMenuItem();
            mnuWindowsTile = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipe, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1427, 36);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashBoard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(56, 32);
            mnuFile.Text = "File";
            // 
            // mnuFileDashBoard
            // 
            mnuFileDashBoard.Name = "mnuFileDashBoard";
            mnuFileDashBoard.Size = new Size(194, 32);
            mnuFileDashBoard.Text = "Dashboard";
            // 
            // mnuRecipe
            // 
            mnuRecipe.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipesList, mnuRecipesNewRecipes, mnuRecipesClone });
            mnuRecipe.Name = "mnuRecipe";
            mnuRecipe.Size = new Size(91, 32);
            mnuRecipe.Text = "Recipes";
            // 
            // mnuRecipesList
            // 
            mnuRecipesList.Name = "mnuRecipesList";
            mnuRecipesList.Size = new Size(228, 32);
            mnuRecipesList.Text = "List";
            // 
            // mnuRecipesNewRecipes
            // 
            mnuRecipesNewRecipes.Name = "mnuRecipesNewRecipes";
            mnuRecipesNewRecipes.Size = new Size(228, 32);
            mnuRecipesNewRecipes.Text = "New Recipe";
            // 
            // mnuRecipesClone
            // 
            mnuRecipesClone.Name = "mnuRecipesClone";
            mnuRecipesClone.Size = new Size(228, 32);
            mnuRecipesClone.Text = "Clone A Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(77, 32);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(127, 32);
            mnuMealsList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbooksList, mnuCookbooksNewCookBooks, mnuCookbooksAutoCreate });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(126, 32);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbooksList
            // 
            mnuCookbooksList.Name = "mnuCookbooksList";
            mnuCookbooksList.Size = new Size(234, 32);
            mnuCookbooksList.Text = "List";
            // 
            // mnuCookbooksNewCookBooks
            // 
            mnuCookbooksNewCookBooks.Name = "mnuCookbooksNewCookBooks";
            mnuCookbooksNewCookBooks.Size = new Size(234, 32);
            mnuCookbooksNewCookBooks.Text = "New Cookbook";
            // 
            // mnuCookbooksAutoCreate
            // 
            mnuCookbooksAutoCreate.Name = "mnuCookbooksAutoCreate";
            mnuCookbooksAutoCreate.Size = new Size(234, 32);
            mnuCookbooksAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMaintenanceEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(184, 32);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuDataMaintenanceEditData
            // 
            mnuDataMaintenanceEditData.Name = "mnuDataMaintenanceEditData";
            mnuDataMaintenanceEditData.Size = new Size(178, 32);
            mnuDataMaintenanceEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowsCascade, mnuWindowsTile });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(107, 32);
            mnuWindows.Text = "Windows";
            // 
            // mnuWindowsCascade
            // 
            mnuWindowsCascade.Name = "mnuWindowsCascade";
            mnuWindowsCascade.Size = new Size(169, 32);
            mnuWindowsCascade.Text = "Cascade";
            // 
            // mnuWindowsTile
            // 
            mnuWindowsTile.Name = "mnuWindowsTile";
            mnuWindowsTile.Size = new Size(169, 32);
            mnuWindowsTile.Text = "Tile";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(0, 36);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1427, 25);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 815);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            RightToLeftLayout = true;
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileDashBoard;
        private ToolStripMenuItem mnuRecipe;
        private ToolStripMenuItem mnuRecipesList;
        private ToolStripMenuItem mnuRecipesNewRecipes;
        private ToolStripMenuItem mnuRecipesClone;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbooksList;
        private ToolStripMenuItem mnuCookbooksNewCookBooks;
        private ToolStripMenuItem mnuCookbooksAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuDataMaintenanceEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuWindowsCascade;
        private ToolStripMenuItem mnuWindowsTile;
    }
}