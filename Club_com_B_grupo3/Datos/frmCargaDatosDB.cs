using Club.Datos;
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
    public partial class frmCargaDatosDB : Form
    {
        public frmCargaDatosDB()
        {
            InitializeComponent();
        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            if(txtPass.Text == "" && respuesta != "Yes")
            {
                respuesta = MessageBox.Show("El campo \"Contraseña\" se encuentra vacio, esta seguro/a que su usuario de DB no requiere la misma", "Mensaje del sistema", MessageBoxButtons.YesNo).ToString();
            }
            if (txtUsuario.Text == "" || txtPuerto.Text == "" || txtServidor.Text == "")
            {
                MessageBox.Show("Los campos marcados (*) son obligatorios", "Mensaje del sistema");
            }
            else
            {
                if (respuesta == "Yes")
                {
                    Conexion.Port = txtPuerto.Text;
                    Conexion.Server = txtServidor.Text;
                    Conexion.Key = txtPass.Text;
                    Conexion.User = txtUsuario.Text;
                    Close();
                }
            }
        }
    }
}
