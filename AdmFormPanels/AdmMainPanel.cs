using CarDealerSupportSystem.Models;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class AdmMainPanel : Form
    {
        private readonly salon_samochodowyContext db = new();

        public AdmMainPanel()
        {
            InitializeComponent();
        }

    }
}

