using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudMysqlCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CAlumnos alumnos = new Clases.CAlumnos();
            alumnos.ShowAlumnos(dgvTotalAlumns);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos alumnos = new Clases.CAlumnos();
            alumnos.SaveAlumnos(txtName,txtLastName);
            alumnos.ShowAlumnos(dgvTotalAlumns);
        }

        private void dgvTotalAlumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTotalAlumns_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CAlumnos alumnos = new Clases.CAlumnos();
            alumnos.SeleccionarAlumnos(dgvTotalAlumns, txtId, txtName, txtLastName);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos alumnos = new Clases.CAlumnos();
            alumnos.editAlumnos(txtId,txtName, txtLastName);
            alumnos.ShowAlumnos(dgvTotalAlumns);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos alumnos = new Clases.CAlumnos();
            alumnos.deleteAlumnos(txtId);
            alumnos.ShowAlumnos(dgvTotalAlumns);
        }
    }
}
