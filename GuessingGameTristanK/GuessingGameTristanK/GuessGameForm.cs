/*
 * Created By: Tristan Kalabric
 * Created on: October 10, 2018
 * Created for: ICS3U Programming
 * Daily Assignment - Day #16 - Number Guessing Game
 * This program generates a random number and tells asks the user to pick what number they think was generated.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTristanK
{
    public partial class frmGuessGame : Form
    {
        public frmGuessGame()
        {
            InitializeComponent();
            lblAnswer.Hide();
            picRightWrong.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare constants and variables
            Random rnd = new Random();
            double ans = rnd.Next(1, 10);
            double guess = (double)(nudGuess.Value);
            const int MAX_NUMBER = 10;
            int number;

            //Get the number from the numeric up down
            number = (int)(nudGuess.Value);

            //Is the users guess right
            if (guess == ans)
            {
                //Display correct label
                this.lblAnswer.Text = "You Guessed Correctly!";
                lblAnswer.Show();
                picRightWrong.Show();
                this.picRightWrong.Image = Properties.Resources.checkmark;
            }
            else
            {
                //Display incorrect label
                this.lblAnswer.Text = "You Guessed Incorrectly!";
                lblAnswer.Show();
                picRightWrong.Show();
                this.picRightWrong.Image = Properties.Resources.red_x;
            }
        }
    }
}
