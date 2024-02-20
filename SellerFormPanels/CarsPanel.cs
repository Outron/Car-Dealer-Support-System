using CarDealerSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class CarsPanel : Form
    {

        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        private readonly Color gridDefaultCellStyle;
        public readonly int id;
        public CarsPanel(int i)
        {
            id = i;
            InitializeComponent();
            gridDefaultCellStyle = CarsGridView.DefaultCellStyle.BackColor;
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void CarsPanel_Load_1(object sender, EventArgs e)
        {
        var query = (from salon in db.Salony
                        join pracownik in db.Pracownicy
                        on salon.IdSalonu equals pracownik.IdSalonu
                        where pracownik.IdPracownika == id
                        select salon.IdSalonu).ToList().FirstOrDefault();

            var cars = db.Samochody.Where(sam=>sam.Dostepnosc == "tak" || sam.Dostepnosc == "dostepny").Where(d=>d.IdSalonu == query).ToList();
            foreach (Samochody car in cars)
            {
                if (car.Zdjecie == null)
                {
                    car.Zdjecie = ImageToByteArray(Properties.Resources.car);
                }
            }
            CarsGridView.DataSource = cars;
            BrandComboBox.DataSource = cars.Select(c => c.Marka).Distinct().ToList();
            ModelComboBox.DataSource = cars.Select(c => c.Model).Distinct().ToList();
            EngineComboBox.DataSource = cars.Select(c => c.TypSilnika).Distinct().ToList();
            BodyComboBox.DataSource = cars.Select(c => c.TypNadwozia).Distinct().ToList();
            ColorComboBox.DataSource = cars.Select(c => c.Kolor).Distinct().ToList();
            DoorsComboBox.DataSource = cars.Select(c => c.LiczbaDrzwi).Distinct().ToList();
            
        }

      
        private void SearchCarsTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchValue = SearchCarsTextBox.Text.ToLower();
            var cars = db.Samochody.Where(c =>c.Marka.ToLower().Contains(searchValue) 
            || c.Model.ToLower().Contains(searchValue) || c.Kolor.ToLower().Contains(searchValue) 
            || c.TypNadwozia.ToLower().Contains(searchValue) 
            || c.TypSilnika.ToLower().Contains(searchValue)).ToList();

            CarsGridView.DataSource = cars;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(CarsFilterPanel.Visible)
            {
                CarsFilterPanel.Hide();
                CarsGridView.Location = new Point(0, 38);
            }
            else
            {
                CarsFilterPanel.Show();
                CarsGridView.Location = new Point(0, 144);
            }
        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BrandComboBox.SelectedItem != null)
            { 
                ModelComboBox.DataSource = db.Samochody.Where(c => c.Marka == BrandComboBox.SelectedItem.ToString()).Select(c => c.Model).Distinct().ToList();
            }
        }

        private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ModelComboBox.SelectedItem != null)
            {
                BodyComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.TypNadwozia).Distinct().ToList();
                EngineComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.TypSilnika).Distinct().ToList();
                DoorsComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.LiczbaDrzwi).Distinct().ToList();
                ColorComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.Kolor).Distinct().ToList();
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
            if (BodyComboBox.SelectedItem != null)
            {
                cars = cars.Where(c => c.TypNadwozia == BodyComboBox.SelectedItem.ToString()).ToList();
            }
            if (EngineComboBox.SelectedItem != null)
            {
                cars = cars.Where(c => c.TypSilnika == EngineComboBox.SelectedItem.ToString()).ToList();
            }
            if (ColorComboBox.SelectedItem != null)
            {
                cars = cars.Where(c => c.Kolor == ColorComboBox.SelectedItem.ToString()).ToList();
            }
            if (MinPriceTextBox.Text != "")
            {
                cars = cars.Where(c => c.CenaPodstawowa >= Convert.ToDouble(MinPriceTextBox.Text)).ToList();
            }
            if (MaxPriceTextBox.Text != "")
            {
                cars = cars.Where(c => c.CenaPodstawowa <= Convert.ToDouble(MaxPriceTextBox.Text)).ToList();
            }
            if(MinPowerTextBox.Text != "")
            {
                cars = cars.Where(c => c.MocSilnika >= Convert.ToInt16(MinPowerTextBox.Text)).ToList();
            }
            if (MaxPowerTextBox.Text != "")
            {
                cars = cars.Where(c => c.MocSilnika <= Convert.ToInt16(MaxPowerTextBox.Text)).ToList();
            }
            
            CarsGridView.DataSource = cars;
            CarsFilterPanel.Hide();
            CarsGridView.Location = new Point(0, 38);
        }

        private void CarSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CarSortComboBox.SelectedItem != null)
            {

                if (CarSortComboBox.SelectedItem.ToString() == "Cena rosnąco")
                {
                    var cars = db.Samochody.OrderBy(c => c.CenaPodstawowa).ToList();
                    CarsGridView.DataSource = cars;
                }

                if (CarSortComboBox.SelectedItem.ToString() == "Cena malejąco")
                {
                    var cars = db.Samochody.OrderByDescending(c => c.CenaPodstawowa).ToList();
                    CarsGridView.DataSource = cars;
                }
            }
        }

        private void CarsGridView_SelectionChanged(object sender, EventArgs e)
        {
            CarsGridView.ClearSelection();
        }

        private void CarsGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CarsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void CarsGridView_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CarsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = gridDefaultCellStyle;
            }
        }
    }
}

