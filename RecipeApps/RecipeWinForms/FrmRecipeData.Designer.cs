namespace RecipeWinForms
{
    partial class FrmRecipeData
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
            lblDateArchived = new Label();
            lblDatePublished = new Label();
            lblCalories = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtCalories = new TextBox();
            lblDateDrafted = new Label();
            lblRecipeName = new Label();
            txtDateDrafted = new TextBox();
            txtRecipeName = new TextBox();
            lblStatuses = new Label();
            txtStatuses = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2004F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7996F));
            tblMain.Controls.Add(lblDateArchived, 0, 2);
            tblMain.Controls.Add(lblDatePublished, 0, 1);
            tblMain.Controls.Add(lblCalories, 0, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 1);
            tblMain.Controls.Add(txtDateArchived, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(lblDateDrafted, 0, 3);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(txtDateDrafted, 1, 3);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lblStatuses, 0, 5);
            tblMain.Controls.Add(txtStatuses, 1, 5);
            tblMain.Controls.Add(tblButtons, 1, 6);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2627983F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2627945F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2627945F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2627945F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2627945F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2627945F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.423231F));
            tblMain.Size = new Size(998, 635);
            tblMain.TabIndex = 0;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Font = new Font("Segoe UI", 12F);
            lblDateArchived.Location = new Point(185, 192);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(130, 96);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.Text = "DateArchived";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Font = new Font("Segoe UI", 12F);
            lblDatePublished.Location = new Point(179, 96);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(143, 96);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.Text = "Date Published";
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 12F);
            lblCalories.Location = new Point(210, 384);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(81, 96);
            lblCalories.TabIndex = 4;
            lblCalories.Text = "Calories";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDatePublished.Location = new Point(655, 99);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(189, 27);
            txtDatePublished.TabIndex = 8;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDateArchived.Location = new Point(655, 195);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(189, 27);
            txtDateArchived.TabIndex = 9;
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtCalories.Location = new Point(655, 387);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(189, 27);
            txtCalories.TabIndex = 11;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Font = new Font("Segoe UI", 12F);
            lblDateDrafted.Location = new Point(188, 288);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(124, 96);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Date Drafted";
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI", 12F);
            lblRecipeName.Location = new Point(187, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(126, 96);
            lblRecipeName.TabIndex = 3;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDateDrafted.Location = new Point(655, 291);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(189, 27);
            txtDateDrafted.TabIndex = 7;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtRecipeName.Location = new Point(655, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(189, 27);
            txtRecipeName.TabIndex = 10;
            // 
            // lblStatuses
            // 
            lblStatuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblStatuses.AutoSize = true;
            lblStatuses.Font = new Font("Segoe UI", 12F);
            lblStatuses.Location = new Point(209, 480);
            lblStatuses.Name = "lblStatuses";
            lblStatuses.Size = new Size(83, 96);
            lblStatuses.TabIndex = 5;
            lblStatuses.Text = "Statuses";
            // 
            // txtStatuses
            // 
            txtStatuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtStatuses.Location = new Point(655, 483);
            txtStatuses.Name = "txtStatuses";
            txtStatuses.Size = new Size(189, 27);
            txtStatuses.TabIndex = 12;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(504, 579);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tblButtons.Size = new Size(491, 53);
            tblButtons.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = SystemColors.Info;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(239, 47);
            btnSave.TabIndex = 14;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(248, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(240, 47);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // FrmRecipeData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 635);
            Controls.Add(tblMain);
            Name = "FrmRecipeData";
            Text = "FrmRecipeData";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblDateDrafted;
        private Label lblDateArchived;
        private Label lblDatePublished;
        private Label lblCalories;
        private Label lblRecipeName;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtCalories;
        private TextBox txtDateDrafted;
        private TextBox txtRecipeName;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private Label lblStatuses;
        private TextBox txtStatuses;
    }
}