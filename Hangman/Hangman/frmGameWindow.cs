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
    public partial class frmGameWindow : Form
    {
        private Hangman game;
        public frmGameWindow(string word)
        {
            InitializeComponent();
            game = new Hangman(word);
            lblLetters.Text = game.ReturnGuessed();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (game.GuessWord(txtInput.Text))
            {
                string text;
                text = txtInput.Text.ToUpper();
                game.Guessed = null;
                game.Guessed = new char[text.Length];
                for (int i = 0; i < game.Guessed.Length; i++ )
                    game.Guessed[i] = text[i];

                lblLetters.Text = game.ReturnGuessed();
                lblGuessed.Text = "You have won!  The word was:";

                txtInput.Text = "";
                txtInput.Enabled = false;
                btnWord.Enabled = false;
                btnLetter.Enabled = false;
            }
            else
            {
                lblBodyStatus.Text = game.HangBodyPart();
                lblBodyStatus.Visible = true;
                lblBodyParts.Text = Convert.ToString(game.Body);
                txtInput.Text = "";
                if (game.Body == 6)
                {
                    lblGuessed.Text = "You have lost.  The word was: ";
                    for (int i = 0; i < game.Guessed.Length; i++)
                        game.Guessed[i] = game.Word[i];
                    lblLetters.Text = game.ReturnGuessed();
                    btnLetter.Enabled = false;
                    btnWord.Enabled = false;
                    txtInput.Enabled = false;
                }
            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            string g = game.GuessLetter(txtInput.Text);
            if (g.Length != game.Guessed.Length * 2)
            {
                txtInput.Text = "";
                lblBodyStatus.Text = g;
                lblBodyStatus.Visible = true;
                lblBodyParts.Text = Convert.ToString(game.Body);
                if (game.Body == 6)
                {
                    lblGuessed.Text = "You have lost.  The word was: ";
                    for (int i = 0; i < game.Guessed.Length; i++)
                        game.Guessed[i] = game.Word[i];
                    lblLetters.Text = game.ReturnGuessed();
                    btnLetter.Enabled = false;
                    btnWord.Enabled = false;
                    txtInput.Enabled = false;
                }
                
            }
            else
            {
                lblBodyStatus.Visible = false;
                txtInput.Text = "";
                lblLetters.Text = game.ReturnGuessed();
                if (game.CheckWord())
                {
                    lblGuessed.Text = "You have won!  The word was:";
                    txtInput.Text = "";
                    txtInput.Enabled = false;
                    btnWord.Enabled = false;
                    btnLetter.Enabled = false;
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
