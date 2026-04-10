using BLL.UniversidadTresCapas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp.UniversidadTresCapas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCrearCarrera_Click(object sender, EventArgs e)
		{
			Carrera objGestionCarrera = new Carrera();
			objGestionCarrera.CargarMaterias();	
			foreach (Materia unaMateria in objGestionCarrera.Materias)
			{
				MessageBox.Show(unaMateria.Nombre);
			}
		}
	}
}
