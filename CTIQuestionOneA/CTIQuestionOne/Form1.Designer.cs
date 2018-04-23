namespace CTIQuestionOne
{
    partial class Form1
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
            this.FeaturesTxtbL = new System.Windows.Forms.CheckedListBox();
            this.FeatureTxtb = new System.Windows.Forms.TextBox();
            this.AddFeatureBtn = new System.Windows.Forms.Button();
            this.filenameLble = new System.Windows.Forms.Label();
            this.WriteInfoBtn = new System.Windows.Forms.Button();
            this.FileNameTxtb = new System.Windows.Forms.TextBox();
            this.MessageLble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FeaturesTxtbL
            // 
            this.FeaturesTxtbL.FormattingEnabled = true;
            this.FeaturesTxtbL.Location = new System.Drawing.Point(12, 48);
            this.FeaturesTxtbL.Name = "FeaturesTxtbL";
            this.FeaturesTxtbL.Size = new System.Drawing.Size(126, 229);
            this.FeaturesTxtbL.TabIndex = 0;
            // 
            // FeatureTxtb
            // 
            this.FeatureTxtb.Location = new System.Drawing.Point(225, 48);
            this.FeatureTxtb.Name = "FeatureTxtb";
            this.FeatureTxtb.Size = new System.Drawing.Size(100, 20);
            this.FeatureTxtb.TabIndex = 1;
            // 
            // AddFeatureBtn
            // 
            this.AddFeatureBtn.Location = new System.Drawing.Point(241, 74);
            this.AddFeatureBtn.Name = "AddFeatureBtn";
            this.AddFeatureBtn.Size = new System.Drawing.Size(75, 23);
            this.AddFeatureBtn.TabIndex = 2;
            this.AddFeatureBtn.Text = "Add Feature";
            this.AddFeatureBtn.UseVisualStyleBackColor = true;
            this.AddFeatureBtn.Click += new System.EventHandler(this.AddFeatureBtn_Click);
            // 
            // filenameLble
            // 
            this.filenameLble.AutoSize = true;
            this.filenameLble.Location = new System.Drawing.Point(234, 160);
            this.filenameLble.Name = "filenameLble";
            this.filenameLble.Size = new System.Drawing.Size(83, 13);
            this.filenameLble.TabIndex = 3;
            this.filenameLble.Text = "Enter a filename";
            // 
            // WriteInfoBtn
            // 
            this.WriteInfoBtn.Location = new System.Drawing.Point(237, 202);
            this.WriteInfoBtn.Name = "WriteInfoBtn";
            this.WriteInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.WriteInfoBtn.TabIndex = 4;
            this.WriteInfoBtn.Text = "Write Info";
            this.WriteInfoBtn.UseVisualStyleBackColor = true;
            this.WriteInfoBtn.Click += new System.EventHandler(this.WriteInfoBtn_Click);
            // 
            // FileNameTxtb
            // 
            this.FileNameTxtb.Location = new System.Drawing.Point(225, 176);
            this.FileNameTxtb.Name = "FileNameTxtb";
            this.FileNameTxtb.Size = new System.Drawing.Size(100, 20);
            this.FileNameTxtb.TabIndex = 5;
            // 
            // MessageLble
            // 
            this.MessageLble.AutoSize = true;
            this.MessageLble.Location = new System.Drawing.Point(12, 305);
            this.MessageLble.Name = "MessageLble";
            this.MessageLble.Size = new System.Drawing.Size(50, 13);
            this.MessageLble.TabIndex = 6;
            this.MessageLble.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 327);
            this.Controls.Add(this.MessageLble);
            this.Controls.Add(this.FileNameTxtb);
            this.Controls.Add(this.WriteInfoBtn);
            this.Controls.Add(this.filenameLble);
            this.Controls.Add(this.AddFeatureBtn);
            this.Controls.Add(this.FeatureTxtb);
            this.Controls.Add(this.FeaturesTxtbL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox FeaturesTxtbL;
        private System.Windows.Forms.TextBox FeatureTxtb;
        private System.Windows.Forms.Button AddFeatureBtn;
        private System.Windows.Forms.Label filenameLble;
        private System.Windows.Forms.Button WriteInfoBtn;
        private System.Windows.Forms.TextBox FileNameTxtb;
        private System.Windows.Forms.Label MessageLble;
    }
}

