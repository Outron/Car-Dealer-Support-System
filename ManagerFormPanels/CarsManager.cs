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

namespace CarDealerSupportSystem.ManagerFormPanels
{
    public partial class CarsManager : Form
    {

        private readonly salon_samochodowyContext db = new salon_samochodowyContext();

        public CarsManager()
        {
            InitializeComponent();
        }

        private void CarsManager_Load_1(object sender, EventArgs e)
        {
            var cars = db.Samochody.ToList();
            CarsGridView.DataSource = cars;
            //BrandComboBox.DataSource = db.Samochody.Select(c => c.Marka).Distinct().ToList();
            //ModelComboBox.DataSource = db.Samochody.Select(c => c.Model).Distinct().ToList();
            //EngineComboBox.DataSource = db.Samochody.Select(c => c.TypSilnika).Distinct().ToList();
            //BodyComboBox.DataSource = db.Samochody.Select(c => c.TypNadwozia).Distinct().ToList();
            //ColorComboBox.DataSource = db.Samochody.Select(c => c.Kolor).Distinct().ToList();
            //DoorsComboBox.DataSource = db.Samochody.Select(c => c.LiczbaDrzwi).Distinct().ToList();

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

        

      

        //private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(ModelComboBox.SelectedItem != null)
        //    {
        //        BodyComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.TypNadwozia).Distinct().ToList();
        //        EngineComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.TypSilnika).Distinct().ToList();
        //        DoorsComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.LiczbaDrzwi).Distinct().ToList();
        //        ColorComboBox.DataSource = db.Samochody.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).Select(c => c.Kolor).Distinct().ToList();
        //    }

        //}

        
        private void CarSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CarSortComboBox.SelectedItem != null)
            {

                if (CarSortComboBox.SelectedItem == "Cena rosnąco")
                {
                    var cars = db.Samochody.OrderBy(c => c.CenaPodstawowa).ToList();
                    CarsGridView.DataSource = cars;
                }

                if (CarSortComboBox.SelectedItem == "Cena malejąco")
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCarsForm addCarsForm = new AddCarsForm(this);   
            addCarsForm.ShowDialog();
        }
    }
}

