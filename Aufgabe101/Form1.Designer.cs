namespace Aufgabe101
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
            this.sample_label = new System.Windows.Forms.Label();
            this.sample_button = new System.Windows.Forms.Button();
            this.sample_listBox = new System.Windows.Forms.ListBox();
            this.sample_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sample_label
            // 
            this.sample_label.AutoSize = true;
            this.sample_label.Location = new System.Drawing.Point(13, 13);
            this.sample_label.Name = "sample_label";
            this.sample_label.Size = new System.Drawing.Size(96, 13);
            this.sample_label.TabIndex = 0;
            this.sample_label.Text = "Some Sample Text";
            // 
            // sample_button
            // 
            this.sample_button.Location = new System.Drawing.Point(12, 29);
            this.sample_button.Name = "sample_button";
            this.sample_button.Size = new System.Drawing.Size(118, 23);
            this.sample_button.TabIndex = 1;
            this.sample_button.Text = "Oh no a Button";
            this.sample_button.UseVisualStyleBackColor = true;
            this.sample_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // sample_listBox
            // 
            this.sample_listBox.FormattingEnabled = true;
            this.sample_listBox.Items.AddRange(new object[] {
            "First Sample Entry",
            "Second Sample Entry",
            "Third Sample Entry",
            "Fourth Sample Entry",
            "Sixth Sample Entry",
            "Seventh Sample Entry",
            "Do you get it ;)"});
            this.sample_listBox.Location = new System.Drawing.Point(136, 13);
            this.sample_listBox.Name = "sample_listBox";
            this.sample_listBox.Size = new System.Drawing.Size(120, 238);
            this.sample_listBox.TabIndex = 2;
            // 
            // sample_textBox
            // 
            this.sample_textBox.Location = new System.Drawing.Point(13, 59);
            this.sample_textBox.Name = "sample_textBox";
            this.sample_textBox.Size = new System.Drawing.Size(117, 20);
            this.sample_textBox.TabIndex = 3;
            this.sample_textBox.Text = "HIHIHIHI";
            this.sample_textBox.TextChanged += new System.EventHandler(this.sample_textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sample_textBox);
            this.Controls.Add(this.sample_listBox);
            this.Controls.Add(this.sample_button);
            this.Controls.Add(this.sample_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sample_label;
        private System.Windows.Forms.Button sample_button;
        private System.Windows.Forms.ListBox sample_listBox;
        private System.Windows.Forms.TextBox sample_textBox;
    }
}

