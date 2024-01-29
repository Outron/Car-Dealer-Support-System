﻿using CarDealerSupportSystem.Models;
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
using static CarDealerSupportSystem.SellerFormPanels.CarConfigurator;

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

            //fill the list of additional services from the database and add them to the listbox on the form 
            var services = db.Uslugi.ToList();
            foreach (var service in services)
            {
                AddServices.Items.Add(service.Nazwa);
            }
   
        }

       
 

        private void NextButton_Click(object sender, EventArgs e)
        {   
            this.Close();
            var mainForm = Application.OpenForms.OfType<MakeOrderPanel>().Single();
            mainForm.OpenChildForm(new ClientOrderData());
            mainForm.DisableButton();
            mainForm.ActivateButton(mainForm.ClientData, Color.FromArgb(134, 2, 12));
            // change the label on the top of the form
            mainForm.TopLabel.Text = "Dane klienta";
        }

        private void AddServices_Click(object sender, EventArgs e)
        {

        }
    }
}
