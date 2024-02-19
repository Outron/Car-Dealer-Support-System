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
    public partial class ClientOrderData : Form
    {   
        //list of selected services from the previous form
        private List<string> selectedServices;
        private readonly SelectedCarInfo selectedCarInfo;
        public ClientOrderData(List<string> selectedServices, SelectedCarInfo selectedCarInfo)
        {
            InitializeComponent();
            this.selectedServices = selectedServices;
            this.selectedCarInfo = selectedCarInfo;
        }


        //dictionary with all the data from the form
        Dictionary<string, string> clientData = new Dictionary<string, string>();

        // create function that checks validation of textboxes phone pesel and email and returns bool
        private bool ValidateTextBoxes()
        {
            if (NameLabel.Text != "" && SurnameLabel.Text != "" && CityLabel.Text != "" && AddressLabel.Text != "" && PostcodeLabel.Text != "" && PaymentLabel.Text != "" && EmailLabel.Text != "" && PhoneLabel.Text != "" && PeselLabel.Text != "")
            {
                return true;
            }
            else
            {
                MessageLabel.Text = "Wypełnij wszystkie pola";

                if (PhoneLabel.Text.Length != 9)
                {
                    MessageLabel.Text = "Numer telefonu musi składać się z 9 cyfr";
                    return false;
                }
                if (PeselLabel.Text.Length != 11)
                {
                    MessageLabel.Text = "Numer PESEL musi składać się z 11 cyfr";
                    return false;
                }
                if (!EmailLabel.Text.Contains("@"))
                {
                    MessageLabel.Text = "Niepoprawny adres email";
                    return false;
                }

                return false;
            }
          
        }
       
       
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(ValidateTextBoxes())
            {
                clientData.Add(NameLabel.Name, NameLabel.Text);
                clientData.Add(SurnameLabel.Name, SurnameLabel.Text);
                clientData.Add(CityLabel.Name, CityLabel.Text);
                clientData.Add(AddressLabel.Name, AddressLabel.Text);
                clientData.Add(PostcodeLabel.Name, PostcodeLabel.Text);
                clientData.Add(PaymentLabel.Name, PaymentLabel.Text);
                clientData.Add("Discount", Discount.Text);
                clientData.Add(EmailLabel.Name, EmailLabel.Text);
                clientData.Add(PhoneLabel.Name, PhoneLabel.Text);
                clientData.Add(PeselLabel.Name, PeselLabel.Text);
            }
            else
            {
                return;
            }

            this.Close();
            var mainForm = Application.OpenForms.OfType<MakeOrderPanel>().Single();
            mainForm.OpenChildForm(new OrderSummary(clientData, selectedServices, selectedCarInfo));
            mainForm.DisableButton();
            mainForm.ActivateButton(mainForm.SummaryButton, Color.FromArgb(134, 2, 12));
            mainForm.TopLabel.Text = "Podsumowanie zamówienia";
        }

                
    }
         
 }
