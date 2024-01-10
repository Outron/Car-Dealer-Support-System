extern alias mysqldata;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class DatabasePanel : Form
    {
        public DatabasePanel()
        {
            InitializeComponent();
        }

        private void DatabasePanel_Load(object sender, EventArgs e)
        {
            
        }
        
        private void CreateDumpButton_Click(object sender, EventArgs e) 
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki SQL (*.sql)|*.sql|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Zapisz kopię zapasową";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string constring = "server=localhost;user=root;pwd=samochody;database=salon_samochodowy;";
                    string file = saveFileDialog.FileName;
                    using (mysqldata::MySql.Data.MySqlClient.MySqlConnection conn = new mysqldata::MySql.Data.MySqlClient.MySqlConnection(constring))
                    {
                        using (mysqldata::MySql.Data.MySqlClient.MySqlCommand cmd = new mysqldata::MySql.Data.MySqlClient.MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportToFile(file);
                                conn.Close();
                            }
                        }
                    }
                    if (File.Exists(file))
                    {
                        MessageBox.Show("Pomyślnie utworzono kopię bazy.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void RestoreButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki SQL (*.sql)|*.sql|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Title = "Wybierz kopię zapasową do przywrócenia";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string constring = "server=localhost;user=root;pwd=samochody;database=salon_samochodowy;";
                    string file = openFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(file);
                    using (mysqldata::MySql.Data.MySqlClient.MySqlConnection conn = new mysqldata::MySql.Data.MySqlClient.MySqlConnection(constring))
                    {
                        using (mysqldata::MySql.Data.MySqlClient.MySqlCommand cmd = new mysqldata::MySql.Data.MySqlClient.MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ImportFromFile(file);
                                conn.Close();
                            }
                        }
                    }
                    MessageBox.Show($"Pomyślnie przywrócono bazę danych z dnia {fileInfo.CreationTime.ToString("yyyy-MM-dd")}", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
