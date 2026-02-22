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
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }
public void GenerateData(Motobike_csv moto)
        {
            // Присваиваем тексту лейблов значения из базы
            labelIDData.Text = moto.Id.ToString();
            labelBrandData.Text = moto.Brand;
            labelModelData.Text = moto.Model;
            labelPriceData.Text = moto.Price.ToString() + " руб.";
            labelHorsepowerData.Text = moto.Horsepower.ToString();
            labelMileageData.Text = moto.Mileage.ToString();
        }
    }
}
