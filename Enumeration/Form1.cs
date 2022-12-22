using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeration
{
    enum Week : byte
    {
        Monday=1,
        Thuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Gender
    {
        male,
        female
    }

    enum MySize
    {
        M=38,
        L=41,
        XL=44,
        XXL=48
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdDemo_Click(object sender, EventArgs e)
        {
            Week today = Week.Thuesday;
            int todayAsValue = (int)today;
            Txt_Ausgabe.Text = Convert.ToString(todayAsValue);

        }

        private void CmdModulo_Click(object sender, EventArgs e)
        {
            Txt_Ausgabe.Text = "1000 % 12 \r\n";
            Txt_Ausgabe.Text = Txt_Ausgabe.Text + (1000 % 12) +""; //+"" für String Konvertierung oder .ToString()
        }

        private void CmdIncDecDemo_Click(object sender, EventArgs e)
        {
            Txt_Ausgabe.Text = "int a=10 -> Post-Increment \r\n";
            int a = 10;
            Txt_Ausgabe.Text = Txt_Ausgabe.Text + "Vor Increment: " + a +"\r\n";
            int b = a++;
            Txt_Ausgabe.Text = Txt_Ausgabe.Text + "Bei Zuweisung mit Post-Increment: " + b + "\r\n";
            Txt_Ausgabe.Text = Txt_Ausgabe.Text + "Nach Increment: " + a;
        }

        private void CmdDivision_Click(object sender, EventArgs e)
        {

        }
    }
}
