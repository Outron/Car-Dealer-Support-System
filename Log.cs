using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CarDealerSupportSystem.SellerFormPanels;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using CarDealerSupportSystem.Models;
using System.Net.NetworkInformation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CarDealerSupportSystem
{
    public enum LogType
    {
        Informacja,
        Sukces,
        Ostrzezenie,
        Blad
    }
    public static class Log
    {
        //public static readonly string logPath = AppContext.BaseDirectory+@"\log.txt";
        public static void SaveLog(string message, LogType logType)
        {
            using (salon_samochodowyContext db = new())
            {
                string typeName = Enum.GetName(typeof(LogType), logType);
                //string formattedMesage = $"{DateTime.Now} - [{typeName}] {message}";
                db.Add(new Logi() { DataGodzina = DateTime.Now, Wiadomosc = message, Typ = typeName});
                db.SaveChanges();
            }
        }
        private static Color GetColor(LogType logType)
        {
            switch (logType)
            {
                case LogType.Informacja:
                    return Color.DodgerBlue;
                case LogType.Sukces:
                    return Color.Green;
                case LogType.Ostrzezenie:
                    return Color.DarkOrange;
                case LogType.Blad:
                    return Color.Red;
                default:
                    return Color.White;
            }
        }
        
            public static void LoadLogs(RichTextBox richBox)
        {
            richBox.Clear();
            using (salon_samochodowyContext db = new())
            {
                LogType logType;
                var logsList = db.Logi
                .Where(log => log.DataGodzina.Date == DateTime.Today)
                .Select(log => new { log.DataGodzina, log.Typ, log.Wiadomosc })
                .ToList();
                foreach (var log in logsList)
                {
                    logType = (LogType)Enum.Parse(typeof(LogType), log.Typ);
                    richBox.SelectionColor = Color.White;
                    richBox.AppendText($"{log.DataGodzina} - ");
                    richBox.SelectionColor = GetColor(logType);
                    richBox.AppendText($"[{log.Typ}] {log.Wiadomosc}\n");
                }
            }
        }
    }
}
