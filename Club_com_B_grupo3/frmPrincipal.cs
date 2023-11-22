using Club_com_B_grupo3.Datos;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            Form form = new frmAgregar(this,0);
            this.Hide();
            form.ShowDialog();
        }

        private void btnRegistNoSocio_Click(object sender, EventArgs e)
        {
            Form form = new frmAgregar(this, 1);
            this.Hide();
            form.ShowDialog();
        }
        private void btnListarVencimientos_Click(object sender, EventArgs e)
        {
            Form form = new frmVencimientos(this);
            //this.Hide();
            form.ShowDialog();
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            Form form = new frmIngreseDni(0);
            form.ShowDialog();
        }

        private void btnCobrarActividad_Click(object sender, EventArgs e)
        {
            Form form = new frmIngreseDni(1);
            form.ShowDialog();
        }
    }
}
