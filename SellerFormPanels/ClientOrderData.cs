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

        // create function that checks validation of textboxes phone if it contains only 9 numbers
       
 
        private void NextButton_Click(object sender, EventArgs e)
        {
            bool isFilled = false;
            //get all data from textboxes and add them to the dictionary
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        MessageLabel.Text = "Wypełnij wszystkie pola!";
                        isFilled = false;
                        break;
                    }
                    else
                    {
                        clientData.Add(control.Name, control.Text);
                        isFilled = true;
                    }
                }
            }
            if (isFilled == true)
            {   
                // add option from payment combobox to the dictionary
                if (PaymentLabel.SelectedItem != null)
                {
                    clientData.Add("PaymentLabel", PaymentLabel.SelectedItem.ToString());
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
}
