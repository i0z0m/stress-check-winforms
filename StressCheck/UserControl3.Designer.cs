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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChoice4
            // 
            this.buttonChoice4.Location = new System.Drawing.Point(340, 221);
            this.buttonChoice4.Name = "buttonChoice4";
            this.buttonChoice4.Size = new System.Drawing.Size(67, 44);
            this.buttonChoice4.TabIndex = 20;
            this.buttonChoice4.Text = "選択肢４";
            this.buttonChoice4.UseVisualStyleBackColor = true;
            this.buttonChoice4.Click += new System.EventHandler(this.buttonChoice4_Click);
            // 
            // buttonChoice3
            // 
            this.buttonChoice3.Location = new System.Drawing.Point(266, 221);
            this.buttonChoice3.Name = "buttonChoice3";
            this.buttonChoice3.Size = new System.Drawing.Size(66, 44);
            this.buttonChoice3.TabIndex = 19;
            this.buttonChoice3.Text = "選択肢３";
            this.buttonChoice3.UseVisualStyleBackColor = true;
            this.buttonChoice3.Click += new System.EventHandler(this.buttonChoice3_Click);
            // 
            // buttonChoice2
            // 
            this.buttonChoice2.Location = new System.Drawing.Point(196, 221);
            this.buttonChoice2.Name = "buttonChoice2";
            this.buttonChoice2.Size = new System.Drawing.Size(64, 44);
            this.buttonChoice2.TabIndex = 18;
            this.buttonChoice2.Text = "選択肢２";
            this.buttonChoice2.UseVisualStyleBackColor = true;
            this.buttonChoice2.Click += new System.EventHandler(this.buttonChoice2_Click);
            // 
            // buttonChoice1
            // 
            this.buttonChoice1.Location = new System.Drawing.Point(121, 221);
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
            this.labelQuestion.Location = new System.Drawing.Point(193, 131);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(43, 13);
            this.labelQuestion.TabIndex = 21;
            this.labelQuestion.Text = "問題文";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(118, 55);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(96, 13);
            this.labelSection.TabIndex = 22;
            this.labelSection.Text = "現在のセクション名";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(300, 55);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(55, 13);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "問題番号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "タイトル画面に戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "ひとつ前の画面";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(395, 55);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(96, 13);
            this.labelCount.TabIndex = 27;
            this.labelCount.Text = "セクションの問題数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "/";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonChoice4);
            this.Controls.Add(this.buttonChoice3);
            this.Controls.Add(this.buttonChoice2);
            this.Controls.Add(this.buttonChoice1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(544, 430);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label1;
    }
}
