namespace RecipeWinForms
{
    partial class Recipe
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
            lblRecipe = new Label();
            gRecipe = new DataGridView();
            btnSearch = new Button();
            txtRecipe = new TextBox();
            tblMain = new TableLayoutPanel();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lblRecipe, 0, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Controls.Add(btnSearch, 2, 0);
            tblMain.Controls.Add(txtRecipe, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(939, 617);
            tblMain.TabIndex = 0;
            // 
            // lblRecipe
            // 
            lblRecipe.AutoSize = true;
            lblRecipe.Dock = DockStyle.Fill;
            lblRecipe.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipe.Location = new Point(3, 0);
            lblRecipe.Name = "lblRecipe";
            lblRecipe.Size = new Size(75, 57);
            lblRecipe.TabIndex = 1;
            lblRecipe.Text = "Recipe";
            lblRecipe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gRecipe
            // 
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gRecipe.BackgroundColor = SystemColors.ControlLightLight;
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipe, 3);
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.GridColor = SystemColors.Info;
            gRecipe.Location = new Point(3, 60);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.Size = new Size(1385, 678);
            gRecipe.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(280, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(153, 51);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtRecipe
            // 
            txtRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRecipe.Location = new Point(84, 3);
            txtRecipe.Multiline = true;
            txtRecipe.Name = "txtRecipe";
            txtRecipe.Size = new Size(190, 51);
            txtRecipe.TabIndex = 1;
            // 
            // Recipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 617);
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
        private Button btnSearch;
        private TextBox txtRecipe;
        private DataGridView gRecipe;
        private Label lblRecipe;
    }
}