﻿using CarDealerSupportSystem.Models;
using CarDealerSupportSystem.SellerFormPanels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class TaskInfoForm : Form
    {
        private readonly NewTasksPanel? mainForm;
        private readonly CurrentTasksPanel? currMainForm;
        private readonly int id;
        private readonly string[] taskInfo;
        public TaskInfoForm(Form form, string[] taskInfo, int id)
        {
            InitializeComponent();
            this.id = id;
            this.taskInfo = taskInfo;
            if (form is NewTasksPanel)
            {
                this.mainForm = form as NewTasksPanel;
                this.acceptTaskButton.Click -= endTaskButton_Click;
                this.acceptTaskButton.Click += acceptTaskButton_Click;
            }
            else if (form is CurrentTasksPanel)
            {
                this.currMainForm = form as CurrentTasksPanel;
                this.acceptTaskButton.Click -= acceptTaskButton_Click;
                this.acceptTaskButton.Click += endTaskButton_Click;
                this.acceptTaskButton.Text = "Zakończ zadanie";
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

        // End Drag Form


        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Napewno zamknąć? Niezatwierdzone zmiany zostaną usunięte.", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //przypisanie zadania do serwisanta
        private void acceptTaskButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Napewno przypisać zadanie?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                using (salon_samochodowyContext db = new())
                {
                    db.Database.ExecuteSqlRaw($"UPDATE zamowienia_samochody_uslugi SET Status='wtrakcie', id_pracownika={this.id} WHERE id_zamowienia={taskInfo[0]} AND id_samochodu={taskInfo[11]} AND id_uslugi={taskInfo[12]}");
                    this.mainForm.TasksGridView.DataSource = null;
                    mainForm.LoadTasks();
                }
                this.Close();
            }
        }

        private void endTaskButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Napewno zakończyć zadanie?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                using (salon_samochodowyContext db = new())
                {
                    db.Database.ExecuteSqlRaw($"UPDATE zamowienia_samochody_uslugi SET Status='zakończone' WHERE id_zamowienia={taskInfo[0]} AND id_samochodu={taskInfo[11]} AND id_uslugi={taskInfo[12]} AND id_pracownika={this.id}");
                    this.currMainForm.TasksGridView.DataSource = null;
                    currMainForm.LoadCurrentTasks();
                    //sprawdzamy czy ktores uslugi dla zamowienia zostaly wszystkie zakonczone
                    var ordersWithCompletedStatus = db.ZamowieniaSamochodyUslugi
                                               .ToList()
                                               .GroupBy(o => o.IdZamowienia)
                                               .Where(g => g.All(o => o.Status == "zakończone"))
                                               .Select(g => g.Key)
                                               .OrderBy(id => id)
                                               .ToList();

                    if (!ordersWithCompletedStatus.Any())
                    {
                        ordersWithCompletedStatus = null;
                    }
                    else
                    {
                        var ordersToUpdate = db.Zamowienia
                                                .Where(o => ordersWithCompletedStatus.Contains(o.IdZamowienia))
                                                .ToList();
                        foreach (var order in ordersToUpdate)
                        {
                            order.Status = "zakończone";
                        }
                    }
                    db.SaveChanges();
                }
                this.Close();
            }
        }

        private void TaskInfoForm_Load(object sender, EventArgs e)
        {
            taskNumberLabel.Text += $" {taskInfo[0]}";
            clientNameLabel.Text = "Imię i nazwisko: " + $"{taskInfo[1]} {taskInfo[2]}";
            clientPhoneLabel.Text = "Telefon: " + taskInfo[3];
            clientEmailLabel.Text = "Email: " + taskInfo[4];
            markaLabel.Text += $"{taskInfo[5]}";
            modelLabel.Text += $"{taskInfo[6]}";
            nadwozieLabel.Text += $"{taskInfo[8]}";
            engineTypeLabel.Text += $"{taskInfo[7]}";
            workerLabel.Text += $"{taskInfo[9]} {taskInfo[10]}";
        }
    }
}
