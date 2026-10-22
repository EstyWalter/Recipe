namespace RecipeWinForms
{
    partial class frmCookbook
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
            btnNewCookbook = new Button();
            tblMain = new TableLayoutPanel();
            gCookbook = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbook).BeginInit();
            SuspendLayout();
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.Dock = DockStyle.Left;
            btnNewCookbook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewCookbook.Location = new Point(4, 4);
            btnNewCookbook.Margin = new Padding(4);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(273, 170);
            btnNewCookbook.TabIndex = 1;
            btnNewCookbook.Text = "New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(btnNewCookbook, 0, 0);
            tblMain.Controls.Add(gCookbook, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3899784F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80.61002F));
            tblMain.Size = new Size(1359, 918);
            tblMain.TabIndex = 2;
            // 
            // gCookbook
            // 
            gCookbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbook.Dock = DockStyle.Fill;
            gCookbook.Location = new Point(3, 181);
            gCookbook.Name = "gCookbook";
            gCookbook.RowHeadersWidth = 51;
            gCookbook.Size = new Size(1353, 734);
            gCookbook.TabIndex = 0;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 918);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook List";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbook).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNewCookbook;
        private TableLayoutPanel tblMain;
        private DataGridView gCookbook;
    }
}