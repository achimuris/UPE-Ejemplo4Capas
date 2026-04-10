using Entidades.UniversidadTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.UniversidadTresCapas;

namespace BLL.UniversidadTresCapas
{
	public class CarreraNegocio
	{


		public List<CarreraBE> ListarCarreras()
		{ 
		
			CarreraDAL carreraDAL = new CarreraDAL();

			return carreraDAL.ListarCarreras();
		}


		public bool CrearCarrera(CarreraBE carreraEntidad)
		{
			DAL.UniversidadTresCapas.MateriaDAL materiaDAL = new DAL.UniversidadTresCapas.MateriaDAL();
			return materiaDAL.CrearCarrera(carreraEntidad);
		}


		public List<Entidades.UniversidadTresCapas.MateriaBE> ListarMaterias(Entidades.UniversidadTresCapas.CarreraBE carreraEntidad)
		{
			List<Entidades.UniversidadTresCapas.MateriaBE> listaRetorno = new List<Entidades.UniversidadTresCapas.MateriaBE>();
			DAL.UniversidadTresCapas.MateriaDAL materiaDAL = new DAL.UniversidadTresCapas.MateriaDAL();
			
			return materiaDAL.ListarMateriasPorCarrera(carreraEntidad);

		}
	}
}
