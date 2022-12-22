using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_1_1_Wiederholung
{
    enum DayofWeek
    {
        Monday = 1,
        Thuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }



    public partial class Form1 : Form
    {
        const string text = ". Tag der Woche";
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdMonday_Click(object sender, EventArgs e)
        {
            LblNumeric.Text = Convert.ToString((int)DayofWeek.Monday) + text;
        }

        private void CmdTuesday_Click(object sender, EventArgs e)
        {
            LblNumeric.Text = Convert.ToString((int)DayofWeek.Thuesday) + text;
        }

        private void CmdWednesday_Click(object sender, EventArgs e)
        {
            LblNumeric.Text = Convert.ToString((int)DayofWeek.Wednesday) + text;
        }

        private void CmdThursday_Click(object sender, EventArgs e)
        {
            LblNumeric.Text = Convert.ToString((int)DayofWeek.Thursday) + text;
        }

        private void CmdFriday_Click(object sender, EventArgs e)
        {
            LblNumeric.Text = Convert.ToString((int)DayofWeek.Friday) + text;
        }

        private void CmdSaturday_Click(object sender, EventArgs e)
        {
            LblNumeric.Text = Convert.ToString((int)DayofWeek.Saturday) + text;
        }

        private void CmdSunday_Click(object sender, EventArgs e)
        {
            LblNumeric.Text = Convert.ToString((int)DayofWeek.Sunday) + text;
        }
    }
}
