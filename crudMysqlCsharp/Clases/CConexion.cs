using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudMysqlCsharp.Clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();
        static readonly string servidor = "localhost";
        static readonly string db = "crud";
        static readonly string user = "root";
        static readonly string password = "password";
        static readonly string port = "3306";

        string cadenaConexion = "server=" + servidor + ";port=" + port + ";user id=" + user + ";password=" + password + ";database=" + db + ";";



        public MySqlConnection Conectar()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Conexion fallo: " + ex.ToString());
            }

            return conex;
        }

        public MySqlConnection CerrrarConexion()
        {
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion fallo la conexion: " + ex.ToString());
            }

            return conex;
        }
    }
}
