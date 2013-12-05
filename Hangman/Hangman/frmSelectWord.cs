using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmSelectWord : Form
    {
        public frmSelectWord()
        {
            InitializeComponent();
        }

        private void btnSubmitWord_Click(object sender, EventArgs e)
        {
            frmGameWindow game = new frmGameWindow(txtWord.Text);
            Hide();
            game.ShowDialog();
            Close();
        }
    }
}
