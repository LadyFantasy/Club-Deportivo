using System;
using System.Data;
using System.Windows.Forms;
using Club.Datos;
using MySql.Data.MySqlClient;

namespace Club_com_B_grupo3
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearcrearDataBase();
                string useBase = "USE "+Conexion.Database+";";
                MySqlCommand commUseBase = new MySqlCommand(useBase, sqlCon);
                sqlCon.Open();
                commUseBase.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                string creaBase = "CREATE DATABASE IF NOT EXISTS "+ Conexion.Database + " character set utf8 collate utf8_spanish2_ci; USE omeguitas;";
                MySqlCommand comandoBase = new MySqlCommand(creaBase, sqlCon);
                string socio = "CREATE TABLE IF NOT EXISTS socio(nombre varchar(50),apellido varchar(50),direccion varchar(50),mail varchar(50),telefono varchar(20),dni int PRIMARY KEY,apto boolean);";
                MySqlCommand comandoSocio = new MySqlCommand(socio, sqlCon);
                string noSocio = "CREATE TABLE IF NOT EXISTS nosocio(nombre varchar(50),apellido varchar(50),direccion varchar(50),mail varchar(50),telefono varchar(20),dni int PRIMARY KEY,apto boolean);";
                MySqlCommand comandoNoSocio = new MySqlCommand(noSocio, sqlCon);
                string roles = "CREATE TABLE IF NOT EXISTS roles(RolUsu int PRIMARY KEY,NomRol varchar(30));";
                MySqlCommand comandoRoles = new MySqlCommand(roles, sqlCon);
                string usuario = "CREATE TABLE IF NOT EXISTS usuario(nombre varchar(50) PRIMARY KEY,passw varchar(50),activo boolean,rol int,FOREIGN KEY (rol) REFERENCES roles(RolUsu));";
                MySqlCommand comandoUsuario = new MySqlCommand(usuario, sqlCon);
                string ingresoRoles = "INSERT INTO roles VALUES(120,'Administrador'),(121,'Empleado');";
                MySqlCommand comandoIngresoRoles = new MySqlCommand(ingresoRoles, sqlCon);
                string cargaAdmin = "INSERT INTO usuario VALUES(\"usuario\",\"contraseña\",true,120);";
                MySqlCommand comandoCargaAdmin = new MySqlCommand(cargaAdmin, sqlCon);
                string procIngSocio = "CREATE procedure ingresarSocio(IN nom varchar(50), IN ape varchar(50), IN dir varchar(50), IN mail varchar(50), IN tel varchar(20), IN pdni int, IN apto boolean, OUT exito boolean) BEGIN declare existe int; set exito = false; set existe = (SELECT count(*) FROM socio WHERE dni LIKE pdni);  IF  existe < 1 THEN INSERT INTO socio VALUES(nom, ape, dir, mail, tel, pdni, apto); set exito = True; END IF; END ";
                MySqlScript comandoProcIngSocio = new MySqlScript(sqlCon, procIngSocio);
                string procIngNoSocio = "CREATE procedure ingresarNoSocio(IN nom varchar(50), IN ape varchar(50), IN dir varchar(50), IN mail varchar(50), IN tel varchar(20), IN pdni int, IN apto boolean, OUT exito boolean) BEGIN declare existe int; set exito = false; set existe = (SELECT count(*) FROM nosocio WHERE dni LIKE pdni);  IF  existe < 1 THEN INSERT INTO nosocio VALUES(nom, ape, dir, mail, tel, pdni, apto); set exito = True; END IF; END ";
                MySqlScript comandoProcIngNoSocio = new MySqlScript(sqlCon, procIngNoSocio);
                string procLogin = "CREATE procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15)) BEGIN SELECT NomRol FROM usuario INNER JOIN roles ON Rol = RolUsu WHERE nombre = Usu AND passw = Pass  AND Activo = 1; END  //";
                MySqlScript comandoProcLogin = new MySqlScript(sqlCon, procLogin);
                comandoProcLogin.Delimiter = "//";
                comandoProcIngSocio.Delimiter = "//";
                comandoProcIngNoSocio.Delimiter = "//";


                comandoBase.ExecuteNonQuery();
                comandoSocio.ExecuteNonQuery();
                comandoNoSocio.ExecuteNonQuery();
                comandoRoles.ExecuteNonQuery();
                comandoUsuario.ExecuteNonQuery();
                comandoIngresoRoles.ExecuteNonQuery();
                comandoCargaAdmin.ExecuteNonQuery();
                comandoProcIngSocio.Execute();
                comandoProcIngNoSocio.Execute();
                comandoProcLogin.Execute();
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
