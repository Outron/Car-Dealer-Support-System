using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Net.Mime.MediaTypeNames;

namespace CarDealerSupportSystem
{
    internal class PdfCreator
    {
        private Document document;
        public PdfCreator(string fileName)
        {
            document = new();
            PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
        }
        public void DocOpen() => this.document.Open();
        public void DocClose() => this.document.Close();
        public void NewPage() => this.document.NewPage();
        public void Add(IElement x) => this.document.Add(x);
        public void AddParagraph(string content, float size, float spacing, int align)
        {
            var bigFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, size); //FOnt.BOLD
            Paragraph paragraph = new(content, bigFont);
            paragraph.SpacingAfter = spacing;
            paragraph.Alignment = align; //0-lewo 1-srodek 2-prawo
            document.Add(paragraph);
        }

        public void AddTable(List<List<string>> itemsList, params string[] columnNames)
        {
            int rowsInTable = itemsList.Count();
            var bigFont = FontFactory.GetFont(BaseFont.TIMES_BOLD, BaseFont.CP1257, 12); //czczionka kolumny
            var cellsFont = FontFactory.GetFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, 12); 
            BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new (baseFont, Font.DEFAULTSIZE, Font.NORMAL);
            if (rowsInTable > 0)
            {
                PdfPTable table = new(itemsList[0].Count());
                table.WidthPercentage = 100;
                float[] centerValues = Enumerable.Repeat(-1f, itemsList[0].Count()).ToArray();
                table.SetWidths(centerValues);
                table.DefaultCell.NoWrap = true;
                table.SpacingAfter = 20; //do przepatrzenia
                foreach (string valueN in columnNames)
                {
                    PdfPCell cell = new(new Phrase(valueN, bigFont));
                    cell.HorizontalAlignment = 1;
                    cell.FixedHeight = 20; //wysokosc komorki dla nazw kolumn
                    table.AddCell(cell);
                }
                foreach (List<string> row in itemsList)
                {
                    foreach (string value in row)
                    {
                        PdfPCell cell=new(new Phrase(value,cellsFont));
                        cell.FixedHeight = 20;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);
                    }
                }
                document.Add(table);
            }
            else
            {
                AddParagraph("brak danych", 12, 1, 0);
            }
        }
    }
}
