namespace Aufgabe103
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
            this.randomNumbers = new System.Windows.Forms.ListBox();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // randomNumbers
            // 
            this.randomNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randomNumbers.FormattingEnabled = true;
            this.randomNumbers.Location = new System.Drawing.Point(13, 12);
            this.randomNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.randomNumbers.Name = "randomNumbers";
            this.randomNumbers.Size = new System.Drawing.Size(259, 212);
            this.randomNumbers.TabIndex = 1;
            this.randomNumbers.SelectedIndexChanged += new System.EventHandler(this.randomNumbers_SelectedIndexChanged);
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Location = new System.Drawing.Point(13, 230);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(259, 20);
            this.output.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.output);
            this.Controls.Add(this.randomNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox randomNumbers;
        private System.Windows.Forms.TextBox output;
    }
}

