using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        // Declaracion de atributos
        private string nombre;
        private string docente;
        private int creditos;
        private DateTime horario;
        private string[] temas;
    
        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public string Creditos
        {
            get { return creditos.ToString(); }
            set { creditos = int.Parse(value); }
        }
        public string Horario
        {
            get { return horario.ToString(); }
            set { horario = Convert.ToDateTime(value); }
        }
        public string[] Temas
        {
            get { return temas; }
            set { temas = value; }
        }
       

        // Declaracion de metodos u operaciones
        public string Aprender()
        {
            return "El metodo aprender recien será implementado";
        }
        public string Enseñar()
        {
            return "El metodo enseñar recien sera implementado";
        }
        public string Investigar()
        {
            return "El metodo investigar recien sera implementado";
        }

    }
}
