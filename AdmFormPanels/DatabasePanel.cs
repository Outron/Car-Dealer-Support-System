extern alias mysqldata;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class DatabasePanel : Form
    {
        private readonly string conString;
        public DatabasePanel()
        {
            this.conString = "server=localhost;user=root;pwd=samochody;database=sam;";
            InitializeComponent();
        }

        private void CreateDumpButton_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Pliki SQL (*.sql)|*.sql|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Zapisz kopię zapasową";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                using (mysqldata::MySql.Data.MySqlClient.MySqlConnection conn = new(conString))
                {
                    using mysqldata::MySql.Data.MySqlClient.MySqlCommand cmd = new();
                    {
                        using MySqlBackup mb = new(cmd);
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
                    MessageBox.Show("Wystąpił błąd. Spróbuj ponownie.", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void RestoreButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Pliki SQL (*.sql)|*.sql|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Wybierz kopię zapasową do przywrócenia";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                FileInfo fileInfo = new(file);
                try
                {
                    using (mysqldata::MySql.Data.MySqlClient.MySqlConnection conn = new(conString))
                    {
                        using mysqldata::MySql.Data.MySqlClient.MySqlCommand cmd = new();
                        using MySqlBackup mb = new(cmd);
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            conn.Close();
                        }
                    }
                    MessageBox.Show($"Pomyślnie przywrócono bazę danych z dnia {fileInfo.CreationTime.ToString("yyyy-MM-dd")}", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show($"Wystąpił błąd podczas przywracania bazy danych. Upewnij się, że wybrano odpowiedni plik", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
