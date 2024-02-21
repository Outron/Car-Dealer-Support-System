using CarDealerSupportSystem.Models;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class MakeOrderPanel : Form
    {

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Panel lastSelectedPanel;
        private SelectedCarInfo lastSelectedCarInfo;
        private Form currentChildForm;
        public int idPrac;
        private readonly salon_samochodowyContext db = new salon_samochodowyContext();

        public MakeOrderPanel(int id)
        {
            idPrac = id;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 50);
            LeftMenuPanel.Controls.Add(leftBorderBtn);
        }

 

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only one form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainCarPanel.Controls.Add(childForm);
            MainCarPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public class SelectedCarInfo
        {
            public string SelectedBrand { get; set; }
            public string SelectedModel { get; set; }
            public byte[]  SelectedImage { get; set; }
            public int SelectedCarId { get; set; }
        }


        private void ChooseCarPanel(List<Samochody> carData)
        {
            flowLayoutPanel1.Controls.Clear();


            foreach (var data in carData)
            {
                Panel panel = new Panel();
                panel.Size = new Size(350, 300);
                panel.BackColor = Color.FromArgb(43, 43, 43);
                panel.Margin = new Padding(5, 5, 5, 15);
                panel.Cursor = Cursors.Hand;
                var currentData = data; 
                panel.Click += (s, e) =>
                {   
                    TogglePanelSelection(panel,data);
                    NextButton.BackColor = Color.FromArgb(134, 2, 12);
                    NextButton.ForeColor = Color.White;

                    //show in console values of selected car
                    //Console.WriteLine(lastSelectedCarInfo.SelectedBrand);
                    //Console.WriteLine(lastSelectedCarInfo.SelectedModel);
                };

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(350, 220);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                // load image from database
               
                if (data.Zdjecie != null && data.Zdjecie.Length > 0)
                {
                    using (MemoryStream memoryStream = new MemoryStream(data.Zdjecie))
                    {
                        Image image = Image.FromStream(memoryStream);
                        pictureBox.Image = image;
                    }
                }

                Label brandLabel = new Label();
                brandLabel.Text = data.Marka;
                brandLabel.ForeColor = Color.White;
                brandLabel.Font = new Font("Segoe UI", 20);
                brandLabel.AutoSize = true;
                brandLabel.Dock = DockStyle.Bottom;
                brandLabel.Padding = new Padding(10, 0, 0, 0);

                Label modelLabel = new Label();
                modelLabel.Text = data.Model;
                modelLabel.ForeColor = Color.White;
                modelLabel.Font = new Font("Segoe UI", 15);
                modelLabel.AutoSize = true;
                modelLabel.Dock = DockStyle.Bottom;
                modelLabel.Padding = new Padding(13, 0, 0, 10);

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(brandLabel);
                panel.Controls.Add(modelLabel);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }


        private void TogglePanelSelection(Panel panel, Samochody carData)
        {
            if (lastSelectedPanel != null)
            {
                // if lastSelectedPanel is not null, then unselect it
                lastSelectedPanel.BorderStyle = BorderStyle.None;
            }

            // select new panel
            lastSelectedPanel = panel;
            panel.BorderStyle = BorderStyle.FixedSingle;

            // save selected car info
            lastSelectedCarInfo = new SelectedCarInfo
            {
                SelectedBrand = carData.Marka,
                SelectedModel = carData.Model,
                SelectedImage = carData.Zdjecie,
                SelectedCarId = carData.IdSamochodu
            };
        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(134, 2, 12);
        }


        public void ActivateButton(object butt, Color color)
        {
            if (butt != null)
            {
                //Button
                currentBtn = (Button)butt;
                currentBtn.BackColor = Color.FromArgb(51, 51, 51);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }


        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(42, 42, 42);
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MakeOrderPanel.ActiveForm.Close();
        }


        private void MakeOrderPanel_Load(object sender, EventArgs e)
        {
            var idSalon = (from salon in db.Salony
                        join pracownik in db.Pracownicy
                        on salon.IdSalonu equals pracownik.IdSalonu
                        where pracownik.IdPracownika == idPrac
                        select salon.IdSalonu).ToList().FirstOrDefault();

            var carDataList = db.Samochody.Where(s=>s.IdSalonu==idSalon && s.Dostepnosc == "dostepny")
                .Select(c => new Samochody { Marka = c.Marka, Model = c.Model, Zdjecie = c.Zdjecie, IdSamochodu = c.IdSamochodu})
                .Distinct()
                .ToList();

            ChooseCarPanel(carDataList);
            BrandComboBox.DataSource = db.Samochody.Select(c => c.Marka).Distinct().ToList();
            ActivateButton(ChooseCarButton, RGBColors.color1);
            var additionalServices = db.Uslugi.Select(s => s.Nazwa).ToList();
         
        }
       

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BrandComboBox.SelectedItem != null)
            {
                ModelComboBox.DataSource = db.Samochody.Where(c => c.Marka == BrandComboBox.SelectedItem.ToString()).Select(c => c.Model).Distinct().ToList();
            }
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {
            NextButton.BackColor = Color.FromArgb(32,30,30) ;
            NextButton.ForeColor = Color.FromArgb(50, 50, 50);
            var cars = db.Samochody.ToList();

            if (BrandComboBox.SelectedItem != null)
            {
                cars = cars.Where(c => c.Marka == BrandComboBox.SelectedItem.ToString()).ToList();
            }
            if (ModelComboBox.SelectedItem != null)
            {
                cars = cars.Where(c => c.Model == ModelComboBox.SelectedItem.ToString()).ToList();
            }
            ChooseCarPanel(cars);
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
           if (lastSelectedCarInfo != null)
            {
                OpenChildForm(new CarConfigurator(lastSelectedCarInfo));
                panel2.Visible = false;
                DisableButton();
                ActivateButton(ConfigurationButton, RGBColors.color1);
                TopLabel.Text = "Konfiguracja samochodu";
            }
        }
        
    }
}



