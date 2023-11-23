using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;

namespace Club_com_B_grupo3
{
    public class FormImprimible : Form
    {
        protected void imprimir()
        {
            
            PrintDocument documento = new PrintDocument();
            documento.PrintPage += new PrintPageEventHandler(imprimirComprobante);
            documento.Print();
            Close();
        }

        protected void imprimirComprobante(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(20, 50);
            e.Graphics.DrawImage(img, p);
            e.HasMorePages = false;
        }

    }
}
