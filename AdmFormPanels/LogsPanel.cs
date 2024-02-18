using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class LogsPanel : Form
    {
        private readonly Timer timer;
        private readonly ToolTip toolTip;
        public LogsPanel()
        {
            InitializeComponent();
            timer = new();
            timer.Interval = 120000;
            timer.Tick += Timer_Tick;
            timer.Start();
            toolTip = new() { InitialDelay = 250 };
            toolTip.SetToolTip(refreshLogsButton, "Odśwież listę");
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            RefreshBox();
        }

        private void LogsPanel_Load(object sender, EventArgs e)
        {
            RefreshBox();
        }

        private void logsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (logsTextBox.Text == "Brak danych")
            {
                eventsCount.Text = "0";
            }
            eventsCount.Text = (logsTextBox.Lines.Count() - 1).ToString();
        }

        private void exportLogsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(logsTextBox.Text) || logsTextBox.Text == "Brak danych")
            {
                MessageBox.Show("Brak zawartości do zapisania.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Zapisz plik";
            saveFileDialog.FileName = "Log.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, logsTextBox.Text);
                    MessageBox.Show("Pomyślnie zapisano plik.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show($"Wystąpił błąd podczas zapisywania pliku. Spróbój ponownie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void RefreshBox()
        {
            Log.LoadLogs(logsTextBox);
            if (this.logsTextBox.Text == "")
            {
                this.logsTextBox.Text = "Brak danych";
            }
        }

        private void refreshLogsButton_Click(object sender, EventArgs e)
        {
            RefreshBox();
        }

        private void LogsPanel_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
        }

        private void LogsPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}
