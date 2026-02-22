using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA5555
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Подключаемся к базе через твою модель
            using (ModelDB db = new ModelDB())
            {
                // 2. Берем список всех мотоциклов
                var list = db.Motobike_csv.ToList();

                // 3. Для каждого элемента из базы создаем твой визуальный компонент
                foreach (var item in list)
                {
                    UserControlName card = new UserControlName();

                    // Заполняем карточку данными через созданный тобой метод
                    card.GenerateData(item);

                    // Добавляем готовую карточку в панель на форме
                    flowLayoutPanel1.Controls.Add(card); 
                }
            }
        }
    }
    }
