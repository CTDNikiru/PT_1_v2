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
    public partial class Form2 : Form
    {
        private History formHistory;

        public Form2(History history)
        {
            formHistory = history;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Ввод\n" + formHistory.GetAllInput();
            label2.Text = "Система\n" + formHistory.GetAllInputCC();
            label3.Text = "Вывод\n" + formHistory.GetAllOut();
            label4.Text = "Система\n" + formHistory.GetAllOutCC();
        }
    }
}
