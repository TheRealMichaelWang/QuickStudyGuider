using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;

namespace QuickStudyGuider
{
    public class TextPrinter
    {
        public Font Font;
        public string[] lines;
        public int currentline = 0;

        public string ReadLine()
        {
            if(lines.Length == currentline)
            {
                return null;
            }
            currentline++;
            return lines[currentline - 1];
        }

        public void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        { 
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;  
            float leftMargin = 10;
            float topMargin = 10;
            string line = null; 
            linesPerPage = ppeArgs.MarginBounds.Height / Font.GetHeight(g);
            while (count < linesPerPage && ((line = ReadLine()) != null))
            {
                yPos = topMargin + (count * Font.GetHeight(g));
                g.DrawString(line, Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            } 
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }
    }
}
