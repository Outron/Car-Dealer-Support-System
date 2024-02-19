using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using CarDealerSupportSystem.Models;

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
        public static void SaveLog(string message, LogType logType)
        {
            using salon_samochodowyContext db = new();
            string typeName = Enum.GetName(typeof(LogType), logType);
            db.Add(new Logi() { DataGodzina = DateTime.Now, Wiadomosc = message, Typ = typeName });
            db.SaveChanges();
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
            using salon_samochodowyContext db = new();
            LogType logType;
            var logsList = db.Logi
            .Where(log => log.DataGodzina.Date == DateTime.Today)
            .Select(log => new { log.DataGodzina, log.Typ, log.Wiadomosc })
            .ToList();
            foreach (var log in logsList)
            {
                string type = log.Typ;
                logType = (LogType)Enum.Parse(typeof(LogType), log.Typ);
                richBox.SelectionColor = Color.White;
                richBox.AppendText($"{log.DataGodzina} - ");
                richBox.SelectionColor = GetColor(logType);
                if (type == "Blad") { type = "Błąd"; }
                else if (type == "Ostrzezenie") { type = "Ostrzeżenie"; }
                richBox.AppendText($"[{type}] {log.Wiadomosc}\n");
            }
        }
    }
}
