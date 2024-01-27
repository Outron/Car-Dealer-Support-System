using CarDealerSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarDealerSupportSystem.SellerFormPanels.MakeOrderPanel;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class CarConfigurator : Form
    {
        private readonly SelectedCarInfo selectedCarInfo;
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();

        public CarConfigurator(SelectedCarInfo selectedCarInfo)
        {
            InitializeComponent();
            this.selectedCarInfo = selectedCarInfo;
        }

        private void CarConfigurator_Load(object sender, EventArgs e)
        {
            Brand.Text = selectedCarInfo.SelectedBrand;
            Brand.BringToFront();
            Model.Text = selectedCarInfo.SelectedModel;
            Model.BringToFront();
            CarImageBox.Size = new Size(700, 420);

            CarImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (selectedCarInfo.SelectedImage != null && selectedCarInfo.SelectedImage.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(selectedCarInfo.SelectedImage))
                {
                    Image image = Image.FromStream(memoryStream);
                    CarImageBox.Image = image;
                }
            }
            colorLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.Kolor).FirstOrDefault();
            engineLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.TypSilnika).FirstOrDefault();
            powerLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.MocSilnika).FirstOrDefault().ToString() + "KM";
            priceLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.CenaPodstawowa).FirstOrDefault().ToString();
            fuelUsageLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.SrednieSpalanie).FirstOrDefault().ToString() + "l/100km";
            bodyLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.TypNadwozia).FirstOrDefault();
        }

  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
