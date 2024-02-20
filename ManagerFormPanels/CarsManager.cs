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

namespace CarDealerSupportSystem.ManagerFormPanels
{
    public partial class CarsManager : Form
    {

        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        private readonly Color gridDefaultCellStyle;
        public readonly int id;
        public int idSalonu;

        public CarsManager(int i)
        {
            InitializeComponent();
            gridDefaultCellStyle = CarsGridView.DefaultCellStyle.BackColor;
            this.id= i;
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void CarsManager_Load(object sender, EventArgs e)
        {
            idSalonu = (from salon in db.Salony
                        join pracownik in db.Pracownicy
                        on salon.IdSalonu equals pracownik.IdSalonu
                        where pracownik.IdPracownika == id
                        select salon.IdSalonu).ToList().FirstOrDefault();

            var cars = db.Samochody.Where(sam=>sam.Dostepnosc == "tak" || sam.Dostepnosc == "dostepny").Where(d=>d.IdSalonu == idSalonu).ToList();
            foreach (Samochody car in cars)
            {
                if (car.Zdjecie == null)
                {
                    car.Zdjecie = ImageToByteArray(Properties.Resources.car);
                }
            }
            CarsGridView.DataSource = cars;
        }


        private void SearchCarsTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchValue = SearchCarsTextBox.Text.ToLower();
            var carsRight = db.Samochody.Where(sam => sam.Dostepnosc == "tak" || sam.Dostepnosc == "dostepny").Where(d => d.IdSalonu == idSalonu).ToList();
            var cars = carsRight.Where(c =>c.Marka.ToLower().Contains(searchValue) 
            || c.Model.ToLower().Contains(searchValue) || c.Kolor.ToLower().Contains(searchValue) 
            || c.TypNadwozia.ToLower().Contains(searchValue) 
            || c.TypSilnika.ToLower().Contains(searchValue) && (c.Dostepnosc == "tak" || c.Dostepnosc == "dostepny")).Select(s => new {s.IdSamochodu, s.Zdjecie, s.Marka, s.Model, s.TypNadwozia, s.Kolor, s.CenaPodstawowa }).ToList();



            CarsGridView.DataSource = cars;
        }

        
        private void CarSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CarSortComboBox.SelectedItem != null)
            {
                var carsRight = db.Samochody.Where(sam => sam.Dostepnosc == "tak" || sam.Dostepnosc == "dostepny").Where(d => d.IdSalonu == idSalonu).ToList();

                if (CarSortComboBox.SelectedItem.ToString() == "Cena rosnąco")
                {
                    var cars = carsRight.OrderBy(c => c.CenaPodstawowa).ToList();
                    CarsGridView.DataSource = cars;
                }

                if (CarSortComboBox.SelectedItem.ToString() == "Cena malejąco")
                {
                    var cars = carsRight.OrderByDescending(c => c.CenaPodstawowa).ToList();
                    CarsGridView.DataSource = cars;
                }
            }
        }

        private void CarsGridView_SelectionChanged(object sender, EventArgs e) //morzliwy do naprawienia blad
        {
            CarsGridView.ClearSelection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCarsForm addCarsForm = new AddCarsForm(this);   
            addCarsForm.ShowDialog();
        }

        private void CarsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 15 && e.RowIndex != -1)
            {
                var idSamochod = (from samochod in db.Samochody
                                  where samochod.IdSamochodu == int.Parse(CarsGridView.Rows[e.RowIndex].Cells[0].Value.ToString())
                                  select samochod.IdSamochodu).ToList().FirstOrDefault();
                EditCarsForm editForm = new EditCarsForm(this, idSamochod);
                editForm.ShowDialog();

            }
        }
    }
}

