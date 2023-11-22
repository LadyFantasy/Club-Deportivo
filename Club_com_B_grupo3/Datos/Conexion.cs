using MySql.Data.MySqlClient;
using System;

namespace Club.Datos
{
    internal class Conexion
    {
        static readonly string database = "omeguitas";
        private static string server;
        private static string port;
        private static string user;
        private static string key;
        public static Conexion con = null;

        static public string Database { get => database; }
        public static string Server { get => server; set => server = value; }
        public static string Port { get => port; set => port = value; }
        public static string User { get => user; set => user = value; }
        public static string Key { get => key; set => key = value; }

        private Conexion()
        {
            
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource= "
                    + Server
                    + ";port= "
                    + Port
                    + ";username= "
                    + User
                    + ";Database= "
                    + Database
                    + ";password= "
                    + Key;
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

            
        public MySqlConnection CrearcrearDataBase()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + Server + ";port=" + Port + ";username=" + User + ";password=" + Key;
            }
            catch
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
    }
}
