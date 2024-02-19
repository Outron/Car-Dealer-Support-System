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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarDealerSupportSystem.ManagerFormPanels
{

    public partial class AddCarsForm : Form
    {
        private CarsManager mainform;
        private salon_samochodowyContext db = new salon_samochodowyContext();
        private string currTextBox;
        private readonly Color gridDefaultCellStyle;
        private int errorCount;
        public AddCarsForm(Form f)
        {
            InitializeComponent();
            gridDefaultCellStyle = AddCarsGridView.DefaultCellStyle.BackColor;
            currTextBox = "";
            errorCount = 0;
            mainform = f as CarsManager;
        }
        public AddCarsForm()
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
            public int idsalonu { get; set; }
            public string dostepnosc { get; set; }
            public string rokprodukcji { get; set; }
            public samochody(DataGridViewRow cell)
            {
                //int i = 0;
                zdjecie= ObjectToByteArray(cell.Cells[0].Value);
                model = cell.Cells[1].Value.ToString();
                marka = cell.Cells[2].Value.ToString();
                typnadwozia = cell.Cells[3].Value.ToString();
                cenapodstawowa = cell.Cells[4].Value.ToString();
                vin= cell.Cells[5].Value.ToString();
                kolor= cell.Cells[6].Value.ToString();
                mocsilnika= cell.Cells[7].Value.ToString();
                wyposazenie= cell.Cells[8].Value.ToString();
                sredniespalanie = cell.Cells[9].Value.ToString();
                typsilnika= cell.Cells[10].Value.ToString();
                liczbadrzwi= cell.Cells[11].Value.ToString();
                liczbamiejsc= cell.Cells[12].Value.ToString();
                //rabat= cell.Cells[13].Value.ToString();
                rokprodukcji= cell.Cells[14].Value.ToString();
                dostepnosc = "dostepny";
               
            }
        }
        private void AddCarsForm_Load(object sender, EventArgs e)
        {
            checkedListBoxUlugi.DataSource = (from uslugi in db.Uslugi select uslugi.Nazwa).ToList();
            this.TextBcena.Text = " Cena";
            this.TextBkolor.Text = " Kolor";
            this.TextBliczbaDrz.Text = " Liczba drzwi";
            this.TextBliczbaM.Text = " Liczba miejsc";
            this.TextBmarka.Text = " Marka";
            this.TextBmocSil.Text = " Moc Silnika";
            this.TextBmodel.Text = " Model";
            this.TextBrokProd.Text = " Rok produkcji";
            this.TextBsredSpala.Text = " Średnie spalanie";
            this.TextBtypNadw.Text = " Typ nadwozia";
            this.TextBtypSil.Text = " Typ silnika";
            this.TextBvin.Text = " VIN";
            this.TextBwyposaz.Text = " Wyposażenie";
            AddCarsBigLabel1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCarsGridView_SelectionChanged(object sender, EventArgs e)
        {
            AddCarsGridView.ClearSelection();
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
            TextBrokProd.Text= s.rokprodukcji.ToString();
            TextBsredSpala.Text= s.sredniespalanie.ToString();
            TextBtypNadw.Text= s.typnadwozia;
            TextBtypSil.Text= s.typsilnika;
            TextBvin.Text= s.vin;
            TextBwyposaz.Text= s.wyposazenie;
            picBoxImg.BackgroundImage = ByteArrayToBitmap(s.zdjecie);
        }
        private void AddCarsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
                AddCarsGridView.Rows.RemoveAt(e.RowIndex);
            //else
            //{
            //    var row = AddCarsGridView.Rows[e.RowIndex];
            //    samochody sam = new samochody(AddCarsGridView.Rows[e.RowIndex]);
            //    TextBoxFill(sam);
            //}
        }
        private void AddCarsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 15)
            {

                samochody sam = new samochody(AddCarsGridView.Rows[e.RowIndex]);
                TextBoxFill(sam);
            }
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

        private void AddCarsForm_Click(object sender, EventArgs e)
        {
            if(currTextBox != "" && !(sender is TextBox))
            {
                var tBox = this.Controls.Find(currTextBox, true).FirstOrDefault() as TextBox;
                
                
                    this.AddCarsBigLabel1.Select();
                
            }
        }
       
        private void AddCarButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && errorCount==0)
            {
                this.AddCarsGridView.Rows.Add(ImageToByteArray(this.picBoxImg.BackgroundImage), this.TextBmodel.Text, this.TextBmarka.Text,
                this.TextBtypNadw.Text, this.TextBcena.Text, this.TextBvin.Text, this.TextBkolor.Text, this.TextBmocSil.Text, 
                this.TextBwyposaz.Text, this.TextBsredSpala.Text, this.TextBtypSil.Text, this.TextBliczbaDrz.Text, this.TextBliczbaM.Text, null, this.TextBrokProd.Text);
            }
            else
            {
                errorCount = 0;
            }
        }
        //Validating metody wszystkie
        
        private void TextBString_Validating(object sender, CancelEventArgs e)
        {
            var textB = sender as TextBox;
            if (string.IsNullOrEmpty(textB.Text) || textB.Text == textB.Tag.ToString())
            {
                errorProvider1.SetError(textB, "Nie wpisano poprawnej"+textB.Tag);
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
        private void AddCarsGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                AddCarsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void AddCarsGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)    
            {
                AddCarsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = gridDefaultCellStyle;
            }
        }

        private void OkCarButton_Click(object sender, EventArgs e)
        {
            var query = (from salon in db.Salony
                                 join pracownik in db.Pracownicy on salon.IdSalonu equals pracownik.IdSalonu
                                 where pracownik.Login == mainform.login
                                 select salon.IdSalonu).ToList().FirstOrDefault();
            foreach (DataGridViewRow row in AddCarsGridView.Rows)
            {
                samochody car = new samochody(row);          

                db.Add(new Samochody() { IdSalonu = query, CenaPodstawowa = int.Parse(car.cenapodstawowa), Zdjecie = car.zdjecie, Model = car.model, Marka = car.marka,
                    Kolor = car.kolor, TypNadwozia = car.typnadwozia, MocSilnika = int.Parse(car.mocsilnika), Wyposazenie = car.wyposazenie,
                    SrednieSpalanie = int.Parse(car.sredniespalanie), TypSilnika = car.typsilnika, LiczbaDrzwi = int.Parse(car.liczbadrzwi),
                    IloscMiejsc = int.Parse(car.liczbamiejsc), Vin = car.vin, Rabat = null, Dostepnosc = car.dostepnosc,
                    RokProdukcji = int.Parse(car.rokprodukcji) });
                db.SaveChanges();
            }
            mainform.CarsGridView.DataSource = null; // updatowanie listy w panelu z edycja listy samochodow

            var cars = db.Samochody.Where(sam => sam.Dostepnosc == "tak" || sam.Dostepnosc == "dostepny").Where(d => d.IdSalonu == query).ToList();
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
    }
}
