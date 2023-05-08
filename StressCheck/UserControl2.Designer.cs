namespace StressCheck
{
    partial class UserControl2
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
            this.labelSectionD = new System.Windows.Forms.Label();
            this.labelSectionN = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSectionD
            // 
            this.labelSectionD.AutoSize = true;
            this.labelSectionD.Location = new System.Drawing.Point(104, 151);
            this.labelSectionD.Name = "labelSectionD";
            this.labelSectionD.Size = new System.Drawing.Size(96, 13);
            this.labelSectionD.TabIndex = 10;
            this.labelSectionD.Text = "セクションの説明文";
            this.labelSectionD.Click += new System.EventHandler(this.labelSectionD_Click);
            // 
            // labelSectionN
            // 
            this.labelSectionN.AutoSize = true;
            this.labelSectionN.Location = new System.Drawing.Point(104, 102);
            this.labelSectionN.Name = "labelSectionN";
            this.labelSectionN.Size = new System.Drawing.Size(62, 13);
            this.labelSectionN.TabIndex = 9;
            this.labelSectionN.Text = "セクション名";
            this.labelSectionN.Click += new System.EventHandler(this.labelSectionD_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(142, 242);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(88, 32);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "次へ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSectionD);
            this.Controls.Add(this.labelSectionN);
            this.Controls.Add(this.buttonNext);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(485, 376);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSectionD;
        private System.Windows.Forms.Label labelSectionN;
        private System.Windows.Forms.Button buttonNext;
    }
}
