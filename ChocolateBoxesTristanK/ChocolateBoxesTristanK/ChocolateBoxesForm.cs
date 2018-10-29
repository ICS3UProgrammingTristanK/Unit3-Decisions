/*
 * created On: October 18, 2018
 * Created By: Tristan Kalabric
 * Created For: ICS3U Programming
 * Daily Assignment - Day #19 - Chocolate Boxes
 * This program tells the user what prize they get for selling chocolate boxes
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

namespace ChocolateBoxesTristanK
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
            //Hide the label
            lblPrize.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Check how many boxes the user sold
            if (nudBoxesSold.Value > 20)
            {
                //Tell the user they won a prize
                this.lblPrize.Text = "You won a prize!";

                //Display label
                lblPrize.Show();
            }
            else
            {
                if (nudBoxesSold.Value < 10)
                {
                    //Tell the user the got an honorable mention
                    this.lblPrize.Text = "You get an honorable mention!";

                    //Display label
                    lblPrize.Show();
                }

                else
                {
                    //tell the user they won a small prize
                    this.lblPrize.Text = "You won a small prize!";

                    //Display label
                    lblPrize.Show();

                }

            }
        }
    }
}
