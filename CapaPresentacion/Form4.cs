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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Asignatura asignatura = new Asignatura();
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text.Trim();
            string docente= textDocente.Text.Trim();
            string creditos = textCreditos.Text.Trim();
            string horario = textHorario.Text.Trim();
            string[] temas = textTemas.Text.Split(',');

            asignatura.Nombre = nombre;
            asignatura.Docente = docente;
            asignatura.Creditos = creditos;
            asignatura.Horario = horario;
            asignatura.Temas = temas;

            MessageBox.Show("Se ha escrito correctamente en el objeto");

            textNombre.Clear();
            textDocente.Clear();
            textCreditos.Clear();
            textHorario.Clear();
            textTemas.Clear();

            textNombre.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textHorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Enseñar());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Aprender());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Investigar());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombre = asignatura.Nombre;
            string docente = asignatura.Docente;
            string creditos = asignatura.Creditos;
            string horario = asignatura.Horario;
            string[] temas = asignatura.Temas;

            MessageBox.Show("Datos Asignatura" + "\n" + "nombre" + "\n" + nombre + "\n"
                + "docente" + "\n" + docente + "\n" + "creditos" + "\n" + creditos + "\n" + "horario" + "\n" + horario + "\n" + "temas" + "\n" + String.Join(", ",temas)    );
        

    }
}
}
