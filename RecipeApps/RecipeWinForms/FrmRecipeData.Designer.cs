namespace RecipeWinForms
{
    partial class frmRecipeData
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
            lblUser = new Label();
            lstUserName = new ComboBox();
            tblDates = new TableLayoutPanel();
            lblDrafted = new Label();
            lblArchived = new Label();
            lblPublished = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtDateDrafted = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            lblStatuses = new Label();
            tbMain = new TabControl();
            tbIngredients = new TabPage();
            gIngredients = new DataGridView();
            pIngredients = new Panel();
            btnIngredientsSave = new Button();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            pSteps = new Panel();
            btnStepsSave = new Button();
            gSteps = new DataGridView();
            lblCuisine = new Label();
            lblRecipeName = new Label();
            lstCuisineType = new ComboBox();
            txtRecipeName = new TextBox();
            lblCurrentStatus = new Label();
            lblCalories = new Label();
            txtStatuses = new TextBox();
            txtCalories = new TextBox();
            btnChangeStatus = new Button();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            tblButtons.SuspendLayout();
            tbMain.SuspendLayout();
            tbIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            pIngredients.SuspendLayout();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            pSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.GhostWhite;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.07547F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.92453F));
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(tblDates, 1, 7);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(lblStatuses, 0, 7);
            tblMain.Controls.Add(tbMain, 0, 8);
            tblMain.Controls.Add(lblCuisine, 0, 3);
            tblMain.Controls.Add(lblRecipeName, 0, 1);
            tblMain.Controls.Add(lstCuisineType, 1, 3);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblCurrentStatus, 0, 6);
            tblMain.Controls.Add(lblCalories, 0, 4);
            tblMain.Controls.Add(txtStatuses, 1, 6);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(btnChangeStatus, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.917308F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.67479324F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.67479324F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.67479324F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.67479324F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.67479372F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.92670155F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.387435F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3128853F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
            tblMain.Size = new Size(1203, 896);
            tblMain.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(263, 120);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 50);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstUserName.BackColor = Color.Snow;
            lstUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(581, 123);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(190, 36);
            lstUserName.TabIndex = 1;
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 3;
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblDates.Controls.Add(lblDrafted, 0, 0);
            tblDates.Controls.Add(lblArchived, 2, 0);
            tblDates.Controls.Add(lblPublished, 1, 0);
            tblDates.Controls.Add(txtDatePublished, 1, 1);
            tblDates.Controls.Add(txtDateArchived, 2, 1);
            tblDates.Controls.Add(txtDateDrafted, 0, 1);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(581, 358);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle());
            tblDates.RowStyles.Add(new RowStyle());
            tblDates.Size = new Size(619, 96);
            tblDates.TabIndex = 5;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Font = new Font("Segoe UI", 9F);
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(200, 20);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Font = new Font("Segoe UI", 9F);
            lblArchived.Location = new Point(415, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(201, 20);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Font = new Font("Segoe UI", 9F);
            lblPublished.Location = new Point(209, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(200, 20);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Location = new Point(209, 23);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(125, 30);
            txtDatePublished.TabIndex = 1;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Location = new Point(415, 23);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(125, 30);
            txtDateArchived.TabIndex = 2;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Location = new Point(3, 23);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(125, 30);
            txtDateDrafted.TabIndex = 0;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 61.53846F));
            tblButtons.Size = new Size(572, 64);
            tblButtons.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(289, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 58);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = SystemColors.InfoText;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.LightCyan;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(280, 58);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblStatuses
            // 
            lblStatuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblStatuses.AutoSize = true;
            lblStatuses.Font = new Font("Segoe UI", 12F);
            lblStatuses.Location = new Point(220, 355);
            lblStatuses.Name = "lblStatuses";
            lblStatuses.Size = new Size(137, 102);
            lblStatuses.TabIndex = 5;
            lblStatuses.Text = "Statuses Dates";
            lblStatuses.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbMain
            // 
            tblMain.SetColumnSpan(tbMain, 2);
            tbMain.Controls.Add(tbIngredients);
            tbMain.Controls.Add(tbSteps);
            tbMain.Dock = DockStyle.Fill;
            tbMain.Location = new Point(3, 460);
            tbMain.Name = "tbMain";
            tbMain.SelectedIndex = 0;
            tbMain.Size = new Size(1197, 433);
            tbMain.TabIndex = 6;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(gIngredients);
            tbIngredients.Controls.Add(pIngredients);
            tbIngredients.Location = new Point(4, 32);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(1189, 397);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.BackgroundColor = Color.GhostWhite;
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 114);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(1183, 280);
            gIngredients.TabIndex = 0;
            // 
            // pIngredients
            // 
            pIngredients.BackColor = Color.GhostWhite;
            pIngredients.Controls.Add(btnIngredientsSave);
            pIngredients.Dock = DockStyle.Top;
            pIngredients.Location = new Point(3, 3);
            pIngredients.Name = "pIngredients";
            pIngredients.Size = new Size(1183, 111);
            pIngredients.TabIndex = 2;
            // 
            // btnIngredientsSave
            // 
            btnIngredientsSave.AutoSize = true;
            btnIngredientsSave.CausesValidation = false;
            btnIngredientsSave.Dock = DockStyle.Left;
            btnIngredientsSave.Location = new Point(0, 0);
            btnIngredientsSave.Name = "btnIngredientsSave";
            btnIngredientsSave.Size = new Size(125, 111);
            btnIngredientsSave.TabIndex = 0;
            btnIngredientsSave.Text = "Save";
            btnIngredientsSave.UseVisualStyleBackColor = true;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 29);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(1189, 400);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.BackColor = Color.GhostWhite;
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblSteps.Controls.Add(pSteps, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 19.69309F));
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 80.30691F));
            tblSteps.Size = new Size(1183, 394);
            tblSteps.TabIndex = 0;
            // 
            // pSteps
            // 
            pSteps.BackColor = Color.GhostWhite;
            pSteps.Controls.Add(btnStepsSave);
            pSteps.Dock = DockStyle.Fill;
            pSteps.Location = new Point(3, 3);
            pSteps.Name = "pSteps";
            pSteps.Size = new Size(1177, 71);
            pSteps.TabIndex = 1;
            // 
            // btnStepsSave
            // 
            btnStepsSave.Dock = DockStyle.Left;
            btnStepsSave.Location = new Point(0, 0);
            btnStepsSave.Name = "btnStepsSave";
            btnStepsSave.Size = new Size(123, 71);
            btnStepsSave.TabIndex = 2;
            btnStepsSave.Text = "Save";
            btnStepsSave.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.BackgroundColor = Color.GhostWhite;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 80);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.Size = new Size(1177, 311);
            gSteps.TabIndex = 0;
            // 
            // lblCuisine
            // 
            lblCuisine.Anchor = AnchorStyles.Top;
            lblCuisine.AutoSize = true;
            lblCuisine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuisine.Location = new Point(252, 170);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(74, 28);
            lblCuisine.TabIndex = 2;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI", 12F);
            lblRecipeName.Location = new Point(226, 70);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(126, 50);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstCuisineType
            // 
            lstCuisineType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstCuisineType.BackColor = Color.Snow;
            lstCuisineType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(581, 173);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(190, 36);
            lstCuisineType.TabIndex = 2;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtRecipeName.BackColor = Color.Snow;
            txtRecipeName.Location = new Point(581, 73);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.ScrollBars = ScrollBars.Both;
            txtRecipeName.Size = new Size(212, 30);
            txtRecipeName.TabIndex = 0;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 12F);
            lblCurrentStatus.Location = new Point(221, 320);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(135, 35);
            lblCurrentStatus.TabIndex = 4;
            lblCurrentStatus.Text = "Current Status";
            lblCurrentStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 12F);
            lblCalories.Location = new Point(248, 220);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(81, 50);
            lblCalories.TabIndex = 3;
            lblCalories.Text = "Calories";
            lblCalories.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtStatuses
            // 
            txtStatuses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtStatuses.Location = new Point(581, 323);
            txtStatuses.Name = "txtStatuses";
            txtStatuses.ReadOnly = true;
            txtStatuses.Size = new Size(212, 30);
            txtStatuses.TabIndex = 4;
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCalories.BackColor = Color.Snow;
            txtCalories.Location = new Point(581, 223);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(212, 30);
            txtCalories.TabIndex = 3;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnChangeStatus.BackColor = Color.GhostWhite;
            btnChangeStatus.Location = new Point(823, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(134, 64);
            btnChangeStatus.TabIndex = 9;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // frmRecipeData
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 896);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmRecipeData";
            Text = "Recipe Data";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tbMain.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            pIngredients.ResumeLayout(false);
            pIngredients.PerformLayout();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            pSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblDateDrafted;
        private Label lblDateArchived;
        private Label lblDatePublished;
        private Label lblRecipeName;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtDateDrafted;
        private TextBox txtRecipeName;
        private Label lblUser;
        private Label lblCuisine;
        private ComboBox lstCuisineType;
        private ComboBox lstUserName;
        private TableLayoutPanel tblButtons;
        private Button btnDelete;
        private Button btnSave;
        private Label lblCalories;
        private TextBox txtCalories;
        private Button btnChangeStatus;
        private TabControl tbMain;
        private TabPage tbIngredients;
        private DataGridView gIngredients;
        private Panel pIngredients;
        private Button btnIngredientsSave;
        private Label lblStatuses;
        private Label lblCurrentStatus;
        private TextBox txtStatuses;
        private TableLayoutPanel tblDates;
        private Label lblDrafted;
        private Label lblArchived;
        private Label lblPublished;
        private TabPage tbSteps;
        private Panel pSteps;
        private Button btnStepsSave;
        private DataGridView gSteps;
        private TableLayoutPanel tblSteps;
    }
}