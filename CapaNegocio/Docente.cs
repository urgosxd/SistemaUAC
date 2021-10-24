using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        // Declaracion de atributos
        private string apellidos;
        private string nombres;
        private string celular;
        private string correo;
        private string especialidad;
        private string curso;
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
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public string Curso
        {
            get { return curso; }
            set {curso = value; }
        }

        // Declaracion de metodos u operaciones
        public string Enseñar()
        {
            return "El metodo Enseñar recien será implementado";
        }
        public string Aprobar()
        {
            return "El metodo Aprobar recien sera implementado";
        }
        public string Reprobar()
        {
            return "El metodo reprobar recien sera implementado";
        }

    }
}
