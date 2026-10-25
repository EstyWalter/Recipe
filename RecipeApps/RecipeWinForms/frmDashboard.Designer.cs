namespace RecipeWinForms
{
    partial class frmDashboard
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
            tblMain = new TableLayoutPanel();
            lblBIgWelcome = new Label();
            lblWelcome = new Label();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblGrid = new TableLayoutPanel();
            gDashboard = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDashboard).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = SystemColors.GradientInactiveCaption;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblBIgWelcome, 0, 0);
            tblMain.Controls.Add(lblWelcome, 0, 1);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Controls.Add(tblGrid, 0, 2);
            tblMain.Cursor = Cursors.IBeam;
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.475218F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0787163F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3935852F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0524788F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1123, 706);
            tblMain.TabIndex = 0;
            // 
            // lblBIgWelcome
            // 
            lblBIgWelcome.AutoSize = true;
            lblBIgWelcome.BackColor = Color.White;
            lblBIgWelcome.Dock = DockStyle.Fill;
            lblBIgWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBIgWelcome.Location = new Point(3, 0);
            lblBIgWelcome.Name = "lblBIgWelcome";
            lblBIgWelcome.Size = new Size(1117, 66);
            lblBIgWelcome.TabIndex = 0;
            lblBIgWelcome.Text = "Hearty Hearth Desktop App";
            lblBIgWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.White;
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(3, 66);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1117, 78);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create, edit, insert and delete recipes. You will be able to do the same for the cookbooks.";
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 538);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1117, 165);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.BackColor = SystemColors.ButtonFace;
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(366, 159);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.BackColor = SystemColors.ButtonFace;
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(375, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(366, 159);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.BackColor = SystemColors.ButtonFace;
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(747, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(367, 159);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // tblGrid
            // 
            tblGrid.AutoSize = true;
            tblGrid.BackColor = Color.White;
            tblGrid.ColumnCount = 3;
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8119965F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.033123F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0653534F));
            tblGrid.Controls.Add(gDashboard, 1, 1);
            tblGrid.Dock = DockStyle.Fill;
            tblGrid.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblGrid.Location = new Point(3, 147);
            tblGrid.Name = "tblGrid";
            tblGrid.RowCount = 3;
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0096626F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 70.12987F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1038952F));
            tblGrid.Size = new Size(1117, 385);
            tblGrid.TabIndex = 2;
            // 
            // gDashboard
            // 
            gDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gDashboard.BackgroundColor = Color.White;
            gDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDashboard.Dock = DockStyle.Fill;
            gDashboard.Location = new Point(336, 56);
            gDashboard.Name = "gDashboard";
            gDashboard.RowHeadersWidth = 51;
            gDashboard.Size = new Size(430, 263);
            gDashboard.TabIndex = 0;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 706);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "frmDashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gDashboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblBIgWelcome;
        private DataGridView gDashboard;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private TableLayoutPanel tblGrid;
    }
}