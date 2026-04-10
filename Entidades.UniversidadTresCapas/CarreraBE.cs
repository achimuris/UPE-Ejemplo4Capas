using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.UniversidadTresCapas
{
    public class CarreraBE
    {
		private int identificador;

		public int ID
		{
			get { return identificador; }
			set { identificador = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		private string _nombreDecano;

		public string NombreDecano
		{
			get { return _nombreDecano; }
			set { _nombreDecano = value; }
		}


		private List<MateriaBE> materias;

		public List<MateriaBE> Materias
		{
			get { return materias; }
			set { materias = value; }
		}
	}
}
