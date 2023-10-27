using MySql.Data.MySqlClient;
using System;

namespace Club.Datos
{
    internal class Conexion
    {
        private String database;
        private String server;
        private String port;
        private String user;
        private String key;
        private static Conexion con = null;


        private Conexion()
        {
            this.database = "omeguitas";
            this.server = "localhost";
            this.port = "3306";
            this.user = "root";
            this.key = "";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.server + ";port=" + this.port + ";username=" + this.user + ";Database=" + this.database;
            }
            catch
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
