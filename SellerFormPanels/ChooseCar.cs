using CarDealerSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class ChooseCar : Form
    {

        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        public ChooseCar()
        {
            InitializeComponent();
        }
        private void CarLayout(List<Samochody> carData)
        {
            CarLayoutPanel.Controls.Clear();


            foreach (var data in carData)
            {
                Panel panel = new Panel();
                panel.Size = new Size(350, 300);
                panel.BackColor = Color.FromArgb(43, 43, 43);
                panel.Margin = new Padding(5, 5, 5, 15);
                panel.Cursor = Cursors.Hand;
                panel.Click += (sender, e) =>
                {
                    CarConfigurator carConfigurator = new CarConfigurator();
                    carConfigurator.Show();
                };

                
                


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
                CarLayoutPanel.Controls.Add(panel);
            }
        }
        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BrandComboBox1.SelectedItem != null)
            {
                ModelComboBox1.DataSource = db.Samochody.Where(c => c.Marka == BrandComboBox1.SelectedItem.ToString()).Select(c => c.Model).Distinct().ToList();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var cars = db.Samochody.ToList();

            if (BrandComboBox1.SelectedItem != null)
            {
                cars = cars.Where(c => c.Marka == BrandComboBox1.SelectedItem.ToString()).ToList();
            }
            if (ModelComboBox1.SelectedItem != null)
            {
                cars = cars.Where(c => c.Model == ModelComboBox1.SelectedItem.ToString()).ToList();
            }

            CarLayout(cars);

        }
        private void ChooseCar_Load(object sender, EventArgs e)
        {
            var carDataList = db.Samochody
               .Select(c => new Samochody { Marka = c.Marka, Model = c.Model })
               .Distinct()
               .ToList();
            CarLayout(carDataList);
            BrandComboBox1.DataSource = db.Samochody.Select(c => c.Marka).Distinct().ToList();
        }
    }
}
