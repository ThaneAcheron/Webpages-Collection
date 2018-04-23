namespace CTIQuestionOneB
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
            this.FeaturesLstBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.control1 = new CTIQuestionOneB.Control();
            this.SuspendLayout();
            // 
            // FeaturesLstBox
            // 
            this.FeaturesLstBox.FormattingEnabled = true;
            this.FeaturesLstBox.Items.AddRange(new object[] {
            "Air-Con ",
            "Power steering "});
            this.FeaturesLstBox.Location = new System.Drawing.Point(105, 52);
            this.FeaturesLstBox.Name = "FeaturesLstBox";
            this.FeaturesLstBox.Size = new System.Drawing.Size(120, 30);
            this.FeaturesLstBox.TabIndex = 1;
            this.FeaturesLstBox.SelectedIndexChanged += new System.EventHandler(this.FeaturesLstBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(37, 128);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(277, 171);
            this.control1.TabIndex = 0;
            this.control1.Load += new System.EventHandler(this.control1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FeaturesLstBox);
            this.Controls.Add(this.control1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FeaturesLstBox;
        private System.Windows.Forms.Label label1;
        public Control control1;
    }
}

