using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        // Declaracion de atributos
        private string apellidos;
        private string nombres;
        private string celular;
        private string codigo;
        private string correo;
        private string semestreInicio;
        private string escuelaProfesional;
        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string SemestreInicio
        {
            get { return semestreInicio; }
            set { semestreInicio = value; }
        }
        public string EscuelaProfesional
        {
            get { return escuelaProfesional; }
            set { escuelaProfesional = value; }
        }

        // Declaracion de metodos u operaciones
        public string Matricular()
        {
            return "El metodo matricular recien será implementado";
        }
        public string Estudiar()
        {
            return "El metodo estudiar recien sera implementado";
        }
        public string Aprobar()
        {
            return "El metodo aprobar recien sera implementado";
        }

    }
}
