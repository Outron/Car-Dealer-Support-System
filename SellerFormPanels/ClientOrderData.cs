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
    public partial class ClientOrderData : Form
    {
        public ClientOrderData()
        {
            InitializeComponent();
          
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (NameLabel.Text != "" && SurnameLabel.Text != "" && EmailLabel.Text != "" && PhoneLabel.Text != "" && AddressLabel.Text != "" && CityLabel.Text != "" && CodeLabel.Text != "" && PeselLabel.Text != "")
            {
            // open the next form
            }
            else
            {
                MessageLabel.Text = "Wypełnij wszystkie pola!";
            }
          
        }
    }
}
