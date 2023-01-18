using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitwise_operations
{
    public partial class Form1 : Form
    {
        int byte01 = 0;
        int byte02 = 0;
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumByte1Bit0_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~1) & byte01) | (1 * (int)NumByte1Bit0.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte1Bit1_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~2) & byte01) | (2 * (int)NumByte1Bit1.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte1Bit2_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~4) & byte01) | (4 * (int)NumByte1Bit2.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte1Bit3_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~8) & byte01) | (8 * (int)NumByte1Bit3.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte1Bit4_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~16) & byte01) | (16 * (int)NumByte1Bit4.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte1Bit5_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~32) & byte01) | (32 * (int)NumByte1Bit5.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte1Bit6_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~64) & byte01) | (64 * (int)NumByte1Bit6.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte1Bit7_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte01 = ((~128) & byte01) | (128 * (int)NumByte1Bit7.Value);
            LblDezByte1.Text = "dezimal: " + Convert.ToString(byte01);
        }

        private void NumByte2Bit0_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~1) & byte02) | (1 * (int)NumByte2Bit0.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void NumByte2Bit1_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~2) & byte02) | (2 * (int)NumByte2Bit1.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void NumByte2Bit2_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~4) & byte02) | (4 * (int)NumByte2Bit2.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void NumByte2Bit3_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~8) & byte02) | (8 * (int)NumByte2Bit3.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void NumByte2Bit4_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~16) & byte02) | (16 * (int)NumByte2Bit4.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void NumByte2Bit5_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~32) & byte02) | (32 * (int)NumByte2Bit5.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void NumByte2Bit6_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~64) & byte02) | (64 * (int)NumByte2Bit6.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void NumByte2Bit7_ValueChanged(object sender, EventArgs e)
        {
            //     dieses Bit löschen , dieses Bit zu bestehendem Wert hinzufügen
            //         |                |
            byte02 = ((~128) & byte02) | (128 * (int)NumByte2Bit7.Value);
            LblDezByte2.Text = "dezimal: " + Convert.ToString(byte02);
        }

        private void CmdAnd_Click(object sender, EventArgs e)
        {
            result = byte01 & byte02;
            LblResultDez.Text = "Ergebnis dezimal: " +Convert.ToString(result);
            LblResultBin.Text = "Ergebnis binär: "+ Convert.ToString(result, 2);
        }

        private void CmdOr_Click(object sender, EventArgs e)
        {
            result = byte01 | byte02;
            LblResultDez.Text = "Ergebnis dezimal: " + Convert.ToString(result);
            LblResultBin.Text = "Ergebnis binär: " + Convert.ToString(result, 2);
        }

        private void CmdXor_Click(object sender, EventArgs e)
        {
            result = byte01 ^ byte02;
            LblResultDez.Text = "Ergebnis dezimal: " + Convert.ToString(result);
            LblResultBin.Text = "Ergebnis binär: " + Convert.ToString(result, 2);
        }
    }
}
