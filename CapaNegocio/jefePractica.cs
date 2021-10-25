using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
	public class JefePractica
	{
		//Declarar atributos
		private string dni;
		private string apellidos;
		private string nombres;
		private string superiorDocente;
		private string actividades;
		//Propiedades para los atributos
		public string Dni
		{
			get { return dni; }
			set { dni = value; }
		}
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
		public string SuperiorDocente
		{
			get { return superiorDocente; }
			set { superiorDocente = value; }
		}
		public string Actividades
		{
			get { return actividades; }
			set { actividades = value; }
		}
		//Declaracion de metodos u operaciones
		public string Cooperar()
		{
			return "Este metodo será implementado";
		}
		public string Reemplazar()
		{
			return "Este metodo será implementado";
		}
		public string Enseñar()
		{
			return "Este metodo será implementado";
		}
		public string Asesorar()
		{
			return "Este metodo será implementado";
		}
		public string TomarExamen()
		{
			return "Este metodo será implementado";
		}
	}

}
