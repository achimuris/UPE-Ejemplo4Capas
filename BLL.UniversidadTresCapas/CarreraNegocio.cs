using Entidades.UniversidadTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.UniversidadTresCapas;
using BLL.UniversidadTresCapas.Excepciones;

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
            ValidarCarrera(carreraEntidad);
            DAL.UniversidadTresCapas.MateriaDAL materiaDAL = new DAL.UniversidadTresCapas.MateriaDAL();
			return materiaDAL.CrearCarrera(carreraEntidad);
		}


		public List<Entidades.UniversidadTresCapas.MateriaBE> ListarMaterias(Entidades.UniversidadTresCapas.CarreraBE carreraEntidad)
		{
			List<Entidades.UniversidadTresCapas.MateriaBE> listaRetorno = new List<Entidades.UniversidadTresCapas.MateriaBE>();
			DAL.UniversidadTresCapas.MateriaDAL materiaDAL = new DAL.UniversidadTresCapas.MateriaDAL();
			
			return materiaDAL.ListarMateriasPorCarrera(carreraEntidad);

		}

		public void ValidarCarrera(CarreraBE carreraEntidad)
		{
            if (string.IsNullOrEmpty(carreraEntidad.Nombre))
            {
                throw new ExcepcionDeNegocio("El nombre de la carrera no puede ser vacío");
            }
            if (string.IsNullOrEmpty(carreraEntidad.NombreDecano))
            {
                throw new ExcepcionDeNegocio("El nombre del decano no puede ser vacío");
            }
            if (carreraEntidad.Nombre.Length < 5)
            {
                throw new ExcepcionDeNegocio("El nombre de la carrera no puede tener menos de 5 caracteres");
            }
            if (carreraEntidad.Nombre.Length > 50)
            {
                throw new ExcepcionDeNegocio("El nombre de la carrera no puede superar los 50 caracteres");
            }

        }
	}
}
