using System;
using CarDealerSupportSystem.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Internal;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Net.Mime.MediaTypeNames;

namespace CarDealerSupportSystem.ManagerFormPanels
{

    public partial class EditCarsForm : Form
    {
        private CarsManager mainform;
        private salon_samochodowyContext db = new salon_samochodowyContext();
        private string currTextBox;
        private readonly int carId;
        private int errorCount;
        private int idSalonu;

        public EditCarsForm(Form f, int id)
        {
            InitializeComponent();
            currTextBox = "";
            mainform = f as CarsManager;
            carId = id;
        }
        public EditCarsForm()
        {
            InitializeComponent();
        }
        // Convert an object to a byte array
        public static byte[] ObjectToByteArray(Object obj)
        {
            return (byte[])obj;   
        }
        public System.Drawing.Image ByteArrayToBitmap(byte[] imageIn)
        {
            ImageConverter converter = new ImageConverter();
            return (System.Drawing.Image)converter.ConvertFrom(imageIn);
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private class samochody
        {
            public byte[] zdjecie { get; set; }
            public string model { get; set; }
            public string marka { get; set; }
            public string kolor { get; set; }
            public string typnadwozia { get; set; }
            public string mocsilnika { get; set; }
            public string wyposazenie { get; set; }
            public string sredniespalanie { get; set; }
            public string typsilnika { get; set; }
            public string cenapodstawowa { get; set; }
            public string liczbadrzwi { get; set; }
            public string liczbamiejsc { get; set; }
            public string vin { get; set; }
            public string rabat { get; set; }
            public string idsalonu { get; set; }
            public string dostepnosc { get; set; }
            public string rokprodukcji { get; set; }
            public samochody(Samochody cell)
            {
                //int i = 0;
                zdjecie= cell.Zdjecie;
                model = cell.Model;
                marka = cell.Marka;
                typnadwozia = cell.TypNadwozia;
                cenapodstawowa = cell.CenaPodstawowa.ToString();
                vin= cell.Vin;
                kolor= cell.Kolor;
                mocsilnika = cell.MocSilnika.ToString();
                wyposazenie= cell.Wyposazenie;
                sredniespalanie = cell.SrednieSpalanie.ToString();
                typsilnika= cell.TypSilnika;
                liczbadrzwi= cell.LiczbaDrzwi.ToString();
                liczbamiejsc= cell.IloscMiejsc.ToString();
                rabat= null;
                rokprodukcji= cell.RokProdukcji.ToString();
            }
        }
        private void EditCarsForm_Load(object sender, EventArgs e)
        {
            var idSalonu = (from salon in db.Salony
                         join pracownik in db.Pracownicy
                         on salon.IdSalonu equals pracownik.IdSalonu
                         where pracownik.IdPracownika == mainform.id
                         select salon.IdSalonu).ToList().FirstOrDefault();

            var car = (from samochod in db.Samochody
                       where samochod.IdSamochodu == carId
                       select samochod).ToList().FirstOrDefault();
            if (car == null)
            {
                MessageBox.Show("Wybrany samochod juz nie istnieje");
                return;
            }
            samochody sam = new samochody(car);
            TextBoxFill(sam);
            AddCarsBigLabel1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TextBoxFill(samochody s)
        {
            TextBcena.Text = s.cenapodstawowa.ToString();
            TextBkolor.Text= s.kolor;
            TextBliczbaDrz.Text= s.liczbadrzwi.ToString();
            TextBliczbaM.Text= s.liczbamiejsc.ToString();
            TextBmarka.Text= s.marka;
            TextBmocSil.Text= s.mocsilnika.ToString();
            TextBmodel.Text= s.model;
            //TextBrabat.Text= s.rabat.ToString();
            TextBrokProd.Text= s.rokprodukcji.ToString();
            TextBsredSpala.Text= s.sredniespalanie.ToString();
            TextBtypNadw.Text= s.typnadwozia;
            TextBtypSil.Text= s.typsilnika;
            TextBvin.Text= s.vin;
            TextBwyposaz.Text= s.wyposazenie;
            if(s.zdjecie!=null)
                picBoxImg.BackgroundImage = ByteArrayToBitmap(s.zdjecie);
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
        private readonly string[] placeholders =
        {
            " Cena"," Kolor"," Liczba drzwi"," Liczba miejsc"," Marka"," Moc Silnika"," Model", " Rabat %", " Rok produkcji", " Średnie spalanie", " Typ nadwozia", " Typ silnika", " VIN", " Wyposażenie"
        };
        private void TextBsredSpala_Enter(object sender, EventArgs e)
        {
            var TextBox = sender as TextBox;
            currTextBox = TextBox.Name.ToString();
            if (placeholders.Contains(TextBox.Text))
            {
             
                TextBox.Text = "";
                TextBox.ForeColor = Color.Silver;
            }
        }

        private void TextBsredSpala_Leave(object sender, EventArgs e)
        {
            var TextBox = sender as TextBox;
            currTextBox = "";
            if (TextBox.Text == "")
            {
                TextBox.Text = (string)TextBox.Tag;
                TextBox.ForeColor = Color.Gray;
            }
        }

        private void EditCarsForm_Click(object sender, EventArgs e)
        {
            if(currTextBox != "" && !(sender is TextBox))
            {
                var tBox = this.Controls.Find(currTextBox, true).FirstOrDefault() as TextBox;
                
                
                    this.AddCarsBigLabel1.Select();
                
            }
        }

        //Validating metody wszystkie

        private void TextBString_Validating(object sender, CancelEventArgs e)
        {
            var textB = sender as TextBox;
            if (string.IsNullOrEmpty(textB.Text) || textB.Text == textB.Tag.ToString())
            {
                errorProvider1.SetError(textB, "Nie wpisano poprawnej" + textB.Tag);
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textB, null);
            }
        }
        private void TextBInt_Validating(object sender, CancelEventArgs e)
        {
            var textB = sender as TextBox;
            int isNumeric = 1;
            int.TryParse(textB.Text, out isNumeric);
            if (textB.Text == textB.Tag.ToString() || string.IsNullOrEmpty(textB.Text) || isNumeric is 0)
            {
                errorProvider1.SetError(textB, "Nie wpisano poprawnej" + textB.Tag);
                errorCount++;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textB, null);
            }
        }
        private void OkCarButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && errorCount == 0)
            {
                var carUpdate = db.Samochody.FirstOrDefault(car => car.IdSamochodu == carId);
                if(carUpdate != null)
                {
                    carUpdate.IdSamochodu = carId;
                    carUpdate.Zdjecie = ImageToByteArray(this.picBoxImg.BackgroundImage);
                    carUpdate.Model = TextBmodel.Text;
                    carUpdate.Marka = TextBmarka.Text;
                    carUpdate.Kolor = TextBkolor.Text;
                    carUpdate.TypNadwozia = TextBtypNadw.Text;
                    carUpdate.MocSilnika = int.Parse(TextBmocSil.Text);

                    if(TextBwyposaz.Text == "Wyposażenie ")
                        carUpdate.Wyposazenie = "";
                    else
                        carUpdate.Wyposazenie = TextBwyposaz.Text;

                    carUpdate.SrednieSpalanie = int.Parse(TextBsredSpala.Text);
                    carUpdate.TypSilnika = TextBtypSil.Text;
                    carUpdate.CenaPodstawowa = int.Parse(TextBcena.Text);
                    carUpdate.LiczbaDrzwi = int.Parse(TextBliczbaDrz.Text);
                    carUpdate.IloscMiejsc = int.Parse(TextBliczbaM.Text);
                    carUpdate.Vin= TextBvin.Text;
                    //carUpdate.Rabat = int.Parse(TextBrabat.Text);
                    carUpdate.RokProdukcji = int.Parse(TextBrokProd.Text);
                }
                db.Update(carUpdate);
                db.SaveChanges();          

                mainform.CarsGridView.DataSource = null; // updatowanie samochodu w tabeli samochody

                var cars = db.Samochody.Where(sam => sam.Dostepnosc == "tak" || sam.Dostepnosc == "dostepny").Where(d => d.IdSalonu == idSalonu).ToList();
                foreach (Samochody car in cars)
                {
                    if (car.Zdjecie == null)
                    {
                        car.Zdjecie = ImageToByteArray(Properties.Resources.car);
                    }
                }
                mainform.CarsGridView.DataSource = cars;
                mainform.CarsGridView.Refresh();
                mainform.CarsGridView.Update();
                this.Close();
            }
            else
            {
                errorCount = 0;
            }
        }
        
        private void carImgButton_Click(object sender, EventArgs e)
        {


            openFileDialog1.Filter = "Png files|*.png|JPEG files|*.jpg;*.jpeg;*.jpe;*.jfif|All files|*.*";
            openFileDialog1.AddExtension = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                Bitmap img = new Bitmap(path, true);

                this.picBoxImg.BackgroundImage = img;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var carRemove = db.Samochody.FirstOrDefault(samochod => samochod.IdSamochodu == carId);
            if (carRemove != null)
            {
                db.Samochody.Remove(carRemove);
            }
            db.SaveChanges();
            Log.SaveLog("Usunięto samochod id="+carId+".", LogType.Sukces);
            mainform.CarsGridView.DataSource = null; // usuwanie samochodu


            var cars = db.Samochody.Where(sam => sam.Dostepnosc == "tak" || sam.Dostepnosc == "dostepny").Where(d => d.IdSalonu == idSalonu).ToList();
            foreach (Samochody car in cars)
            {
                if (car.Zdjecie == null)
                {
                    car.Zdjecie = ImageToByteArray(Properties.Resources.car);
                }
            }
            mainform.CarsGridView.DataSource = cars;

            mainform.CarsGridView.Update();
            this.Close();
        }
    }
}
