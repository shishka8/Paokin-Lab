    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.Entity;
    using labaratornaya7.ModelEF;

    namespace labaratornaya7
    {

        public partial class Form1 : Form
        {

            ModelEf db = new ModelEf();

            public Form1()
            {
                InitializeComponent();
            }


            private void StartLoadData()
            {

                db.Users.Load();

                usersBindingSource.DataSource = db.Users.Local.ToBindingList();
            }


            private void SaveData()
            {
                try
                {
                    this.Validate();
                    this.usersBindingSource.EndEdit();
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!", "EF");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сохранения: " + ex.Message);
                }
            }


            private void Form1_Load(object sender, EventArgs e)
            {
                StartLoadData();
            }


            private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            {
                SaveData();
            }


            private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
            {
                SaveData();
            }


    }
    }