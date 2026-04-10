using Entidades.UniversidadTresCapas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UniversidadTresCapas
{
	public class MateriaDAL
	{
		public List<string> ListarMateriasHardcoding()
		{
			List<string> misMaterias = new List<string>();

			misMaterias.Add("Matematica");
			misMaterias.Add("Lengua");
			misMaterias.Add("Ingles");
			misMaterias.Add("Técnicas de Programación");

			return misMaterias;
		}


		public List<MateriaBE> ListarMateriasPorCarrera(CarreraBE carrera)
		{ 	
			Conexion objConexion = new Conexion();
			SqlParameter[] misParametros = new SqlParameter[1];
			misParametros[0] = objConexion.crearParametro("@idCarrera", carrera.ID);
			List<MateriaBE> listaRetorno = new List<MateriaBE>();
			foreach (DataRow fila in objConexion.LeerPorStoreProcedure("SP_LISTAR_MATERIAS_POR_ID_CARRERA", misParametros).Rows)
			{
				MateriaBE objMateria = new MateriaBE();
				objMateria.ID = Convert.ToInt32(fila["id"]);
				objMateria.Nombre = fila["nombre"].ToString();
				listaRetorno.Add(objMateria);
			}


			return listaRetorno;

		}

		public bool CrearCarrera(CarreraBE carreraEntidad)
		{
			Conexion objConexion = new Conexion();
			
			string miComando = "INSERT INTO tCARRERA (nombre, nombreDecano) VALUES (\'" + carreraEntidad.Nombre +  "\', \'" + carreraEntidad.NombreDecano + "\' );";
			return (objConexion.EscribirPorComando(miComando) == 1);
		}
	}
}
