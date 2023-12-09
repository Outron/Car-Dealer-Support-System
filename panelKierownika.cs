using CarDealerSupportSystem.paneleKierownika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
   

    public partial class panelKierownika : Form
    {
        public panelKierownika()
        {
            InitializeComponent();
        }

        private void panelKierownika_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        public void loadChildForm(object form)
        {
            if(this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadChildForm(new pSzukaj());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadChildForm(new pSamochody());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadChildForm(new pSzukaj());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadChildForm(new pKlienci());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadChildForm(new pStatystyki());
        }
    }
}
