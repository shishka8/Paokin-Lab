using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadaniye_3_paokin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x,c,v;
            bool rez1 = int.TryParse(textBox1.Text, out x);
            if (rez1 == false)
            {
                MessageBox.Show("Неверный формат числа " + textBox1.Text + "!");
                return;
            }
            bool rez4 = int.TryParse(textBox4.Text, out c);
            if (rez4 == false)
            {
                MessageBox.Show("Неверный формат числа " + textBox4.Text + "!");
                return;
            }
            bool rez5 = int.TryParse(textBox5.Text, out v);
            if (rez5 == false)
            {
                MessageBox.Show("Неверный формат числа " + textBox5.Text + "!");
                return;
            }

            c = (6*x+13*c)*2;
            string cStr = c.ToString();
            label2.Text = cStr;
            return;
        }
    }
}
