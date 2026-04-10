using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UniversidadTresCapas
{
	public class Carrera
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

		private List<Materia> materias;

		public List<Materia> Materias
		{
			get { return materias; }
			set { materias = value; }
		}


		public bool CrearCarrera(string nombreCarrera, string nombreDecano)
		{
			DAL.UniversidadTresCapas.Materia materiaDAL = new DAL.UniversidadTresCapas.Materia();
			return materiaDAL.CrearCarrera(nombreCarrera, nombreDecano);
		}

		public void CargarMaterias()
		{ 
		
			DAL.UniversidadTresCapas.Materia materiaDAL = new DAL.UniversidadTresCapas.Materia();

			this.Materias = new List<Materia>();
			foreach (DataRow fila in materiaDAL.ListarMateriasDataTable().Rows)
			{
				this.materias.Add(new Materia() { ID = Convert.ToInt32(fila["ID_materia"]), Nombre = fila["Nombre_materia"].ToString() });
			}

			//ESto lo hace hardcoding
			//int idInventado = 1;
			//foreach (string materia in materiaDAL.ListarMateriasHardcoding())
			//{
			//	this.materias.Add(new Materia() { ID = idInventado, Nombre = materia });
			//	idInventado++;
			//}



		}

	}
}
