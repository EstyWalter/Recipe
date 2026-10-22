namespace RecipeWinForms
{
    partial class frmStatus
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
            tblStatus = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblStatusDates = new Label();
            lblRecipeName = new Label();
            pStatus = new Panel();
            lblStatuses = new Label();
            lblCurrentStatus = new Label();
            tblButtonsDates = new TableLayoutPanel();
            btnArchived = new Button();
            btnDrafted = new Button();
            btnPublished = new Button();
            tblMain.SuspendLayout();
            tblStatus.SuspendLayout();
            pStatus.SuspendLayout();
            tblButtonsDates.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.LightCyan;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(tblStatus, 0, 2);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(pStatus, 0, 1);
            tblMain.Controls.Add(tblButtonsDates, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7777777F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5555553F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 47.11111F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(980, 706);
            tblMain.TabIndex = 0;
            // 
            // tblStatus
            // 
            tblStatus.BackColor = Color.LightCyan;
            tblStatus.ColumnCount = 4;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStatus.Controls.Add(lblDrafted, 1, 0);
            tblStatus.Controls.Add(lblPublished, 2, 0);
            tblStatus.Controls.Add(lblArchived, 3, 0);
            tblStatus.Controls.Add(txtDateDrafted, 1, 1);
            tblStatus.Controls.Add(txtDatePublished, 2, 1);
            tblStatus.Controls.Add(txtDateArchived, 3, 1);
            tblStatus.Controls.Add(lblStatusDates, 0, 1);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(3, 169);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 30.4932728F));
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 69.50673F));
            tblStatus.Size = new Size(974, 201);
            tblStatus.TabIndex = 1;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.BackColor = Color.PeachPuff;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(246, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(237, 61);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.BackColor = Color.MistyRose;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(489, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(237, 61);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.BackColor = Color.SeaShell;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(732, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(239, 61);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.BackColor = Color.PeachPuff;
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(246, 64);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(237, 27);
            txtDateDrafted.TabIndex = 4;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BackColor = Color.MistyRose;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(489, 64);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(237, 27);
            txtDatePublished.TabIndex = 5;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BackColor = Color.SeaShell;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(732, 64);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(239, 27);
            txtDateArchived.TabIndex = 6;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusDates.Location = new Point(121, 61);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 3;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.LightCyan;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(974, 84);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "RecipeName";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pStatus
            // 
            pStatus.Controls.Add(lblStatuses);
            pStatus.Controls.Add(lblCurrentStatus);
            pStatus.Dock = DockStyle.Fill;
            pStatus.Location = new Point(3, 87);
            pStatus.Name = "pStatus";
            pStatus.Size = new Size(974, 76);
            pStatus.TabIndex = 3;
            // 
            // lblStatuses
            // 
            lblStatuses.Dock = DockStyle.Right;
            lblStatuses.Location = new Point(460, 0);
            lblStatuses.Name = "lblStatuses";
            lblStatuses.Size = new Size(514, 76);
            lblStatuses.TabIndex = 1;
            lblStatuses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.BackColor = Color.LightCyan;
            lblCurrentStatus.Dock = DockStyle.Left;
            lblCurrentStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStatus.Location = new Point(0, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(467, 76);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "             Current Status :";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblButtonsDates
            // 
            tblButtonsDates.ColumnCount = 3;
            tblButtonsDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtonsDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtonsDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtonsDates.Controls.Add(btnArchived, 2, 1);
            tblButtonsDates.Controls.Add(btnDrafted, 0, 1);
            tblButtonsDates.Controls.Add(btnPublished, 1, 1);
            tblButtonsDates.Dock = DockStyle.Fill;
            tblButtonsDates.Location = new Point(3, 376);
            tblButtonsDates.Name = "tblButtonsDates";
            tblButtonsDates.RowCount = 3;
            tblButtonsDates.RowStyles.Add(new RowStyle(SizeType.Percent, 25.141243F));
            tblButtonsDates.RowStyles.Add(new RowStyle(SizeType.Percent, 46.0451965F));
            tblButtonsDates.RowStyles.Add(new RowStyle(SizeType.Percent, 29.0960445F));
            tblButtonsDates.Size = new Size(974, 327);
            tblButtonsDates.TabIndex = 2;
            // 
            // btnArchived
            // 
            btnArchived.BackColor = Color.SeaShell;
            btnArchived.Dock = DockStyle.Fill;
            btnArchived.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchived.Location = new Point(651, 84);
            btnArchived.Name = "btnArchived";
            btnArchived.Size = new Size(320, 144);
            btnArchived.TabIndex = 2;
            btnArchived.Text = "Archive";
            btnArchived.UseVisualStyleBackColor = false;
            // 
            // btnDrafted
            // 
            btnDrafted.BackColor = Color.PeachPuff;
            btnDrafted.Dock = DockStyle.Fill;
            btnDrafted.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDrafted.Location = new Point(3, 84);
            btnDrafted.Name = "btnDrafted";
            btnDrafted.Size = new Size(318, 144);
            btnDrafted.TabIndex = 0;
            btnDrafted.Text = "Draft";
            btnDrafted.UseVisualStyleBackColor = false;
            // 
            // btnPublished
            // 
            btnPublished.BackColor = Color.MistyRose;
            btnPublished.Dock = DockStyle.Fill;
            btnPublished.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPublished.Location = new Point(327, 84);
            btnPublished.Name = "btnPublished";
            btnPublished.Size = new Size(318, 144);
            btnPublished.TabIndex = 1;
            btnPublished.Text = "Publish";
            btnPublished.UseVisualStyleBackColor = false;
            // 
            // frmStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 706);
            Controls.Add(tblMain);
            Name = "frmStatus";
            Text = "Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            pStatus.ResumeLayout(false);
            tblButtonsDates.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblStatus;
        private Label lblRecipeName;
        private Label lblCurrentStatus;
        private Panel pStatus;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Button btnArchived;
        private Button btnPublished;
        private Button btnDrafted;
        private TableLayoutPanel tblButtonsDates;
        private Label lblStatuses;
    }
}