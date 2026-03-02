using labi8.FolderModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using labi8.FolderModel;
namespace labi8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Экземпляр класса для работы с БД
        ModelEF database = new ModelEF();

        //список для загрузки в него изначальных (не изменённых) данных
        List<Pavilion> pavilions = new List<Pavilion>();

        //список для загрузки в него изменённых данных
        List<Pavilion> PavilionsChange = new List<Pavilion>();

        //Список для загрузки в него полей класса Pavilion
        List<string> pavilionsProp = new List<string>();

        private void LoadStartData() //загрузка данных списка в источник данных
        {
            pavilionBindingSource.DataSource = PavilionsChange;
        }
    

        private void LoadDataCombo() //загрузка данных в comboBoxOrderBy
        {
            //загружаем поля
            pavilionsProp = typeof(Pavilion).GetProperties().Select(x => x.Name).ToList();
            //удаляем поля - связи
            pavilionsProp.RemoveRange(pavilionsProp.Count - 2, 2);
            //загружаем полученные данные в comboBoxOrderBy
            comboBoxOrderBy.DataSource = pavilionsProp;
            //выбираем первый элемент в comboBoxOrderBy
            comboBoxOrderBy.SelectedIndex = 0;

        }

        private void LoadOrder() //метод сортировки данных из списка
        {
            // (условие) если checkBoxDesc поле Checked имеет значение true -->
            PavilionsChange = checkBoxDesc.Checked ?
            //присваивается это значение списка -->
            PavilionsChange.OrderByDescending(p => p.GetType().GetProperties().First(x => x.Name == comboBoxOrderBy.SelectedItem.ToString()).GetValue(p)).ToList()
            //иначе это значение списка
            : PavilionsChange.OrderBy(p => p.GetType().GetProperties().First(x => x.Name == comboBoxOrderBy.SelectedItem.ToString()).GetValue(p)).ToList();
            LoadStartData(); // -- выполнение метода загрузки данных

        }

        //событие загрузки формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            //загружаем данные в списки из БД
            PavilionsChange = pavilions = database.Pavilion.ToList();
            //вызываем методы загрузки
            LoadStartData();
            LoadDataCombo();
        }

        private void Data_changes(object sender, EventArgs e)
        {
            LoadOrder(); //вызываем метод сортировки данных

        }

        //Это событие возникает, если Text свойство элемента textBoxStatus изменяется
        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            //поиск pavilions по списку где по полю статус содержится текст из textBoxStatus
            PavilionsChange = pavilions.Where(x => x.Status.Contains(textBoxStatus.Text)).ToList();
            //вызываем метод сортировки данных
            LoadOrder();

        }
    }
}
