extern alias mysqldata;

using CarDealerSupportSystem.Models;
using Microsoft.EntityFrameworkCore;
using mysqldata::MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarDealerSupportSystem.SellerFormPanels.MakeOrderPanel;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class OrderSummary : Form
    {
        //dictionary with all the data from the form
        Dictionary<string, string> clientData = new Dictionary<string, string>();
        List<string> selectedServices;
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();
        private readonly SelectedCarInfo selectedCarInfo;
        public OrderSummary(Dictionary<string, string> clientData, List<string> selectedServices, SelectedCarInfo selectedCarInfo)
        {
            InitializeComponent();
            this.clientData = clientData;
            this.selectedServices = selectedServices;
            this.selectedCarInfo = selectedCarInfo;
        }
        // write a method that checks type of sell if it has some selected services its auto+service if not its zakupauta 
        private string CheckTypeOfSell()
        {
            if (selectedServices.Count == 0)
            {
                Console.WriteLine("ZakupAuta");
                return "ZakupAuta";
                
            }
            else
            {
                Console.WriteLine("Auto+Uslugi");
                return "Auto+Uslugi";
            }
        }
        // write a method that checks if client data is already in the database
        private bool CheckIfClientExists()
        {
            var client = db.Klienci.Where(k => k.Imie == clientData["NameLabel"] && k.Nazwisko == clientData["SurnameLabel"] && k.Email == clientData["EmailLabel"] && k.Telefon == clientData["PhoneLabel"]).FirstOrDefault();
            if (client == null)
            {
                return false;
            }
            else
            {   
                return true;
            }
        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            Label[] Clientlabels = { NameLabel, SurnameLabel, EmailLabel, PhoneLabel, CityLabel, AddressLabel, PostcodeLabel, PeselLabel, PaymentLabel };
            
            //fill the labels with the data from the dictionary
            for (int i = 0; i < Clientlabels.Length; i++)
            {
                
                if (clientData.ContainsKey(Clientlabels[i].Name))
                {
                    Clientlabels[i].Text = clientData[Clientlabels[i].Name];
                }
                else
                {
                    Clientlabels[i].Text = "Brak danych";
                }
            }

            //fill car labels with the data from the selectedCarInfo object
            BrandLabel.Text = selectedCarInfo.SelectedBrand;
            ModelLabel.Text = selectedCarInfo.SelectedModel;
            ColorLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.Kolor).FirstOrDefault();
            EngineLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.TypSilnika).FirstOrDefault();
            PowerLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.MocSilnika).FirstOrDefault().ToString() + "KM";
            PriceLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.CenaPodstawowa).FirstOrDefault().ToString();
            FuelLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.SrednieSpalanie).FirstOrDefault().ToString() + "l/100km";
            BodyLabel.Text = db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.TypNadwozia).FirstOrDefault();


            int service_price;
            int price = int.Parse(PriceLabel.Text);
            if (clientData["Discount"] == "" || clientData["Discount"] == "0")
            {
                PriceLabel.Text = price.ToString();
            }
            else
            {
                int discount = int.Parse(clientData["Discount"]);
                price = price - (price * discount / 100);
            }

            //check if some services were selected
            if (selectedServices.Count == 0)
            {
                PriceLabel.Text = price.ToString();
            }
            else
            {
                foreach (var service in selectedServices)
                {
                    service_price = (int)db.Uslugi.Where(s => s.Nazwa == service).Select(s => s.CenaUslugi).FirstOrDefault();
                    price = price - service_price;
                }
                PriceLabel.Text = price.ToString();
            }
        
            foreach (var service in selectedServices)
            {
                AddedServicesLabel.Text += service + "\n";
            }
            


            ///////////////////////////////////////////////////////////////////////////////////////
            // CHECK IF THE DATA IS CORRECT
            foreach (KeyValuePair<string, string> kvp in clientData)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            foreach (var service in selectedServices)
            {
                Console.WriteLine("Selected service: " + service);
            }                                                                                    //
            ///////////////////////////////////////////////////////////////////////////////////////
        }
         // write a method that adds client to the database and returns id of the client
        private int AddClientToDatabase()
        {
            var client = new Klienci
            {
                IdKlienta = db.Klienci.Max(k => k.IdKlienta) + 1,
                Imie = clientData["NameLabel"],
                Nazwisko = clientData["SurnameLabel"],
                Email = clientData["EmailLabel"],
                Telefon = clientData["PhoneLabel"],
                Adres = clientData["CityLabel"] + " " + clientData["AddressLabel"],
            };
            db.Klienci.Add(client);
            db.SaveChanges();
            return client.IdKlienta;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            int id = ((SellerPanel)Application.OpenForms["SellerPanel"]).id;
            int ClientID = 0;
            string TypeOfSell = CheckTypeOfSell();

            if (CheckIfClientExists() == false)
            {
                ClientID = AddClientToDatabase();
            }
            else
            {
                ClientID = db.Klienci.Where(k => k.Imie == clientData["NameLabel"] && k.Nazwisko == clientData["SurnameLabel"] && k.Telefon == clientData["PhoneLabel"]).Select(k => k.IdKlienta).FirstOrDefault();
            }


            var order = new Zamowienia
            {   
                IdZamowienia = db.Zamowienia.Max(z => z.IdZamowienia) + 1,
                IdKlienta = ClientID,
                IdPracownika = id,
                RodzajPlatnosci = clientData["PaymentLabel"],
                TypZamowienia = TypeOfSell,
                Data = DateTime.Now,
                CalkowityKoszt = int.Parse(PriceLabel.Text),
                Status = "Wolne"
            };
            db.Zamowienia.Add(order);
            db.SaveChanges();

           
            if (TypeOfSell == "Auto+Uslugi")
            {   
                for (int i = 0; i < selectedServices.Count; i++)
                {
                    db.Database.ExecuteSqlRaw("INSERT INTO zamowienia_samochody_uslugi values('" + db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.IdSamochodu).FirstOrDefault() + "', '" + db.Uslugi.Where(u => u.Nazwa == selectedServices[i]).Select(u => u.IdUslugi).FirstOrDefault() + "', '" + order.IdZamowienia + "', NULL, 'wolne')");
                    db.SaveChanges();
                }
            }
            else if (TypeOfSell == "ZakupAuta")
            {
                db.Database.ExecuteSqlRaw("INSERT INTO zamowienia_samochody_uslugi values('" + db.Samochody.Where(s => s.Marka == selectedCarInfo.SelectedBrand && s.Model == selectedCarInfo.SelectedModel).Select(s => s.IdSamochodu).FirstOrDefault() + "', NULL, '" + order.IdZamowienia + "', NULL, 'zakonczone')");
                db.SaveChanges();
            }

           
            

            MessageBox.Show("Zamówienie zostało dodane pomyślnie!");
            //close the form and makeorderpanel
            this.Close();
            var mainForm = Application.OpenForms.OfType<MakeOrderPanel>().Single();
            mainForm.Close();
        }
    }
}
