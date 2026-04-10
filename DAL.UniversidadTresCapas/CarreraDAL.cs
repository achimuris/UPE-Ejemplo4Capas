using Entidades.UniversidadTresCapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UniversidadTresCapas
{
	public class CarreraDAL
	{
		public List<CarreraBE> ListarCarreras()
		{ 
			Conexion objConexion = new Conexion();
			List<CarreraBE> listaRetorno = new List<CarreraBE>();
			foreach (System.Data.DataRow fila in objConexion.LeerPorComando("SELECT * FROM tCarrera").Rows)
			{
				CarreraBE objCarrera = new CarreraBE();

				objCarrera.ID = Convert.ToInt32(fila["ID"]);
				objCarrera.Nombre = fila["NOMBRE"].ToString();
				objCarrera.NombreDecano = fila["NOMBREDECANO"].ToString();
				listaRetorno.Add(objCarrera);
			}


			return listaRetorno;

		}
	}
}
