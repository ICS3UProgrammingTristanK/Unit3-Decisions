/*
 * Created by: Tristan Kalabric
 * Created on: October 31, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - SumOfNumbers
 * This program displays the sum of all the numbers up to the number that the user has entered
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

namespace SumOfNumbersTristanK
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
            lblSumAnswer.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Declare local variables
            double userNumber;
            double sumOfNumbers;
            int counter;

            //Clear the items from the listbox
            this.lstSumOfNumAnswer.Items.Clear();

            //Initialize the final answer to 1
            sumOfNumbers = 1;

            //Get the number from the user
            userNumber = Convert.ToDouble(txtUserNumber.Text);

            for (counter = 1; counter <= userNumber; counter++)
            {
                //List the counter number in the listbox for the user to see
                this.lstSumOfNumAnswer.Items.Add(counter);

                //Add the counter to the users number
                sumOfNumbers = sumOfNumbers + counter;

                //Convert the sumOfNumbers to a string and insert it in the label
                this.lblSumAnswer.Text ="The Sum Of Numbers Is " + Convert.ToString(sumOfNumbers);
                lblSumAnswer.Show();
            }
        }
    }
}
