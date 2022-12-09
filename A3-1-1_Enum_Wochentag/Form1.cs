using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_1_1_Enum_Wochentag
{
    public partial class Form1 : Form
    {
        const string supplement = ". Tag der Woche";

        enum DayofWeek : int
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdMonday_Click(object sender, EventArgs e)
        {
            LblDayofWeek.Text = Convert.ToString ( (int)DayofWeek.Monday ) + supplement;
        }

        private void CmdThuesday_Click(object sender, EventArgs e)
        {
            LblDayofWeek.Text = Convert.ToString((int)DayofWeek.Tuesday ) + supplement;
        }

        private void CmdWednesday_Click(object sender, EventArgs e)
        {
            LblDayofWeek.Text = Convert.ToString((int)DayofWeek.Wednesday ) + supplement;
        }

        private void CmdThursday_Click(object sender, EventArgs e)
        {
            LblDayofWeek.Text = Convert.ToString((int)DayofWeek.Thursday ) + supplement;
        }

        private void CmdFriday_Click(object sender, EventArgs e)
        {
            LblDayofWeek.Text = Convert.ToString((int)DayofWeek.Friday ) + supplement;
        }

        private void CmdSaturday_Click(object sender, EventArgs e)
        {
            LblDayofWeek.Text = Convert.ToString((int)DayofWeek.Saturday) + supplement;
        }

        private void CmdSunday_Click(object sender, EventArgs e)
        {
            LblDayofWeek.Text = Convert.ToString((int)DayofWeek.Sunday) + supplement;
        }
    }
}
