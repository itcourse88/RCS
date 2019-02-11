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
        public Form1()
        {
            InitializeComponent();

            opClear.Click += OpClear_Click;
            opPluss.Click += OpPluss_Click;
        }

        private void OpPluss_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }


    }
}
