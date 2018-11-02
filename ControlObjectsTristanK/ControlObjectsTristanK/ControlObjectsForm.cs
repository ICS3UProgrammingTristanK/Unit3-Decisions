/*
 * Created by: Tristan Kalabric
 * Created on: November 2, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes the colour of the button and the label when the user clicks on them
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

namespace ControlObjectsTristanK
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            //Loop through each object on the form and make it green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;

                //If the object is a label, make it purple
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
            }
        }

        private void lblChangeColour_Click(object sender, EventArgs e)
        {
            //Loop through each object on the form and make it red
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;

                //If the object is a label, make it red
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Red;
                }
            }
        }
    }
}
