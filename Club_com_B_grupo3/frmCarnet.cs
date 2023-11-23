using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_com_B_grupo3
{
    public partial class frmCarnet : FormImprimible
    {
        string nombre;
        string numero;
        public frmCarnet(String nombre, string numero)
        {
            this.nombre = nombre;
            this.numero = numero;
            InitializeComponent();
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre;
            lblNumero.Text = numero;
            lblNumero.Left = lblSocioNro.Right;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            imprimir();
        }
    }
}
