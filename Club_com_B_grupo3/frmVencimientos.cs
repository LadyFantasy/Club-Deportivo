using Club.Datos;
using MySql.Data.MySqlClient;
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
    public partial class frmVencimientos : Form
    {
        Form ppal;
        string hoy = DateTime.Today.ToString();
        public frmVencimientos(Form ppal)
        {
            this.ppal = ppal;
            InitializeComponent();
        }

        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            lblDia.Text = hoy.Remove(hoy.Length - 9);
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ListarVencimientos", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("hoy", MySqlDbType.Date).Value = hoy;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }

            int filas = tabla.Rows.Count;
            if(filas > 0)
            {
                for(int i=0; i < filas;i++)
                {
                    int filaGrd = grdVencimientos.Rows.Add();
                    grdVencimientos.Rows[filaGrd].Cells[0].Value = tabla.Rows[i][0].ToString();
                    grdVencimientos.Rows[filaGrd].Cells[1].Value = tabla.Rows[i][1].ToString();
                    grdVencimientos.Rows[filaGrd].Cells[2].Value = tabla.Rows[i][2].ToString();
                };
            }
        }
    }
}
