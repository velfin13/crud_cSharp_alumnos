using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudMysqlCsharp.Clases
{
    internal class CAlumnos
    {
        public void ShowAlumnos(DataGridView tablaAlumnos)
        {
            try
            {
                CConexion objConexion = new CConexion();
                string query = "SELECT * FROM ALUMNOS;";
                tablaAlumnos.DataSource = null;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, objConexion.Conectar());
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                tablaAlumnos.DataSource = dataTable;
                objConexion.CerrrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cagar data;" + ex.ToString());
            }
        }

        public void SaveAlumnos(TextBox name, TextBox apellido)
        {
            try
            {
                CConexion objConexion = new CConexion();
                string query = "INSERT INTO ALUMNOS (nombre, apellido) values ('" + name.Text + "','" + apellido.Text + "');";

                MySqlCommand cmd = new MySqlCommand(query, objConexion.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se guardo con exito");

                while (reader.Read())
                {

                }

                objConexion.CerrrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la data;" + ex.ToString());
            }
        }

        public void SeleccionarAlumnos(DataGridView tablaAlumnos, TextBox id, TextBox name, TextBox apellido)
        {
            try
            {
                id.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                name.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar;" + ex.ToString());
            }
        }

        public void editAlumnos(TextBox id, TextBox name, TextBox apellido)
        {
            try
            {
                CConexion objConexion = new CConexion();
                string query = "UPDATE ALUMNOS SET nombre='" + name.Text + "', apellido='" + apellido.Text + "' WHERE id=" + id.Text + ";";

                MySqlCommand cmd = new MySqlCommand(query, objConexion.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se edito con exito");

                while (reader.Read())
                {

                }

                objConexion.CerrrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar la data;" + ex.ToString());
            }
        }
        public void deleteAlumnos(TextBox id)
        {
            try
            {
                CConexion objConexion = new CConexion();
                string query = "DELETE FROM ALUMNOS WHERE id=" + id.Text + ";";

                MySqlCommand cmd = new MySqlCommand(query, objConexion.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se elimino con exito");

                while (reader.Read())
                {

                }

                objConexion.CerrrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la data;" + ex.ToString());
            }
        }
    }
}
