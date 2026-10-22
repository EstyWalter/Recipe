namespace RecipeWinForms
{
    partial class frmCloneRecipe
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
            btnClone = new Button();
            lstRecipeName = new ComboBox();
            SuspendLayout();
            // 
            // btnClone
            // 
            btnClone.Location = new Point(12, 89);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(722, 71);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // lstRecipeName
            // 
            lstRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(12, 38);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(722, 28);
            lstRecipeName.TabIndex = 0;
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(lstRecipeName);
            Controls.Add(btnClone);
            Name = "frmCloneRecipe";
            Text = "CloneRecipe";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClone;
        private ComboBox lstRecipeName;
    }
}