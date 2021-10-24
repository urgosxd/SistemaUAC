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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textHorario_TextChanged(object sender, EventArgs e)
        {

        }
        private Laboratorio laboratio = new Laboratorio();
        private void btnEscribir_Click(object sender, EventArgs e)
        {

            string horario = textHorario.Text.Trim();
            string aforo = textAforo.Text.Trim();
            string[] materiales = textMateriales.Text.Split(',');
            string docente = textDocente.Text.Trim();
            string ubicacion = textUbicacion.Text.Trim();

            laboratio.Horario = horario;
            laboratio.Aforo = aforo;
            laboratio.Materiales = materiales;
            laboratio.Docente = docente;
            laboratio.Ubicacion = ubicacion;

            MessageBox.Show("Se ha escrito correctamente en el objeto");

            textHorario.Clear();
            textAforo.Clear();
            textMateriales.Clear();
            textDocente.Clear();
            textUbicacion.Clear();

            textHorario.Focus();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string horario = laboratio.Horario;
            string aforo = laboratio.Aforo;
            string[] materiales = laboratio.Materiales;
            string docente = laboratio.Docente;
            string ubicacion = laboratio.Ubicacion;

            MessageBox.Show("Datos Laboratorio" + "\n" + "horario" + horario + "\n"
                + "aforo" + "\n" + aforo+"\n"+"materiales"+"\n"+String.Join(", ",materiales)+"\n"+"docente" + "\n" + docente+"\n"+"ubicacion"+ubicacion);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratio.Descubrir());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratio.Operar());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratio.Investigar());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
