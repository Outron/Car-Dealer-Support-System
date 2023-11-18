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
    public partial class CarsPanel : Form
    {

        private salon_samochodowyContext db = new salon_samochodowyContext();

        public CarsPanel()
        {
            InitializeComponent();
        }

        private void CarsPanel_Load_1(object sender, EventArgs e)
        {
            var cars = db.Samochody.ToList();
            CarsGridView.DataSource = cars;
            PriceComboBox.DataSource = db.Samochody.Select(c => c.CenaPodstawowa).Distinct().ToList();
            BrandComboBox.DataSource = db.Samochody.Select(c => c.Marka).Distinct().ToList();
            ModelComboBox.DataSource = db.Samochody.Select(c => c.Model).Distinct().ToList();
            EngineComboBox.DataSource = db.Samochody.Select(c => c.TypSilnika).Distinct().ToList();
            BodyComboBox.DataSource = db.Samochody.Select(c => c.TypNadwozia).Distinct().ToList();
            ColorComboBox.DataSource = db.Samochody.Select(c => c.Kolor).Distinct().ToList();
            PowerComboBox.DataSource = db.Samochody.Select(c => c.MocSilnika).Distinct().ToList();
        }

      
        private void SearchCarsTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchValue = SearchCarsTextBox.Text.ToLower();
            var cars = db.Samochody.Where(c =>c.Marka.ToLower().Contains(searchValue) 
            || c.Model.ToLower().Contains(searchValue) || c.Kolor.ToLower().Contains(searchValue) 
            || c.TypNadwozia.ToLower().Contains(searchValue) 
            || c.TypSilnika.ToLower().Contains(searchValue) 
            || c.CenaPodstawowa.ToString().ToLower().Contains(searchValue)).ToList();

            CarsGridView.DataSource = cars;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(CarsFilterPanel.Visible)
            {
                CarsFilterPanel.Hide();
            }
            else
            {
                CarsFilterPanel.Show();
            }
        }

       
        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BrandComboBox.SelectedItem != null)
            { 
                ModelComboBox.DataSource = db.Samochody.Where(c => c.Marka == BrandComboBox.SelectedItem.ToString()).Select(c => c.Model).Distinct().ToList();
            }
    }
       

    }
}

