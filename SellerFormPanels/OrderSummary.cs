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

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            Label[] Clientlabels = { NameLabel, SurnameLabel, EmailLabel, PhoneLabel, CityLabel, AddressLabel, PostcodeLabel, PeselLabel, PaymentLabel };
            Label[] Carlabels = { BrandLabel, ModelLabel, ColorLabel, EngineLabel, PowerLabel, PriceLabel, FuelLabel, BodyLabel };
            //fill the labels with the data from the dictionary
            for (int i = 0; i < Clientlabels.Length; i++)
            {   
                //add email validation
                if (clientData.ContainsKey(Clientlabels[i].Name))
                {
                    // Przypisz wartość ze słownika do etykiety o odpowiadającym indeksie
                    Clientlabels[i].Text = clientData[Clientlabels[i].Name];
                }
                else
                {
                    // Jeśli klucz nie istnieje w słowniku, możesz ustawić tekst etykiety na pusty ciąg lub inny tekst ostrzegawczy
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


            // change pricelabel text to int 
            // multiply price by discount from the clientData dictionary and set the text of the label to the new price
            int price = int.Parse(PriceLabel.Text);
            int discount = int.Parse(clientData["Discount"]);
            price = price - (price * discount / 100);
            PriceLabel.Text = price.ToString();

            //fill the AdditionalServicesLabel with the selected services from the list
            foreach (var service in selectedServices)
            {
                AddedServicesLabel.Text += service + ", \n";
            }
            
           
            
    
           
           

            

            
                

            foreach (KeyValuePair<string, string> kvp in clientData)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            foreach (var service in selectedServices)
            {
                Console.WriteLine("Selected service: " + service);
            }
        }

        private void PostcodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
