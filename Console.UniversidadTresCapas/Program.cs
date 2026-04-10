using BLL.UniversidadTresCapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.UniversidadTresCapas
{
	public class Program
	{
		static void Main(string[] args)
		{

			//Estamos en la capa de presentación
			Carrera miCarrera = new Carrera() { ID = 1, Nombre = "Analista Programador Universitario", Materias = new List<Materia>() };


			//Llamamos a la capa de lógica de negocios para que nos cargue las materias de la carrera
			//internamente la capa de lógica de negocios se comunicará con la capa de acceso a datos para obtener la información de las materias
			miCarrera.CargarMaterias();

			foreach (Materia materia in miCarrera.Materias)
			{
				System.Console.WriteLine("ID Carrera " + miCarrera.ID +  " - Materia ID: " + materia.ID + " - Nombre: " + materia.Nombre);
			}

			System.Console.WriteLine("¿Desea crear una carrera? (S o N)");
			string respuesta = System.Console.ReadLine();
			if (respuesta.ToUpper() == "S")
			{
				System.Console.WriteLine("Ingrese el nombre de la carrera:");
				string nombreCarrera = System.Console.ReadLine();
				Carrera nuevaCarrera = new Carrera();

				if (nuevaCarrera.CrearCarrera(nombreCarrera, "Nombre decano"))
					System.Console.WriteLine("Carrera creada con éxito");
				else
					System.Console.WriteLine("No se pudo crear la carrera");	
			}
			


		}
	}
}
