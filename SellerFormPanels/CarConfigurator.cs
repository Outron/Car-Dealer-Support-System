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
            Model.Text = selectedCarInfo.SelectedModel;
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

        public class GlassyPanel : Panel
        {
            const int WS_EX_TRANSPARENT = 0x20;

            int opacity = 50;

            public int Opacity
            {
                get
                {
                    return opacity;
                }
                set
                {
                    if (value < 0 || value > 100) throw new ArgumentException("Value must be between 0 and 100");
                    opacity = value;
                }
            }

            protected override CreateParams CreateParams
            {
                get
                {
                    var cp = base.CreateParams;
                    cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;

                    return cp;
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                using (var b = new SolidBrush(Color.FromArgb(opacity * 255 / 100, BackColor)))
                {
                    e.Graphics.FillRectangle(b, ClientRectangle);
                }

                base.OnPaint(e);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
