using System;
using System.Windows.Forms;

namespace CountdownBotForm
{
    public partial class Form1 : Form
    {
        WordGuesser wordGuesser = new WordGuesser();
        NumberGuesser numberGuesser = new NumberGuesser();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuessWord_Click(object sender, EventArgs e)
        {
            string word = wordGuesser.GuessWords(textboxWordEntry.Text);
            textboxLongestWordResult.Text = String.Format(word, 0);
        }

        private void btnFindNumbers_Click(object sender, EventArgs e)
        {
            textboxNumberResult.Text = ("hell yeah brother");
        }
    }
}
