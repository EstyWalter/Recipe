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
            btnNew = new Button();
            gRecipe = new DataGridView();
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
            tblMain.Controls.Add(btnNew, 0, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8974361F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 89.10256F));
            tblMain.Size = new Size(1260, 649);
            tblMain.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.AutoSize = true;
            btnNew.BackColor = SystemColors.ButtonFace;
            btnNew.Dock = DockStyle.Fill;
            btnNew.Location = new Point(3, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(309, 64);
            btnNew.TabIndex = 0;
            btnNew.Text = "New Recipe";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // gRecipe
            // 
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gRecipe.BackgroundColor = Color.White;
            gRecipe.ColumnHeadersHeight = 29;
            tblMain.SetColumnSpan(gRecipe, 4);
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.GridColor = SystemColors.Info;
            gRecipe.Location = new Point(3, 73);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.Size = new Size(1254, 573);
            gRecipe.TabIndex = 1;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 649);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecipe;
        private Button btnNew;
    }
}