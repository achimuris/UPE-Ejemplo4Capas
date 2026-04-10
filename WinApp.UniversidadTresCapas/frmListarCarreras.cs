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
using Entidades.UniversidadTresCapas;

namespace WinApp.UniversidadTresCapas
{
	public partial class frmListarCarreras : Form
	{
		public frmListarCarreras()
		{
			InitializeComponent();
		}

		private void frmListarCarreras_Load(object sender, EventArgs e)
		{
			CarreraNegocio gestorNegocio = new CarreraNegocio();
			List<CarreraBE> listaCarreras = gestorNegocio.ListarCarreras();

			dgvCarreras.DataSource = listaCarreras;
			dgvCarreras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			
		}
	}
}
