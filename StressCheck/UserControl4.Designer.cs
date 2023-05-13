namespace StressCheck
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStressDescription = new System.Windows.Forms.Label();
            this.labelStressLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStressDescription
            // 
            this.labelStressDescription.AutoSize = true;
            this.labelStressDescription.Location = new System.Drawing.Point(53, 105);
            this.labelStressDescription.Name = "labelStressDescription";
            this.labelStressDescription.Size = new System.Drawing.Size(89, 13);
            this.labelStressDescription.TabIndex = 6;
            this.labelStressDescription.Text = "診断結果の記述";
            // 
            // labelStressLevel
            // 
            this.labelStressLevel.AutoSize = true;
            this.labelStressLevel.Location = new System.Drawing.Point(53, 59);
            this.labelStressLevel.Name = "labelStressLevel";
            this.labelStressLevel.Size = new System.Drawing.Size(89, 13);
            this.labelStressLevel.TabIndex = 5;
            this.labelStressLevel.Text = "診断結果の文章";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelStressDescription);
            this.Controls.Add(this.labelStressLevel);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(425, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStressDescription;
        private System.Windows.Forms.Label labelStressLevel;
    }
}
