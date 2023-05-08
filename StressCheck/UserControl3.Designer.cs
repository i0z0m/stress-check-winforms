namespace StressCheck
{
    partial class UserControl3
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
            this.buttonChoice4 = new System.Windows.Forms.Button();
            this.buttonChoice3 = new System.Windows.Forms.Button();
            this.buttonChoice2 = new System.Windows.Forms.Button();
            this.buttonChoice1 = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChoice4
            // 
            this.buttonChoice4.Location = new System.Drawing.Point(328, 138);
            this.buttonChoice4.Name = "buttonChoice4";
            this.buttonChoice4.Size = new System.Drawing.Size(67, 44);
            this.buttonChoice4.TabIndex = 20;
            this.buttonChoice4.Text = "選択肢４";
            this.buttonChoice4.UseVisualStyleBackColor = true;
            this.buttonChoice4.Click += new System.EventHandler(this.buttonChoice4_Click);
            // 
            // buttonChoice3
            // 
            this.buttonChoice3.Location = new System.Drawing.Point(256, 138);
            this.buttonChoice3.Name = "buttonChoice3";
            this.buttonChoice3.Size = new System.Drawing.Size(66, 44);
            this.buttonChoice3.TabIndex = 19;
            this.buttonChoice3.Text = "選択肢３";
            this.buttonChoice3.UseVisualStyleBackColor = true;
            this.buttonChoice3.Click += new System.EventHandler(this.buttonChoice3_Click);
            // 
            // buttonChoice2
            // 
            this.buttonChoice2.Location = new System.Drawing.Point(186, 138);
            this.buttonChoice2.Name = "buttonChoice2";
            this.buttonChoice2.Size = new System.Drawing.Size(64, 44);
            this.buttonChoice2.TabIndex = 18;
            this.buttonChoice2.Text = "選択肢２";
            this.buttonChoice2.UseVisualStyleBackColor = true;
            this.buttonChoice2.Click += new System.EventHandler(this.buttonChoice2_Click);
            // 
            // buttonChoice1
            // 
            this.buttonChoice1.Location = new System.Drawing.Point(111, 138);
            this.buttonChoice1.Name = "buttonChoice1";
            this.buttonChoice1.Size = new System.Drawing.Size(69, 44);
            this.buttonChoice1.TabIndex = 17;
            this.buttonChoice1.Text = "選択肢１";
            this.buttonChoice1.UseVisualStyleBackColor = true;
            this.buttonChoice1.Click += new System.EventHandler(this.buttonChoice1_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(207, 59);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(43, 13);
            this.labelQuestion.TabIndex = 21;
            this.labelQuestion.Text = "問題文";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(111, 59);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(50, 13);
            this.labelSection.TabIndex = 22;
            this.labelSection.Text = "セクション";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(167, 59);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 13);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "番号";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonChoice4);
            this.Controls.Add(this.buttonChoice3);
            this.Controls.Add(this.buttonChoice2);
            this.Controls.Add(this.buttonChoice1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(704, 430);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChoice4;
        private System.Windows.Forms.Button buttonChoice3;
        private System.Windows.Forms.Button buttonChoice2;
        private System.Windows.Forms.Button buttonChoice1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelID;
    }
}
