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
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Remoting.Contexts;

namespace CarDealerSupportSystem.SellerFormPanels
{
    public partial class LogsPanel : Form
    {
        private readonly salon_samochodowyContext db = new();
        private readonly Timer timer;
        public LogsPanel()
        {
            InitializeComponent();
            timer=new Timer();
            timer.Interval = 300000; //co 5min
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            RefreshBox();
        }

        private void LogsPanel_Load(object sender, EventArgs e)
        {
            RefreshBox();
        }

        private void SearchClientsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (logsTextBox.Text=="Brak danych")
            {
                eventsCount.Text = "0";
            }
            eventsCount.Text = (logsTextBox.Lines.Count() - 1).ToString();
        }

        private void exportLogsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(logsTextBox.Text) || logsTextBox.Text=="Brak danych")
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
                    MessageBox.Show("Plik zapisano pomyślnie.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas zapisywania pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Log.SaveLog("Dodano rekord do bazy", LogType.Informacja);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log.SaveLog("Blad logowania", LogType.Blad);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Log.SaveLog("Udane logowanie", LogType.Sukces);

        }

        private void LogsPanel_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
        }
    }
}
