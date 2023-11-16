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
    public partial class frmAgregarSocio : Form
    {
        Form principal;
        public frmAgregarSocio(Form principal)
        {
            this.principal = principal;
            InitializeComponent();
        }

        private void frmAgregarSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio(txtNombre.Text,txtApellido.Text,txtDireccion.Text,txtMail.Text,txtCodigo.Text+txtNumero.Text, int.Parse(txtDni.Text),chkApto.Checked);
            principal.Show();
            this.Close();
        }
    }
}
