using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageTristanK
{
    public partial class frmRunningAverage : Form
    {

        public frmRunningAverage()
        {
            InitializeComponent();
            lblAverageIs.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare variables
            double average = 0, numbMarks = 0, total = 0, uNumb = 0;

            //Declare constants
            const int MAXMARK = 100;
            const int MINMARK = 0;

        }
    }
}
