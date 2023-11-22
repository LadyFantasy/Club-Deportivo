using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_com_B_grupo3
{
    public partial class frmComprobantePagoActividad : FormImprimible
    {
        string nombre;
        string actividad;
        string monto;
        string forma;
        string cuotas;
        public frmComprobantePagoActividad(string nombre, string actividad, string monto, string forma, string cuotas)
        {
            this.nombre = nombre;
            this.actividad = actividad;
            this.monto = monto;
            this.forma = forma;
            this.cuotas = cuotas;
            InitializeComponent();
        }

        private void frmComprobantePagoActividad_Load(object sender, EventArgs e)
        {
            string hoy = DateTime.Today.ToString();
            lblHoy.Text = hoy.Remove(hoy.Length - 9);
            lblNombre.Text = nombre;
            lblNombre.Left = lblTexto.Right;
            lblActividad.Text = actividad;
            lblActividad.Left = lblTexto4.Right;
            lblMonto.Text = monto;
            lblMonto.Left = lblTexto2.Right;
            lblForma.Text = forma;
            lblForma.Left = lblTexto3.Right;
            if (forma == "tarjeta")
            {
                lblEn.Left = lblForma.Right;
                lblCant.Left = lblEn.Right;
                lblCant.Text = cuotas;
                lblCuotas.Left = lblCant.Right;
                lblEn.Visible = true;
                lblCant.Visible = true;
                lblCuotas.Visible = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            imprimir();
        }
    }
}
