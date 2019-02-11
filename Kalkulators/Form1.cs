using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        string ievade = string.Empty;
        string oper = string.Empty;
        string oper1 = string.Empty;
        string darbiba;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();

        }

        private void sk1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "1";
            this.textBox1.Text += ievade;
        }

        private void sk2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "2";
            this.textBox1.Text += ievade;
        }

        private void sk3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "3";
            this.textBox1.Text += ievade;
        }

        private void sk4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "4";
            this.textBox1.Text += ievade;
        }

        private void sk5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "5";
            this.textBox1.Text += ievade;
        }

        private void sk6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "6";
            this.textBox1.Text += ievade;
        }

        private void sk7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "7";
            this.textBox1.Text += ievade;
        }

        private void sk8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "8";
            this.textBox1.Text += ievade;
        }

        private void sk9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "9";
            this.textBox1.Text += ievade;
        }

        private void sk0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            ievade += "0";
            this.textBox1.Text += ievade;
        }

        private void opPluss_Click(object sender, EventArgs e)
        {
            oper = ievade;
            darbiba = "+";
            ievade = string.Empty;
        }

        private void opMinus_Click(object sender, EventArgs e)
        {
            oper = ievade;
            darbiba = "-";
            ievade = string.Empty;
        }

        private void opReiz_Click(object sender, EventArgs e)
        {
            oper = ievade;
            darbiba = "*";
            ievade = string.Empty;
        }

        private void opDalits_Click(object sender, EventArgs e)
        {
            oper = ievade;
            darbiba = "/";
            ievade = string.Empty;
        }

        private void opIr_Click(object sender, EventArgs e)
        {
            oper1 = ievade;
            double sk1, sk2;
            double.TryParse(oper, out sk1);
            double.TryParse(oper1, out sk2);

            if (darbiba == "+")
            { result = sk1 + sk2;
                textBox1.Text = result.ToString();
            }
            else if (darbiba=="-")
                {
                result = sk1 - sk2;
                textBox1.Text = result.ToString();
            }
            else if (darbiba == "*")
            {
                result = sk1 * sk2;
                textBox1.Text = result.ToString();
            }
            else if (darbiba == "/")
            {
                result = sk1 / sk2;
                textBox1.Text = result.ToString();
            }
        }

        private void opClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.ievade = string.Empty;
            this.oper = string.Empty;
            this.oper1 = string.Empty;

        }


    }
}
