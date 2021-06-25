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
            var ProcOk = ProcD.Where(x => char.IsDigit(x)).Sum(x => char.GetNumericValue(x));
            ProcOk = ProcOk / 10 / kolD;

            textBox6.Text = Convert.ToString(ProcOk);

            foreach (var Sum in razd)
            {
                textBox1.Text = Convert.ToString((SumR / 100) * ProcOk * kolD + SumR);
                textBox5.Text = Convert.ToString(((SumR / 100) * ProcOk * kolD + SumR) - SumR);
            }
            string n = Convert.ToString(textBox3);
            char a = ' ';
            int i = 0;
            int b = -1;
            while (i != n.Length)
            {
                if (n[i] == a && ((n[i - 1] != a) || (i - 1 < 0)) && n[i + 1] != a)
                {
                    b++;
                }
                i++;
            }
            if (!(kolD == b))
            {
                MessageBox.Show("Введено неправильное кол-во дней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
