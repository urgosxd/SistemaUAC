using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        // Declaracion de atributos
        private DateTime horario;
        private int aforo;
        private string[] materiales;
        private string docente;
        private string ubicacion;

        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Horario
        {
            get { return horario.ToString(); }
            set { horario =Convert.ToDateTime(value); }
        }
        public string Aforo
        {
            get { return aforo.ToString(); }
            set { aforo = int.Parse(value); }
        }
        public string[] Materiales
        {
            get { return materiales; }
            set { materiales = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
       

        // Declaracion de metodos u operaciones
        public string Investigar()
        {
            return "El metodo investigar recien será implementado";
        }
        public string Operar()
        {
            return "El metodo operar recien sera implementado";
        }
        public string Descubrir()
        {
            return "El metodo descubrir recien sera implementado";
        }

    }
}
