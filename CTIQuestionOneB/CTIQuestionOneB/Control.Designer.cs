namespace CTIQuestionOneB
{
    partial class Control
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
            this.PictureBx = new System.Windows.Forms.PictureBox();
            this.SelectedFeaturedLble = new System.Windows.Forms.Label();
            this.DescriptionTxtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBx
            // 
            this.PictureBx.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PictureBx.Location = new System.Drawing.Point(3, 27);
            this.PictureBx.Name = "PictureBx";
            this.PictureBx.Size = new System.Drawing.Size(106, 83);
            this.PictureBx.TabIndex = 0;
            this.PictureBx.TabStop = false;
            // 
            // SelectedFeaturedLble
            // 
            this.SelectedFeaturedLble.AutoSize = true;
            this.SelectedFeaturedLble.Location = new System.Drawing.Point(120, 10);
            this.SelectedFeaturedLble.Name = "SelectedFeaturedLble";
            this.SelectedFeaturedLble.Size = new System.Drawing.Size(35, 13);
            this.SelectedFeaturedLble.TabIndex = 1;
            this.SelectedFeaturedLble.Text = "label1";
            this.SelectedFeaturedLble.Click += new System.EventHandler(this.label1_Click);
            // 
            // DescriptionTxtb
            // 
            this.DescriptionTxtb.Location = new System.Drawing.Point(168, 27);
            this.DescriptionTxtb.Multiline = true;
            this.DescriptionTxtb.Name = "DescriptionTxtb";
            this.DescriptionTxtb.Size = new System.Drawing.Size(106, 83);
            this.DescriptionTxtb.TabIndex = 2;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DescriptionTxtb);
            this.Controls.Add(this.SelectedFeaturedLble);
            this.Controls.Add(this.PictureBx);
            this.Name = "Control";
            this.Size = new System.Drawing.Size(277, 265);
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBx;
        private System.Windows.Forms.TextBox DescriptionTxtb;
        public System.Windows.Forms.Label SelectedFeaturedLble;
    }
}
