using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelcount.Text = "Skaits: ";
            buttonAdd.Click += ButtonAdd_Click;
            inputnumber.Text = "1";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
           /* int sk = int.Parse(inputnumber.Text);
            sk++;
            inputnumber.Text = sk.ToString();   ->garais var*/   

            inputnumber.Text = (int.Parse(inputnumber.Text) + 1).ToString();
            
        }
    }
}
