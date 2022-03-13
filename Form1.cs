using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_1_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Converter converter = new Converter(10);
                Checker checker = new Checker();
                if(checker.IsOkay(Input1.Text, true) && checker.IsOkay(Input2.Text, false) && checker.IsOkay(Input3.Text, false))
                {
                    string bufer = converter.Convert_from(Input1.Text, Convert.ToInt32(Input2.Text));
                    OutputLB.Text = converter.Convert_to(bufer, Convert.ToInt32(Input3.Text));
                }
            }
            catch(Exception z)
            {
                OutputLB.Text = z.Message;
            }

        }

        #region InputBTN
        private void BTN_1_Click(object sender, EventArgs e)
        {
            Input1.Text += "1";
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            Input1.Text += "2";
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            Input1.Text += "3";
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            Input1.Text += "4";
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            Input1.Text += "5";
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            Input1.Text += "6";
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            Input1.Text += "7";
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            Input1.Text += "8";
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            Input1.Text += "9";
        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            Input1.Text += "0";
        }

        private void BTN_DOT_Click(object sender, EventArgs e)
        {
            Input1.Text += ".";
        }

        private void BTN_A_Click(object sender, EventArgs e)
        {
            Input1.Text += "A";
        }

        private void BTN_B_Click(object sender, EventArgs e)
        {
            Input1.Text += "B";
        }

        private void BTN_C_Click(object sender, EventArgs e)
        {
            Input1.Text += "C";
        }

        private void BTN_D_Click(object sender, EventArgs e)
        {
            Input1.Text += "D";
        }

        private void BTN_E_Click(object sender, EventArgs e)
        {
            Input1.Text += "E";
        }

        private void BTN_F_Click(object sender, EventArgs e)
        {
            Input1.Text += "F";
        }

        private void BTN_CE_Click(object sender, EventArgs e)
        {
            Input1.Text = "";
        }

        private void BTN_ERONE_Click(object sender, EventArgs e)
        {
            Input1.Text = Input1.Text.Remove(Input1.Text.Length - 1);
        }

        #endregion

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Input2.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Input3.Text = trackBar2.Value.ToString();
        }
    }
}
