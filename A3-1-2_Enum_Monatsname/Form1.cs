using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_1_2_Enum_Monatsname
{
    public partial class Form1 : Form
    {
        enum Month : int
        {
            Januar = 1,
            Februar,
            März,
            April,
            Mai,
            Juni,
            Juli,
            August,
            Septemper,
            Oktober,
            November,
            Dezember
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void NumChoose_ValueChanged(object sender, EventArgs e)
        {
            LblResult.Text = Convert.ToString((Month)NumChoose.Value);
        }
    }
}
