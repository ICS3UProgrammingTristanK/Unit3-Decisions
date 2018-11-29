using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquareTristanK
{
    public partial class frmPerfectSquare : Form
    {
        public frmPerfectSquare()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            //Set the initial values
            endingValue = 1;
            value = 1;
            squareRootAsDouble = 1;
            squareRootAsInteger = 1;

            //Clear all items from list box
            this.lstPerfectSquares.Items.Clear();

            //get the users end value selection from the nud
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            //Continue stating any perfect squares between the min value and the users selected end value
            while (value <= endingValue)
            {
                //take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                //Convert the double to an int
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                //The only way for both the decimal and the integer to be equal is if the value was a perfect square
                if(squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }

                value = value + 1;
            }


        }
    }
}
