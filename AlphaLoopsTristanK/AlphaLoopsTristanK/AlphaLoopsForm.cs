/*
 * Created by: Tristan Kalabric
 * Created on: November 5, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program displays the alphabet multiple times using nested loops in a listbox
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

namespace AlphaLoopsTristanK
{
    public partial class frmAlphaLoops : Form
    {
        public frmAlphaLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare local variables
            string firstCharacter;
            string secondCharacter;
            int counterFirstLetter;
            int counterSecondLetter;

            //Clear listbox
            this.lstAlphabet.Items.Clear();

            //Loop through the letters from a to z
            for (counterFirstLetter = 65; counterFirstLetter <= 90; counterFirstLetter++)
            {

                //For each of the letters above, loop through again beside it the second letter from a to z
                for (counterSecondLetter = 97; counterSecondLetter <= 122; counterSecondLetter++)
                {
                    secondCharacter = Char.ConvertFromUtf32(counterSecondLetter);
                    lstAlphabet.Items.Add(counterFirstLetter + " -> " + secondCharacter);
                }
            }
        }
    }
}
