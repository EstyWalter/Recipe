namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            btnCreateCookbook = new Button();
            lstUserName = new ComboBox();
            SuspendLayout();
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Location = new Point(309, 13);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(219, 66);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(33, 33);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(217, 28);
            lstUserName.TabIndex = 0;
            // 
            // frmAutoCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateCookbook);
            Controls.Add(lstUserName);
            Name = "frmAutoCreateCookbook";
            Text = "Auto-Create Cookbook";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateCookbook;
        private ComboBox lstUserName;
    }
}