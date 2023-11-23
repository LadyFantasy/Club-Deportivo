using Club.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_com_B_grupo3.Datos
{
    internal class Socio : Persona
    {
        public Socio(string nom, string ape, string dir, string mail, string tel , int dni, bool apto) : base(nom,ape,dir,mail,tel,dni,apto)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string registrado;
                MySqlCommand comando = new MySqlCommand("ingresarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nom", MySqlDbType.VarChar).Value = nom;
                comando.Parameters.Add("ape", MySqlDbType.VarChar).Value = ape;
                comando.Parameters.Add("dir", MySqlDbType.VarChar).Value = dir  ;
                comando.Parameters.Add("mail", MySqlDbType.VarChar).Value = mail;
                comando.Parameters.Add("tel", MySqlDbType.VarChar).Value = tel;
                comando.Parameters.Add("pdni", MySqlDbType.Int32).Value = dni;
                comando.Parameters.Add("apto", MySqlDbType.Bit).Value = apto;
                comando.Parameters.Add("vto", MySqlDbType.Date).Value = DateTime.Today;
                MySqlParameter salida = new MySqlParameter();
                salida.ParameterName = "exito";
                salida.DbType = DbType.Boolean;
                salida.Direction = ParameterDirection.Output;
                comando.Parameters.Add(salida);
                
                sqlCon.Open();
                comando.ExecuteNonQuery();
                registrado = Convert.ToString(salida.Value);
                if (registrado == "1")
                {
                    string mensaje = "El nuevo socio " + nom + " " + ape + " Fue registrado con exito. ";

                    DataTable existeNoSocio = NoSocio.buscarNoSocio(dni);
                    if (existeNoSocio.Rows.Count > 0)
                    {
                        MySqlCommand comando2 = new MySqlCommand("borrarNoSocio", sqlCon);
                        comando2.CommandType = CommandType.StoredProcedure;
                        comando2.Parameters.Add("documento", MySqlDbType.Int32).Value = dni;
                        comando2.ExecuteNonQuery();
                        mensaje += "Y borrado de la lista de no socios";
                    }
                    MessageBox.Show(mensaje, "Registro exitoso");
                    Form form = new frmCarnet(nom+", "+ape,dni.ToString());
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ya se encuentra registrado un socio con el DNI N° " + dni + " previamente", "Registro fallido");
                }
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
        }

        public static DataTable buscarSocio(int dni) {
            MySqlDataReader resultado;
            DataTable socio = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("BuscarSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("documento", MySqlDbType.Int64).Value = dni;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                socio.Load(resultado);
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
            return socio;
        }
        public static void pagarCuota(int dni) 
        {
            DataTable socio = buscarSocio(dni);
            if (socio.Rows.Count > 0)
            {
                string nombre = socio.Rows[0][0].ToString();
                string apellido = socio.Rows[0][1].ToString();
                string vencimiento = socio.Rows[0][7].ToString();
                vencimiento = vencimiento.Remove(vencimiento.Length - 9);
                string respuesta = MessageBox.Show("El socio " + nombre + ", " + apellido + ".\nTiene pago hasta el día " + vencimiento + "\n¿Desea abonar un mes más?", "Abonar cuota", MessageBoxButtons.YesNo).ToString();
                if (respuesta == "Yes")
                {
                    MySqlConnection sqlCon = new MySqlConnection();
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    sqlCon.Open();
                    DateTime vencimientoViejo = (DateTime)socio.Rows[0][7];
                    DateTime vencimientoNuevo = vencimientoViejo.AddMonths(1);
                    MySqlCommand pagar = new MySqlCommand("ActualizarVencimiento", sqlCon);
                    pagar.CommandType = CommandType.StoredProcedure;
                    pagar.Parameters.Add("vto", MySqlDbType.Date).Value = vencimientoNuevo;
                    pagar.Parameters.Add("documento", MySqlDbType.Int64).Value = dni;
                    pagar.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
        }
    }
}
