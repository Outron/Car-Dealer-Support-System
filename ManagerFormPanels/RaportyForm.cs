using CarDealerSupportSystem.ManagerFormPanels;
using CarDealerSupportSystem.Models;
using CarDealerSupportSystem.SellerFormPanels;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class RaportyForm : Form
    {
        private Statistics mainForm;
        public RaportyForm(Form mainF)
        {
            this.mainForm = mainF as Statistics;
            InitializeComponent();
        }

        // Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopLoginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // End Drag Form
        private void closeFormButton(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_click(object sender, EventArgs e)
        {
            using System.Windows.Forms.SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = "Pliki PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Zapisz jako plik PDF";
            DialogResult result = saveFileDialog.ShowDialog();

            Button baton = sender as Button;
            if (result == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                PdfCreator pdfCreator = new(fileName);
                if(baton.Tag.ToString() == "wtrakcie")
                    pdfCreator.GenerateRaport("wtrakcie", mainForm.id);
                else if(baton.Tag.ToString() == "zakonczone")
                    pdfCreator.GenerateRaport("zakonczone", mainForm.id);
            }
            else
            {
                MessageBox.Show("Problem z zapisem raportu");
            }
        }
    }
}
