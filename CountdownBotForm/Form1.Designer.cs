namespace CountdownBotForm
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
            this.WordEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LongestWordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WordEntry
            // 
            this.WordEntry.Location = new System.Drawing.Point(61, 76);
            this.WordEntry.Name = "WordEntry";
            this.WordEntry.Size = new System.Drawing.Size(143, 22);
            this.WordEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Letters Available";
            // 
            // LongestWordBox
            // 
            this.LongestWordBox.Location = new System.Drawing.Point(61, 149);
            this.LongestWordBox.Name = "LongestWordBox";
            this.LongestWordBox.ReadOnly = true;
            this.LongestWordBox.Size = new System.Drawing.Size(143, 22);
            this.LongestWordBox.TabIndex = 2;
            this.LongestWordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longest Word";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LongestWordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordEntry);
            this.Name = "Form1";
            this.Text = "CountdownBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WordEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LongestWordBox;
        private System.Windows.Forms.Label label2;
    }
}

