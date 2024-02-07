using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += 9;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string math = txtbxResult.Text;
            string value = new DataTable().Compute(math, null).ToString();
            txtbxResult.Text = value;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtbxResult.Text += "/";
        }
    }
}
