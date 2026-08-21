namespace RecipeWinForms
{
    partial class frmRecipe
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
            TableLayoutPanel tblMain;
            gRecipe = new DataGridView();
            btnNew = new Button();
            btnSearch = new Button();
            txtRecipe = new TextBox();
            lblRecipe = new Label();
            tblMain = new TableLayoutPanel();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Controls.Add(btnNew, 3, 0);
            tblMain.Controls.Add(btnSearch, 2, 0);
            tblMain.Controls.Add(txtRecipe, 1, 0);
            tblMain.Controls.Add(lblRecipe, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tblMain.Size = new Size(1237, 780);
            tblMain.TabIndex = 0;
            // 
            // gRecipe
            // 
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gRecipe.BackgroundColor = Color.White;
            gRecipe.ColumnHeadersHeight = 29;
            tblMain.SetColumnSpan(gRecipe, 4);
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.GridColor = SystemColors.Info;
            gRecipe.Location = new Point(3, 81);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.Size = new Size(1231, 696);
            gRecipe.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.AutoSize = true;
            btnNew.BackColor = SystemColors.ButtonFace;
            btnNew.Dock = DockStyle.Fill;
            btnNew.Location = new Point(930, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(304, 72);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.ButtonFace;
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Location = new Point(621, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(303, 72);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtRecipe
            // 
            txtRecipe.Dock = DockStyle.Fill;
            txtRecipe.Location = new Point(312, 3);
            txtRecipe.Multiline = true;
            txtRecipe.Name = "txtRecipe";
            txtRecipe.Size = new Size(303, 72);
            txtRecipe.TabIndex = 1;
            // 
            // lblRecipe
            // 
            lblRecipe.Dock = DockStyle.Fill;
            lblRecipe.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipe.Location = new Point(3, 0);
            lblRecipe.Name = "lblRecipe";
            lblRecipe.Size = new Size(303, 78);
            lblRecipe.TabIndex = 1;
            lblRecipe.Text = "Recipe";
            lblRecipe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Recipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 780);
            Controls.Add(tblMain);
            Name = "Recipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtRecipe;
        private Label lblRecipe;
        private DataGridView gRecipe;
        private Button btnNew;
        private Button btnSearch;
    }
}