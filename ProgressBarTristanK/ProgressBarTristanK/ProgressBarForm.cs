/*
 * Created By: Tristan Kalabric
 * Created On: October 22, 2018
 * Created For ICS3U Programming
 * Daily Assignment - Day #20 - Progress Bar
 * This program displays a progress bar that loads when the user clicks start
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

namespace ProgressBarTristanK
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare variables and constants
            const int MAX_PROGRESS_BAR_VALUE = 100;
            int valueOfProgressBar = 0;

            //Increment the value of the progress bar by 5 ach time until it has reached its max value
            do
            {
                this.prbLoading.Value = valueOfProgressBar;
                valueOfProgressBar = valueOfProgressBar + 5;
                this.Refresh();
            } while (valueOfProgressBar <= MAX_PROGRESS_BAR_VALUE);
        }
    }
}
