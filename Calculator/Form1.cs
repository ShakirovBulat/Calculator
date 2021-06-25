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
            double SumR = Convert.ToDouble(textBox2.Text);
            string ProcD = Convert.ToString(textBox3);
            int kolD = Convert.ToInt32(textBox4.Text);
            double[] razd = textBox3.Text.Split(' ').Select(x => double.Parse(x)).ToArray();
            var r = ProcD.Where(x => char.IsDigit(x)).Sum(x => char.GetNumericValue(x));
            r = r / 10 / kolD;
            textBox6.Text = Convert.ToString(r);
            foreach (var Sum in razd)
            {
                textBox1.Text = Convert.ToString((SumR / 100) * r * kolD + SumR);
                textBox5.Text = Convert.ToString(((SumR / 100) * r * kolD + SumR) - SumR);
            }
            
        }
    }
}
