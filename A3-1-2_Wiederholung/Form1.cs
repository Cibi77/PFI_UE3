using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_1_2_Wiederholung
{
    enum Month
    {
        Januar = 1,
        Februar = 2,
        März = 3,
        April = 4,
        Mai,
        Juni,
        Juli,
        August,
        September,
        Oktober,
        November,
        Dezember
    }
    public partial class Form1 : Form
    {
        Month actualMonth = Month.Januar;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            actualMonth = (Month)NumNumber.Value;
            TxtMonth.Text = Convert.ToString(actualMonth);
        }
    }
}
