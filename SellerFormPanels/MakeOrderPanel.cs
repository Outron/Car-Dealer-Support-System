using CarDealerSupportSystem.Models;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class MakeOrderPanel : Form
    {

        private readonly salon_samochodowyContext db = new salon_samochodowyContext();

        public MakeOrderPanel()
        {
            InitializeComponent();
        }


        // add to this function parameters to filter cars

        private void ChooseCarPanel(List<Samochody> carData)
        {
            flowLayoutPanel1.Controls.Clear();


            foreach (var data in carData)
            {
                Panel panel = new Panel();
                panel.Size = new Size(350, 300);
                panel.BackColor = Color.FromArgb(43, 43, 43);
                panel.Margin = new Padding(5, 5, 5, 15);
                panel.Cursor = Cursors.Hand;


                Label brandLabel = new Label();
                brandLabel.Text = data.Marka;
                brandLabel.ForeColor = Color.White;
                brandLabel.Font = new Font("Segoe UI", 20);
                brandLabel.AutoSize = true;
                brandLabel.Dock = DockStyle.Bottom;
                brandLabel.Padding = new Padding(10, 0, 0, 0);


                Label modelLabel = new Label();
                modelLabel.Text = data.Model;
                modelLabel.ForeColor = Color.White;
                modelLabel.Font = new Font("Segoe UI", 15);
                modelLabel.AutoSize = true;
                modelLabel.Dock = DockStyle.Bottom;
                modelLabel.Padding = new Padding(13, 0, 0, 10);



                panel.Controls.Add(brandLabel);
                panel.Controls.Add(modelLabel);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MakeOrderPanel.ActiveForm.Close();
        }

        private void MakeOrderPanel_Load(object sender, EventArgs e)
        {
            var carDataList = db.Samochody
                .Select(c => new Samochody { Marka = c.Marka, Model = c.Model })
                .Distinct()
                .ToList();
            ChooseCarPanel(carDataList);
            BrandComboBox.DataSource = db.Samochody.Select(c => c.Marka).Distinct().ToList();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BrandComboBox.SelectedItem != null)
            {
                ModelComboBox.DataSource = db.Samochody.Where(c => c.Marka == BrandComboBox.SelectedItem.ToString()).Select(c => c.Model).Distinct().ToList();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var cars = db.Samochody.ToList();

            if (BrandComboBox.SelectedItem != null)
            {
                cars = cars.Where(c => c.Marka == BrandComboBox.SelectedItem.ToString()).ToList();
            }
            if (ModelComboBox.SelectedItem != null)
            {
                cars = cars.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).ToList();
            }

            ChooseCarPanel(cars);

        }
    }
}



