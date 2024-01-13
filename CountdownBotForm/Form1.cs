using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CountdownBotForm
{
    public partial class Form1 : Form
    {
        WordGuesser guesser = new WordGuesser();

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnGuessWord_Click(object sender, EventArgs e)
        {
            string word = guesser.GuessWord(textboxWordEntry.Text);
            textboxLongestWordResult.Text = String.Format(word, 0);
        }
    }
}
