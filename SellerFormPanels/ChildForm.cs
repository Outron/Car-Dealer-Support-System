using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    internal interface ChildForm
    {

        public void OpenChildForm(Form childForm, Panel containerPanel)
        {
            
            if (currentChildForm != null)
            {
                // Open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(childForm);
            containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
