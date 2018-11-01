/*
 * Created by: Tristan Kalabric
 * Created on: November 1, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode A to Z
 * This program displays the unicode number for all capital letters in the english alphabet
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

namespace UnicodeAToZTristanK
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int counter = 65;
            const int MAXNUM = 90;
            const int MINNUM = 65;
            string character;

            //Clear the items from the listbox
            this.lstUnicode.Items.Clear();

            //Convert each number
            for (counter = MINNUM; counter <= MAXNUM; counter++)
            {
                character = Char.ConvertFromUtf32(counter);
                lstUnicode.Items.Add(character + "-" + counter);
            }
        }
    }
}
