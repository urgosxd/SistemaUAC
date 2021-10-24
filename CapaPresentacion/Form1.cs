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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Aprobar());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Matricular());
        }
        private Alumno alumno = new Alumno();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = textApellidos.Text.Trim();
            string nombres = textNombres.Text.Trim();
            string celular = textCelular.Text.Trim();
            string codigo = textCodigo.Text.Trim();
            string correo = textCorreo.Text.Trim();
            string semestreInicio = textSemestreInicio.Text.Trim();
            string escuelaProfesional = textEscuelaProfesional.Text.Trim();

            //Escribir

            alumno.Apellidos = apellidos;
            alumno.Nombres = nombres;
            alumno.Celular = celular;
            alumno.Codigo = codigo;
            alumno.Correo = correo;
            alumno.SemestreInicio = semestreInicio;
            alumno.EscuelaProfesional = escuelaProfesional;

            MessageBox.Show("Se ha escrito correctamente en el objeto");
            textApellidos.Clear();
            textNombres.Clear();
            textCelular.Clear();
            textCodigo.Clear();
            textCorreo.Clear();
            textSemestreInicio.Clear();
            textEscuelaProfesional.Clear();

            textApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = alumno.Apellidos;
            string nombres = alumno.Nombres;
            string celular = alumno.Celular;
            string codigo = alumno.Codigo;
            string correo = alumno.Correo;
            string semestreInicio = alumno.SemestreInicio;
            string escuelaProfesional = alumno.EscuelaProfesional;

             MessageBox.Show("Datos del alumno"
                + "\n"
                + "Apellidos"
                + apellidos
                + "\n"
                + "Nombres"
                + nombres
                + "\n"
                + "Celular"
                + celular
                + "\n"
                + "Codigo"
                + codigo
                + "\n"
                + "Correo"
                + correo
                + "\n"
                + "Semestre Inicio"
                + semestreInicio
                + "\n"
                + "Escuela Profesional"
                + escuelaProfesional);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Estudiar());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
