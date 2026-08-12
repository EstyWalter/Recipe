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
            lblStatuses = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtCalories = new TextBox();
            txtStatuses = new TextBox();
            lblDateDrafted = new Label();
            lblRecipeName = new Label();
            txtDateDrafted = new TextBox();
            txtRecipeName = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lblDateArchived, 0, 2);
            tblMain.Controls.Add(lblDatePublished, 0, 1);
            tblMain.Controls.Add(lblCalories, 0, 4);
            tblMain.Controls.Add(lblStatuses, 0, 5);
            tblMain.Controls.Add(txtDatePublished, 1, 1);
            tblMain.Controls.Add(txtDateArchived, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(txtStatuses, 1, 5);
            tblMain.Controls.Add(lblDateDrafted, 0, 3);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(txtDateDrafted, 1, 3);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666622F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.Size = new Size(1018, 698);
            tblMain.TabIndex = 0;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Font = new Font("Segoe UI", 12F);
            lblDateArchived.Location = new Point(9, 232);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(130, 116);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.Text = "DateArchived";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Font = new Font("Segoe UI", 12F);
            lblDatePublished.Location = new Point(3, 116);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(143, 116);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.Text = "Date Published";
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 12F);
            lblCalories.Location = new Point(34, 464);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(81, 116);
            lblCalories.TabIndex = 4;
            lblCalories.Text = "Calories";
            // 
            // lblStatuses
            // 
            lblStatuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblStatuses.AutoSize = true;
            lblStatuses.Font = new Font("Segoe UI", 12F);
            lblStatuses.Location = new Point(33, 580);
            lblStatuses.Name = "lblStatuses";
            lblStatuses.Size = new Size(83, 118);
            lblStatuses.TabIndex = 5;
            lblStatuses.Text = "Statuses";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDatePublished.Location = new Point(489, 119);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(189, 27);
            txtDatePublished.TabIndex = 8;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDateArchived.Location = new Point(489, 235);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(189, 27);
            txtDateArchived.TabIndex = 9;
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtCalories.Location = new Point(489, 467);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(189, 27);
            txtCalories.TabIndex = 11;
            // 
            // txtStatuses
            // 
            txtStatuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtStatuses.Location = new Point(489, 583);
            txtStatuses.Name = "txtStatuses";
            txtStatuses.Size = new Size(189, 27);
            txtStatuses.TabIndex = 12;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Font = new Font("Segoe UI", 12F);
            lblDateDrafted.Location = new Point(12, 348);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(124, 116);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Date Drafted";
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI", 12F);
            lblRecipeName.Location = new Point(11, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(126, 116);
            lblRecipeName.TabIndex = 3;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtDateDrafted.Location = new Point(489, 351);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(189, 27);
            txtDateDrafted.TabIndex = 7;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtRecipeName.Location = new Point(489, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(189, 27);
            txtRecipeName.TabIndex = 10;
            // 
            // FrmRecipeData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 698);
            Controls.Add(tblMain);
            Name = "FrmRecipeData";
            Text = "FrmRecipeData";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblDateDrafted;
        private Label lblDateArchived;
        private Label lblDatePublished;
        private Label lblCalories;
        private Label lblRecipeName;
        private Label lblStatuses;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtStatuses;
    }
}