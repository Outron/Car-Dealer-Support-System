using CarDealerSupportSystem.Models;
using CarDealerSupportSystem.SellerFormPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerSupportSystem
{
    public partial class TaskInfoForm : Form
    {
        private NewTasksPanel mainForm;
        private int taskID;
        private string serviceName;
        public TaskInfoForm(Form form, int taskID, string serviceName)
        {
            this.taskID = taskID;
            this.serviceName = serviceName;
            this.mainForm = form as NewTasksPanel;
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


        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Napewno zamknąć? Niezatwierdzone zmiany zostaną usunięte.", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void acceptTaskButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Napewno przypisać zadanie?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                using (salon_samochodowyContext db = new salon_samochodowyContext())
                {
                    var taskToDelete  = ""; //zapytanie do usneicia odpowiednich rzeczy
                    if (taskToDelete != null)
                    {
                        db.Remove(taskToDelete);
                        db.SaveChanges();
                    }
                    this.mainForm.TasksGridView.DataSource = null;
                    mainForm.LoadTasks();
                }
                MessageBox.Show("Pomyślnie usunięto użytkownika", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
