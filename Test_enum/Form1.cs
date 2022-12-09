using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_enum
{
    public partial class Form1 : Form
    {
        enum Wochentag : int
        {
            Montag = 1,
            Dienstag,
            Mittwoch,
            Donnerstag,
            Freitag,
            Samstag,
            Sonntag
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void NumDay_ValueChanged(object sender, EventArgs e)
        {
            TxtDayName.Text = Convert.ToString((Wochentag)NumDay.Value);
        }
    }
}
