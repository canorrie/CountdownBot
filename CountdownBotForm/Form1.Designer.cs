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
            this.textboxWordEntry = new System.Windows.Forms.TextBox();
            this.lblLettersAvailable = new System.Windows.Forms.Label();
            this.lblLongestWordText = new System.Windows.Forms.Label();
            this.btnGuessWord = new System.Windows.Forms.Button();
            this.textboxLongestWordResult = new System.Windows.Forms.TextBox();
            this.textboxNumbersInput = new System.Windows.Forms.TextBox();
            this.btnFindNumbers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxNumberResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxWordEntry
            // 
            this.textboxWordEntry.Location = new System.Drawing.Point(46, 62);
            this.textboxWordEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxWordEntry.Name = "textboxWordEntry";
            this.textboxWordEntry.Size = new System.Drawing.Size(108, 20);
            this.textboxWordEntry.TabIndex = 0;
            this.textboxWordEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLettersAvailable
            // 
            this.lblLettersAvailable.AutoSize = true;
            this.lblLettersAvailable.Location = new System.Drawing.Point(58, 46);
            this.lblLettersAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLettersAvailable.Name = "lblLettersAvailable";
            this.lblLettersAvailable.Size = new System.Drawing.Size(85, 13);
            this.lblLettersAvailable.TabIndex = 1;
            this.lblLettersAvailable.Text = "Letters Available";
            // 
            // lblLongestWordText
            // 
            this.lblLongestWordText.AutoSize = true;
            this.lblLongestWordText.Location = new System.Drawing.Point(65, 120);
            this.lblLongestWordText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLongestWordText.Name = "lblLongestWordText";
            this.lblLongestWordText.Size = new System.Drawing.Size(77, 13);
            this.lblLongestWordText.TabIndex = 3;
            this.lblLongestWordText.Text = "Longest Word:";
            // 
            // btnGuessWord
            // 
            this.btnGuessWord.Location = new System.Drawing.Point(46, 90);
            this.btnGuessWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuessWord.Name = "btnGuessWord";
            this.btnGuessWord.Size = new System.Drawing.Size(107, 23);
            this.btnGuessWord.TabIndex = 4;
            this.btnGuessWord.Text = "Guess Word!";
            this.btnGuessWord.UseVisualStyleBackColor = true;
            this.btnGuessWord.Click += new System.EventHandler(this.btnGuessWord_Click);
            // 
            // textboxLongestWordResult
            // 
            this.textboxLongestWordResult.Location = new System.Drawing.Point(46, 136);
            this.textboxLongestWordResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxLongestWordResult.Name = "textboxLongestWordResult";
            this.textboxLongestWordResult.ReadOnly = true;
            this.textboxLongestWordResult.Size = new System.Drawing.Size(108, 20);
            this.textboxLongestWordResult.TabIndex = 5;
            this.textboxLongestWordResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxNumbersInput
            // 
            this.textboxNumbersInput.Location = new System.Drawing.Point(245, 62);
            this.textboxNumbersInput.Name = "textboxNumbersInput";
            this.textboxNumbersInput.Size = new System.Drawing.Size(176, 20);
            this.textboxNumbersInput.TabIndex = 6;
            // 
            // btnFindNumbers
            // 
            this.btnFindNumbers.Location = new System.Drawing.Point(278, 90);
            this.btnFindNumbers.Name = "btnFindNumbers";
            this.btnFindNumbers.Size = new System.Drawing.Size(104, 23);
            this.btnFindNumbers.TabIndex = 7;
            this.btnFindNumbers.Text = "Find Numbers!";
            this.btnFindNumbers.UseVisualStyleBackColor = true;
            this.btnFindNumbers.Click += new System.EventHandler(this.btnFindNumbers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numbers (separate by comma)";
            // 
            // textboxNumberResult
            // 
            this.textboxNumberResult.Location = new System.Drawing.Point(245, 135);
            this.textboxNumberResult.Name = "textboxNumberResult";
            this.textboxNumberResult.ReadOnly = true;
            this.textboxNumberResult.Size = new System.Drawing.Size(176, 20);
            this.textboxNumberResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 185);
            this.Controls.Add(this.textboxNumberResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindNumbers);
            this.Controls.Add(this.textboxNumbersInput);
            this.Controls.Add(this.textboxLongestWordResult);
            this.Controls.Add(this.btnGuessWord);
            this.Controls.Add(this.lblLongestWordText);
            this.Controls.Add(this.lblLettersAvailable);
            this.Controls.Add(this.textboxWordEntry);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CountdownBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxWordEntry;
        private System.Windows.Forms.Label lblLettersAvailable;
        private System.Windows.Forms.Label lblLongestWordText;
        private System.Windows.Forms.Button btnGuessWord;
        private System.Windows.Forms.TextBox textboxLongestWordResult;
        private System.Windows.Forms.TextBox textboxNumbersInput;
        private System.Windows.Forms.Button btnFindNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxNumberResult;
    }
}

