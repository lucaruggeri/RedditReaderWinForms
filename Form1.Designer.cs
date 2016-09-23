namespace RedditReaderWinForms
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
            this.txtTitles = new System.Windows.Forms.ListBox();
            this.cmbSubreddits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitles
            // 
            this.txtTitles.FormattingEnabled = true;
            this.txtTitles.Location = new System.Drawing.Point(12, 38);
            this.txtTitles.Name = "txtTitles";
            this.txtTitles.Size = new System.Drawing.Size(651, 511);
            this.txtTitles.TabIndex = 0;
            this.txtTitles.SelectedIndexChanged += new System.EventHandler(this.txtTitles_SelectedIndexChanged);
            // 
            // cmbSubreddits
            // 
            this.cmbSubreddits.FormattingEnabled = true;
            this.cmbSubreddits.Location = new System.Drawing.Point(71, 12);
            this.cmbSubreddits.Name = "cmbSubreddits";
            this.cmbSubreddits.Size = new System.Drawing.Size(121, 21);
            this.cmbSubreddits.TabIndex = 1;
            this.cmbSubreddits.SelectedIndexChanged += new System.EventHandler(this.cmbSubreddits_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subreddit";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(669, 38);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(404, 256);
            this.picPreview.TabIndex = 3;
            this.picPreview.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(669, 300);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(404, 249);
            this.txtDescription.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 562);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubreddits);
            this.Controls.Add(this.txtTitles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox txtTitles;
        private System.Windows.Forms.ComboBox cmbSubreddits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

