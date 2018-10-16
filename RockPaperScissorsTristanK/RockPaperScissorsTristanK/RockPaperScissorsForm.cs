/*
 * Created By: Tristan Kalabric
 * Created On: October 16, 2018
 * Created For: ICS2U Programming
 * Daily Assignment - Day #18 - Rock, Paper, Scissors
 * This program plays rock, paper, scissors with the user
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

namespace RockPaperScissorsTristanK
{
    public partial class frmRockPaperScissors : Form
    {
        //declare global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();
            lblOutcome.Hide();
            randomNumberGenerator = new Random();
        }

        private void radCChoiceRock_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int uChoice, cChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            //Get the user's selection, if there is o selection set it to 0
            if (radUChoiceRock.Checked == true)
            {
                uChoice = ROCK;
            }
            else if (radUChoicePaper.Checked == true)
            {
                uChoice = PAPER;
            }
            else if (radUChoiceScissors.Checked == true)
            {
                uChoice = SCISSORS;
            }
            else
            {
                uChoice = 0;
            }

            //Randomly generate a number between 1 and 3, representing ROCK, PAPER or SCISSORS
            cChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //Set the radio button for the computer's choice
            if (cChoice == ROCK)
            {
                this.radCChoiceRock.Checked = true;
            }
            else if (cChoice == PAPER)
            {
                this.radCChoicePaper.Checked = true;
            }
            else
            {
                this.radCChoiceScissors.Checked = true;
            }

            //Check if the user's choice is equal to the computer's choice
            if (uChoice == ROCK)
            {
                if (cChoice == ROCK)
                {
                    this.lblOutcome.Text = "Tie";
                    lblOutcome.Show();
                }
                else if (cChoice == PAPER)
                {
                    this.lblOutcome.Text = "Computer wins";
                    lblOutcome.Show();
                }
                else
                {
                    this.lblOutcome.Text = "User wins";
                    lblOutcome.Show();
                }
            }
            else if (uChoice == PAPER)
            {
                if (cChoice == ROCK)
                {
                    this.lblOutcome.Text = "User wins";
                    lblOutcome.Show();
                }
                else if (cChoice == PAPER)
                {
                    this.lblOutcome.Text = "Tie";
                    lblOutcome.Show();
                }
                else
                {
                    this.lblOutcome.Text = "Computer wins";
                    lblOutcome.Show();
                }
            }
            else
            {
                if (cChoice == ROCK)
                {
                    this.lblOutcome.Text = "Computer wins";
                    lblOutcome.Show();
                }
                else if (cChoice == PAPER)
                {
                    this.lblOutcome.Text = "User wins";
                    lblOutcome.Show();
                }
                else
                {
                    this.lblOutcome.Text = "Tie";
                    lblOutcome.Show();
                }
            }

        }
    }
}
