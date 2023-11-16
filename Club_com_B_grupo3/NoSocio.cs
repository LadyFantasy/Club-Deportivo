using Club.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_com_B_grupo3.Datos
{
    internal class NoSocio : Persona
    {
        public NoSocio(string nom, string ape, string dir, string mail, string tel, int dni, bool apto) : base(nom, ape, dir, mail, tel, dni, apto)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string registrado;
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ingresarNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nom", MySqlDbType.VarChar).Value = nom;
                comando.Parameters.Add("ape", MySqlDbType.VarChar).Value = ape;
                comando.Parameters.Add("dir", MySqlDbType.VarChar).Value = dir;
                comando.Parameters.Add("mail", MySqlDbType.VarChar).Value = mail;
                comando.Parameters.Add("tel", MySqlDbType.VarChar).Value = tel;
                comando.Parameters.Add("pdni", MySqlDbType.Int32).Value = dni;
                comando.Parameters.Add("apto", MySqlDbType.Bit).Value = apto;
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
                    MessageBox.Show("El nuevo no socio " + nom + " " + ape + " Fue registrado con exito", "Registro exitoso");
                }
                else
                {
                    MessageBox.Show("Ya se encuentra registrado un no socio con el DNI N° " + dni + " previamente", "Registro fallido");
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
    }
}
