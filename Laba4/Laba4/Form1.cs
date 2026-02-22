using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

    if (listBox1.SelectedIndex == -1) return;


    if (!double.TryParse(textBox1.Text, out double a) || 
        !double.TryParse(textBox2.Text, out double b))
    {
        return; 
    }

    double result = 0;
    string operation = listBox1.SelectedItem.ToString();

    switch (operation)
    {
        case "+": result = a + b; break;
        case "-": result = a - b; break;
        case "*": result = a * b; break;
        case "/": 
            if (b != 0) result = a / b; 
            else { textBox3.Text = "Ошибка (0)"; return; }
            break;
    }

   
    textBox3.Text = result.ToString();
}
            }
        }
    

