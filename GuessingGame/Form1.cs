using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        Guessing myGame;
        public Form1()
        {
            InitializeComponent();
        }

        private void rndP2_CheckedChanged(object sender, EventArgs e)
        {
            lblP2.Visible = true;
            txtP2.Visible = true;
        }

        private void rndP1_CheckedChanged(object sender, EventArgs e)
        {
            lblP2.Visible = false;
            txtP2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdSubmit.Enabled = true;
            lblGame.Visible = true;
            groupBox1.Enabled = false;

            if (rndP2.Checked)
            {
                myGame = new Guessing(true);
            }
            else
            {
                myGame = new Guessing(false);
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (rndP2.Checked) {
                int temp;
                if (!int.TryParse(txtP1.Text, out temp))
                {
                    MessageBox.Show("You MUST enter only whole numbers when you make your guesses! Come back when you have learned how to play properly :(");
                    this.Close();
                }
                myGame.playerTwoGuess(temp);

                if (myGame.isPlayerHigh())
                    this.BackColor = System.Drawing.Color.LightSalmon;
                else
                    this.BackColor = System.Drawing.Color.LightCyan;
                txtP2.Text = myGame.playerTwoMove();
                if (myGame.whoWon() == 1)
                    MessageBox.Show("Player One wins with " + myGame.getP1Guesses() + " guesses!");
                else if (myGame.whoWon() == 2)
                    MessageBox.Show("Player Two wins with " + myGame.getP2Guesses() + " guesses!");
            }
            else { 
                int temp;
                if (!int.TryParse(txtP1.Text, out temp))
                {
                    MessageBox.Show("You MUST enter only whole numbers when you make your guesses! Come back when you have learned how to play properly :(");
                    this.Close();
                }
                myGame.playerTwoGuess(temp);

                if (myGame.isPlayerHigh())
                    this.BackColor = System.Drawing.Color.LightSalmon;
                else
                    this.BackColor = System.Drawing.Color.LightCyan;

                if (myGame.whoWon() == 1)
                    MessageBox.Show("Player wins with " + myGame.getP1Guesses() + " guesses!");
            }
        }
    }
}
