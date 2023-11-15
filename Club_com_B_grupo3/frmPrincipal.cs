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
    }
}
