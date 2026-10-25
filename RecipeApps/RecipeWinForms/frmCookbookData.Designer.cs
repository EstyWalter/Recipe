namespace RecipeWinForms
{
    partial class frmCookbookData
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
            Label lblUser;
            tblMain = new TableLayoutPanel();
            tblCookbookEdit = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lblPrice = new Label();
            lblActive = new Label();
            lstUserName = new ComboBox();
            lblCookbookName = new Label();
            txtBookName = new TextBox();
            lblDateCreated = new Label();
            pCookbookEdit = new Panel();
            txtDateCreated = new TextBox();
            txtPrice = new TextBox();
            cbxBookActive = new CheckBox();
            gRecipeEdit = new DataGridView();
            btnSaveRecipe = new Button();
            lblUser = new Label();
            tblMain.SuspendLayout();
            tblCookbookEdit.SuspendLayout();
            pCookbookEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeEdit).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(3, 74);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(142, 37);
            lblUser.TabIndex = 5;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblCookbookEdit, 0, 0);
            tblMain.Controls.Add(gRecipeEdit, 0, 2);
            tblMain.Controls.Add(btnSaveRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 36.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.571428F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 54.6031761F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // tblCookbookEdit
            // 
            tblCookbookEdit.ColumnCount = 2;
            tblCookbookEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5283365F));
            tblCookbookEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.4716644F));
            tblCookbookEdit.Controls.Add(btnSave, 0, 0);
            tblCookbookEdit.Controls.Add(btnDelete, 1, 0);
            tblCookbookEdit.Controls.Add(lblPrice, 0, 4);
            tblCookbookEdit.Controls.Add(lblActive, 0, 5);
            tblCookbookEdit.Controls.Add(lstUserName, 1, 2);
            tblCookbookEdit.Controls.Add(lblUser, 0, 2);
            tblCookbookEdit.Controls.Add(lblCookbookName, 0, 1);
            tblCookbookEdit.Controls.Add(txtBookName, 1, 1);
            tblCookbookEdit.Controls.Add(lblDateCreated, 1, 3);
            tblCookbookEdit.Controls.Add(pCookbookEdit, 1, 4);
            tblCookbookEdit.Controls.Add(cbxBookActive, 1, 5);
            tblCookbookEdit.Dock = DockStyle.Fill;
            tblCookbookEdit.Location = new Point(3, 3);
            tblCookbookEdit.Name = "tblCookbookEdit";
            tblCookbookEdit.RowCount = 6;
            tblCookbookEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCookbookEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCookbookEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCookbookEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCookbookEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCookbookEdit.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCookbookEdit.Size = new Size(1094, 225);
            tblCookbookEdit.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 31);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Left;
            btnDelete.Location = new Point(151, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 148);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(142, 37);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Dock = DockStyle.Fill;
            lblActive.Location = new Point(3, 185);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(142, 40);
            lblActive.TabIndex = 7;
            lblActive.Text = "Active";
            lblActive.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(151, 77);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(170, 36);
            lstUserName.TabIndex = 1;
            // 
            // lblCookbookName
            // 
            lblCookbookName.AutoSize = true;
            lblCookbookName.Dock = DockStyle.Fill;
            lblCookbookName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCookbookName.Location = new Point(3, 37);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(142, 37);
            lblCookbookName.TabIndex = 4;
            lblCookbookName.Text = "Cookbook Name ";
            lblCookbookName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(151, 40);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(170, 34);
            txtBookName.TabIndex = 0;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(556, 111);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(130, 37);
            lblDateCreated.TabIndex = 2;
            lblDateCreated.Text = "DateCreated :";
            lblDateCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pCookbookEdit
            // 
            pCookbookEdit.Controls.Add(txtDateCreated);
            pCookbookEdit.Controls.Add(txtPrice);
            pCookbookEdit.Dock = DockStyle.Fill;
            pCookbookEdit.Location = new Point(151, 151);
            pCookbookEdit.Name = "pCookbookEdit";
            pCookbookEdit.Size = new Size(940, 31);
            pCookbookEdit.TabIndex = 2;
            // 
            // txtDateCreated
            // 
            txtDateCreated.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDateCreated.Location = new Point(410, -3);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(152, 34);
            txtDateCreated.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(0, 0);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 34);
            txtPrice.TabIndex = 1;
            // 
            // cbxBookActive
            // 
            cbxBookActive.AutoSize = true;
            cbxBookActive.Checked = true;
            cbxBookActive.CheckState = CheckState.Checked;
            cbxBookActive.Dock = DockStyle.Left;
            cbxBookActive.Location = new Point(151, 188);
            cbxBookActive.Name = "cbxBookActive";
            cbxBookActive.Size = new Size(88, 34);
            cbxBookActive.TabIndex = 3;
            cbxBookActive.Text = "Active";
            cbxBookActive.UseVisualStyleBackColor = true;
            // 
            // gRecipeEdit
            // 
            gRecipeEdit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gRecipeEdit.BackgroundColor = SystemColors.WindowFrame;
            gRecipeEdit.CausesValidation = false;
            gRecipeEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeEdit.Dock = DockStyle.Fill;
            gRecipeEdit.Location = new Point(3, 288);
            gRecipeEdit.Name = "gRecipeEdit";
            gRecipeEdit.RowHeadersWidth = 51;
            gRecipeEdit.Size = new Size(1094, 339);
            gRecipeEdit.TabIndex = 2;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Dock = DockStyle.Left;
            btnSaveRecipe.Location = new Point(3, 234);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(94, 48);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // frmCookbookData
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbookData";
            Text = "Cookbook Data";
            tblMain.ResumeLayout(false);
            tblCookbookEdit.ResumeLayout(false);
            tblCookbookEdit.PerformLayout();
            pCookbookEdit.ResumeLayout(false);
            pCookbookEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecipeEdit;
        private TableLayoutPanel tblCookbookEdit;
        private Button btnSave;
        private Button btnDelete;
        private Label lblPrice;
        private Label lblActive;
        private ComboBox lstUserName;
        private Label lblCookbookName;
        private TextBox txtBookName;
        private Label lblDateCreated;
        private Panel pCookbookEdit;
        private TextBox txtDateCreated;
        private TextBox txtPrice;
        private CheckBox cbxBookActive;
        private Button btnSaveRecipe;
    }
}