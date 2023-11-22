using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_com_B_grupo3.Datos
{
    public partial class frmIngreseDni : Form
    {
        int opcion;
        public frmIngreseDni(int opcion)
        {
            this.opcion = opcion;
            InitializeComponent();
        }

        private void frmIngreseDni_Load(object sender, EventArgs e)
        {
            if(this.opcion == 0)
            {
                lblTitulo.Text = "Ingrese DNI del socio";
                btnIngresarSocio.Visible = true;
            }else
                if (this.opcion == 1)
            {
                lblTitulo.Text = "Ingrese DNI del no socio";
                btnIngresarNoSocio.Visible = true;
                lblActividad.Visible = true;
                txtActividad.Visible = true;
                lblValor.Visible = true;
                txtValor.Visible = true;
            }
        }

        private void btnIngresarSocio_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDni.Text);
            DataTable dt = Socio.buscarSocio(dni);
            if(dt.Rows.Count > 0)
            {
                Socio.pagarCuota(dni);
                Close();
            }
            else
            {
                MessageBox.Show("No se encuentra registrado ningún Socio con DNI: " + dni.ToString(), "Socio no hallado");
            }
        }

        private void btnIngresarNoSocio_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDni.Text);
            DataTable dt = NoSocio.buscarNoSocio(dni);
            string forma;
            string cuotas;
            if (dt.Rows.Count > 0)
            {
                if (rbtEfectivo.Checked)
                {
                    forma = "efectivo";
                }
                else
                {
                    forma = "tarjeta";
                }
                if (rbt1.Checked)
                {
                    cuotas = "1";
                }
                else
                {
                    if (rbt3.Checked)
                    {
                        cuotas = "3";
                    }
                    else
                    {
                        cuotas = "6";
                    }
                }
                NoSocio.pagarActividad(dni,txtActividad.Text,txtValor.Text,forma,cuotas);
                Close();
            }
            else
            {
                MessageBox.Show("No se encuentra registrado ningún No Socio con DNI: " + dni.ToString(), "No socio no hallado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtTarjeta.Checked)
            {
                cboCuotas.Visible = true;
                cboPago.Size = new Size(180, 180);
            }
            else
            {
                cboCuotas.Visible = false;
                cboPago.Size = new Size(180, 100);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Name = lblTitulo.Text;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
