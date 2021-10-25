using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //Declarar un objeto a partir de la clase 
        private JefePractica jefePractica = new JefePractica();

        private void btnExcribir_Click(object sender, EventArgs e)
        {
            {
                //Leer datos
                string dni = txtDni.Text.Trim();
                string apellidos = txtApellidos.Text.Trim();
                string nombres = txtNombres.Text.Trim();
                string superiorDocente = txtSuperiorDocente.Text.Trim();
                string actividades = txtActividades.Text.Trim();
                //Escribir los datos del alumno
                jefePractica.Dni = dni;
                jefePractica.Apellidos = apellidos;
                jefePractica.Nombres = nombres;
                jefePractica.SuperiorDocente = superiorDocente;
                jefePractica.Actividades = actividades;
                //Confirmar que se ah escrito en el objeto
                MessageBox.Show("***Se ah escrito correctamente en el objeto***");
                //Limpiar la caja de texto
                txtDni.Clear();
                txtApellidos.Clear();
                txtNombres.Clear();
                txtSuperiorDocente.Clear();
                txtActividades.Clear();
                //Hacer que el mouse este en apellidos
                txtDni.Focus();
            }

        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades de la clase Alumno
            string dni = jefePractica.Dni;
            string apellidos = jefePractica.Apellidos;
            string nombres = jefePractica.Nombres;
            string superiorDocente = jefePractica.SuperiorDocente;
            string actividades = jefePractica.Actividades;
            MessageBox.Show("                    DATOS DE ASIGNATURA" + "\n" + "\n" + "Dni: " + dni + "\n" +
                "Apellidos: " + apellidos + "\n" + "Nombres: " + nombres + "\n" + "SuperiorDocente " + superiorDocente + "\n"
                + "Actividades" + actividades);
        }

        private void Metodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Cooperar());
        }

        private void Metodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Reemplazar());
        }

        private void Metodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Enseñar());
        }

        private void Metodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Asesorar());
        }

        private void Metodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.TomarExamen());
        }
    }

}
