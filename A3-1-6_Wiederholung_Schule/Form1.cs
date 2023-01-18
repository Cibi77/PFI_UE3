using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_1_6_Bitwise_Rechner
{
    public partial class Form1 : Form
    {

        byte byte1 = 0;
        byte byte2 = 0;
        int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumByte1Bit1_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 1;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte1Bit2_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^=  2;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte1Bit3_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 4;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte1Bit4_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 8;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte1Bit5_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 16;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte1Bit6_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 32;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte1Bit7_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 64;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte1Bit8_ValueChanged(object sender, EventArgs e)
        {
            byte1 ^= 128;
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte1);
        }

        private void NumByte2Bit1_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 1;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void NumByte2Bit2_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 2;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void NumByte2Bit3_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 4;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void NumByte2Bit4_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 8;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void NumByte2Bit5_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 16;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void NumByte2Bit6_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 32;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void NumByte2Bit7_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 64;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void NumByte2Bit8_ValueChanged(object sender, EventArgs e)
        {
            byte2 ^= 128;
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte2);
        }

        private void CmdAnd_Click(object sender, EventArgs e)
        {
            result = byte1 & byte2;
            LblResultbin.Text = "Ergebnis binär: " + Convert.ToString(result, 2);
            LblResultdez.Text = "Ergebnis dezimal: " + Convert.ToString(result);
        }

        private void CmdOr_Click(object sender, EventArgs e)
        {
            result = byte1 | byte2;
            LblResultbin.Text = "Ergebnis binär: " + Convert.ToString(result, 2);
            LblResultdez.Text = "Ergebnis dezimal: " + Convert.ToString(result);
        }
    }
}
