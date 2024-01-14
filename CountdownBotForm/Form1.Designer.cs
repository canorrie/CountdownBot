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
            this.listViewMoreWords = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxWordEntry
            // 
            this.textboxWordEntry.Location = new System.Drawing.Point(61, 76);
            this.textboxWordEntry.Name = "textboxWordEntry";
            this.textboxWordEntry.Size = new System.Drawing.Size(143, 22);
            this.textboxWordEntry.TabIndex = 0;
            this.textboxWordEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLettersAvailable
            // 
            this.lblLettersAvailable.AutoSize = true;
            this.lblLettersAvailable.Location = new System.Drawing.Point(78, 57);
            this.lblLettersAvailable.Name = "lblLettersAvailable";
            this.lblLettersAvailable.Size = new System.Drawing.Size(107, 16);
            this.lblLettersAvailable.TabIndex = 1;
            this.lblLettersAvailable.Text = "Letters Available";
            // 
            // lblLongestWordText
            // 
            this.lblLongestWordText.AutoSize = true;
            this.lblLongestWordText.Location = new System.Drawing.Point(87, 148);
            this.lblLongestWordText.Name = "lblLongestWordText";
            this.lblLongestWordText.Size = new System.Drawing.Size(94, 16);
            this.lblLongestWordText.TabIndex = 3;
            this.lblLongestWordText.Text = "Longest Word:";
            // 
            // btnGuessWord
            // 
            this.btnGuessWord.Location = new System.Drawing.Point(61, 111);
            this.btnGuessWord.Name = "btnGuessWord";
            this.btnGuessWord.Size = new System.Drawing.Size(143, 28);
            this.btnGuessWord.TabIndex = 4;
            this.btnGuessWord.Text = "Guess Word!";
            this.btnGuessWord.UseVisualStyleBackColor = true;
            this.btnGuessWord.Click += new System.EventHandler(this.btnGuessWord_Click);
            // 
            // textboxLongestWordResult
            // 
            this.textboxLongestWordResult.Location = new System.Drawing.Point(61, 167);
            this.textboxLongestWordResult.Name = "textboxLongestWordResult";
            this.textboxLongestWordResult.ReadOnly = true;
            this.textboxLongestWordResult.Size = new System.Drawing.Size(143, 22);
            this.textboxLongestWordResult.TabIndex = 5;
            this.textboxLongestWordResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewMoreWords
            // 
            this.listViewMoreWords.HideSelection = false;
            this.listViewMoreWords.Location = new System.Drawing.Point(12, 230);
            this.listViewMoreWords.Name = "listViewMoreWords";
            this.listViewMoreWords.Size = new System.Drawing.Size(246, 252);
            this.listViewMoreWords.TabIndex = 7;
            this.listViewMoreWords.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number stuff goes here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMoreWords);
            this.Controls.Add(this.textboxLongestWordResult);
            this.Controls.Add(this.btnGuessWord);
            this.Controls.Add(this.lblLongestWordText);
            this.Controls.Add(this.lblLettersAvailable);
            this.Controls.Add(this.textboxWordEntry);
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
        private System.Windows.Forms.ListView listViewMoreWords;
        private System.Windows.Forms.Label label1;
    }
}

