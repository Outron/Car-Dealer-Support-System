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

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class AdmMainPanel : Form
    {
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();

        public AdmMainPanel()
        {
            InitializeComponent();
        }

       
    }
}

