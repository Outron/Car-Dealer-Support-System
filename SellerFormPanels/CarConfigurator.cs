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
    public partial class CarConfigurator : Form
    {
        private readonly SelectedCarInfo selectedCarInfo;
        public CarConfigurator(SelectedCarInfo selectedCarInfo)
        {
            InitializeComponent();
            this.selectedCarInfo = selectedCarInfo;
        }

        private void CarConfigurator_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Selected Brand: " + selectedCarInfo.SelectedBrand);
            Console.WriteLine("Selected Model: " + selectedCarInfo.SelectedModel);
        }

    }
}
