namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            gData = new DataGridView();
            pOptionButtons = new Panel();
            optCourse = new RadioButton();
            optMeasurements = new RadioButton();
            optIngredient = new RadioButton();
            optCuisine = new RadioButton();
            optUsers = new RadioButton();
            btnSave = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            pOptionButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5502548F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.18739F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.262351F));
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(pOptionButtons, 0, 0);
            tblMain.Controls.Add(btnSave, 2, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80.7460861F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.303249F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8303251F));
            tblMain.Size = new Size(1174, 831);
            tblMain.TabIndex = 0;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(256, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(818, 665);
            gData.TabIndex = 1;
            // 
            // pOptionButtons
            // 
            pOptionButtons.Controls.Add(optCourse);
            pOptionButtons.Controls.Add(optMeasurements);
            pOptionButtons.Controls.Add(optIngredient);
            pOptionButtons.Controls.Add(optCuisine);
            pOptionButtons.Controls.Add(optUsers);
            pOptionButtons.Dock = DockStyle.Fill;
            pOptionButtons.Location = new Point(3, 3);
            pOptionButtons.Name = "pOptionButtons";
            tblMain.SetRowSpan(pOptionButtons, 2);
            pOptionButtons.Size = new Size(247, 734);
            pOptionButtons.TabIndex = 0;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Location = new Point(24, 303);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(75, 24);
            optCourse.TabIndex = 4;
            optCourse.Text = "Course";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.AutoSize = true;
            optMeasurements.Location = new Point(24, 248);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(112, 24);
            optMeasurements.TabIndex = 3;
            optMeasurements.Text = "Measurement.";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(24, 182);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(98, 24);
            optIngredient.TabIndex = 2;
            optIngredient.Text = "Ingredient";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.AutoSize = true;
            optCuisine.Location = new Point(24, 118);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(77, 24);
            optCuisine.TabIndex = 1;
            optCuisine.Text = "Cuisine";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Location = new Point(24, 49);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(65, 24);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Top;
            btnSave.Location = new Point(1080, 743);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 62);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 831);
            Controls.Add(tblMain);
            Name = "frmDataMaintenance";
            Text = "DataMaintenace";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            pOptionButtons.ResumeLayout(false);
            pOptionButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Panel pOptionButtons;
        private Button btnSave;
        private RadioButton optCourse;
        private RadioButton optMeasurements;
        private RadioButton optIngredient;
        private RadioButton optCuisine;
        private RadioButton optUsers;
        private DataGridView gData;
    }
}