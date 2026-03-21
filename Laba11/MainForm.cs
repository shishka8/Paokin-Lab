using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Captcha.Models;

namespace Captcha
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (new ModelEF().Users.Any(x=>
            x.Login == loginTextBox.Text &&
            x.Password == passwordTextBox.Text))
            {
                MessageBox.Show("Пользователь найден");
                return;
            }
            MessageBox.Show("Пользователь не найден, пройдите проверку Captcha!");
            new CaptchForm().ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
