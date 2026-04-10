using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UniversidadTresCapas
{
	public class Materia
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


		public DataTable ListarMateriasDataTable()
		{ 	
			Conexion objConexion = new Conexion();

			//return	objConexion.LeerPorComando("select mate.id as id_materia, mate.nombre as nombre_materia,\r\n\tcarre.nombre as nombre_carrera,\r\n\tcarre.ID as Id_Carrera\r\nfrom \r\n\ttMateria mate, tCarrera carre\r\nwhere carre.ID = mate.ID_CARRERA;");
			return objConexion.LeerPorStoreProcedure("spListarMateriasConCarreras");

		}

		public bool CrearCarrera(string nombreCarrera, string nombreDecano)
		{
			Conexion objConexion = new Conexion();
			
			string miComando = "INSERT INTO tCARRERA (nombre, nombreDecano) VALUES (\'" + nombreCarrera +  "\', \'" + nombreDecano + "\' );";
			return (objConexion.EscribirPorComando(miComando) == 1);
		}
	}
}
