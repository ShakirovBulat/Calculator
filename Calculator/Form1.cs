using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SumR = Convert.ToInt32(textBox1);
            int ProcD = Convert.ToInt32(textBox3);
            int kolD = Convert.ToInt32(textBox2);
            int ObSum = 0;

            for (int i = 1; i <= kolD; i++)
            {
                ObSum = (SumR / 100) * ProcD;
            }
        }
    }
}
