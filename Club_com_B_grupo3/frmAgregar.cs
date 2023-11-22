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
    public partial class frmAgregar : Form
    {
        Form principal;
        int opcion;
        public frmAgregar(Form principal,int opcion)
        {
            this.opcion = opcion;
            this.principal = principal;
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            if (opcion == 0)
            {
                lblTitulo.Text = "Agregar nuevo socio";
            }
            else if (opcion == 1)
            {
                this.Text = "Agregar no socio";
                lblTitulo.Text = "Agregar nuevo no socio";
            }
            Name = lblTitulo.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "" && txtApellido.Text != "" && txtDni.Text != "" && txtDireccion.Text != "" && txtMail.Text != "" && txtCodigo.Text != "" && txtNumero.Text != "")
            {
                if (!chkApto.Checked)
                {
                    MessageBox.Show("Para poder registrarse, es necesario presentar el apto físico", "Alerta");
                }
                else
                {
                    if (opcion == 0)
                    {
                        Socio socio = new Socio(txtNombre.Text,txtApellido.Text,txtDireccion.Text,txtMail.Text,txtCodigo.Text+txtNumero.Text, int.Parse(txtDni.Text),chkApto.Checked);
                    }
                    else if (opcion == 1)
                    {
                        NoSocio noSocio = new NoSocio(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtMail.Text, txtCodigo.Text + txtNumero.Text, int.Parse(txtDni.Text), chkApto.Checked);
                    }
                    principal.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Mensaje del sistema");
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
