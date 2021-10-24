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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private Docente docente = new Docente();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = textApellidos.Text.Trim();
            string nombres = textNombres.Text.Trim();
            string celular = textCelular.Text.Trim();
            string correo = textCorreo.Text.Trim();
            string especialidad = textEspecialidad.Text.Trim();
            string curso = textCurso.Text.Trim();

            docente.Apellidos = apellidos;
            docente.Nombres = nombres;
            docente.Celular = celular;
            docente.Correo = correo;
            docente.Especialidad = especialidad;
            docente.Curso = curso;

            MessageBox.Show("Se ha escrito correctamente en el objeto");

            textApellidos.Clear();
            textNombres.Clear();
            textCelular.Clear();     
            textCorreo.Clear();
            textEspecialidad.Clear();
            textCurso.Clear();

            textApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = docente.Apellidos;
            string nombres = docente.Nombres;
            string celular = docente.Celular;
            string correo = docente.Correo;
            string especialidad = docente.Especialidad;
            string curso = docente.Curso;

            MessageBox.Show("Datos Docente"+"\n"+"apellidos" + "\n"+apellidos + "\n"+"nombres" + "\n"+nombres + "\n"+"celular" + "\n"+celular + "\n"+"correo" + "\n"+correo+"especialidad" + "\n"+especialidad + "\n"+"curso" + "\n"+curso);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Aprobar());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Enseñar());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Reprobar());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
