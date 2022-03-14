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

        private History history = new History();

        private void StartBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Converter converter = new Converter(10);
                Checker checker = new Checker();
                if(checker.IsOkay(Input1.Text, true, Convert.ToInt32(Input2.Text)))
                {
                    string bufer = converter.Convert_from(Input1.Text, Convert.ToInt32(Input2.Text));
                    OutputLB.Text = converter.Convert_to(bufer, Convert.ToInt32(Input3.Text));

                    history.AddCalculation(Input1.Text, Input2.Text,
                                            converter.Convert_to(bufer, Convert.ToInt32(Input3.Text)), Input3.Text);
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

        #region Blocker
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Input2.Text = trackBar1.Value.ToString();
            blockControl(trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Input3.Text = trackBar2.Value.ToString();
        }

        private void blockControl(int cc)
        {
            for(int i = 0; i<cc; i++)
            {
                enabler(i);
            }

            for(int i = cc; i<16; i++)
            {
                blocker(i);
            }
        }

        private void blocker(int index)
        {
            switch (index)
            {
                case 0:
                    BTN_0.Enabled = false;
                    break;
                case 1:
                    BTN_1.Enabled = false;
                    break;
                case 2:
                    BTN_2.Enabled = false;
                    break;
                case 3:
                    BTN_3.Enabled = false;
                    break;
                case 4:
                    BTN_4.Enabled = false;
                    break;
                case 5:
                    BTN_5.Enabled = false;
                    break;
                case 6:
                    BTN_6.Enabled = false;
                    break;
                case 7:
                    BTN_7.Enabled = false;
                    break;
                case 8:
                    BTN_8.Enabled = false;
                    break;
                case 9:
                    BTN_9.Enabled = false;
                    break;
                case 10:
                    BTN_A.Enabled = false;
                    break;
                case 11:
                    BTN_B.Enabled = false;
                    break;
                case 12:
                    BTN_C.Enabled = false;
                    break;
                case 13:
                    BTN_D.Enabled = false;
                    break;
                case 14:
                    BTN_E.Enabled = false;
                    break;
                case 15:
                    BTN_F.Enabled = false;
                    break;
                default:
                    throw new Exception("Out of range");
            }
        }

        private void enabler(int index)
        {
            switch (index)
            {
                case 0:
                    BTN_0.Enabled = true;
                    break;
                case 1:
                    BTN_1.Enabled = true;
                    break;
                case 2:
                    BTN_2.Enabled = true;
                    break;
                case 3:
                    BTN_3.Enabled = true;
                    break;
                case 4:
                    BTN_4.Enabled = true;
                    break;
                case 5:
                    BTN_5.Enabled = true;
                    break;
                case 6:
                    BTN_6.Enabled = true;
                    break;
                case 7:
                    BTN_7.Enabled = true;
                    break;
                case 8:
                    BTN_8.Enabled = true;
                    break;
                case 9:
                    BTN_9.Enabled = true;
                    break;
                case 10:
                    BTN_A.Enabled = true;
                    break;
                case 11:
                    BTN_B.Enabled = true;
                    break;
                case 12:
                    BTN_C.Enabled = true;
                    break;
                case 13:
                    BTN_D.Enabled = true;
                    break;
                case 14:
                    BTN_E.Enabled = true;
                    break;
                case 15:
                    BTN_F.Enabled = true;
                    break;
                default:
                    throw new Exception("Out of range");
            }
        }
        #endregion

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(history);
            form2.Show();
        }
    }
}
