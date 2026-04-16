using BLL.UniversidadTresCapas;
using BLL.UniversidadTresCapas.Excepciones;
using Entidades.UniversidadTresCapas;
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
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void LimpiarCampos()
		{
			txtNombreCarrera.Text = string.Empty;
			txtNombreDecano.Text = string.Empty;

			txtNombreCarrera.Focus();
		}
		private void btnCrearCarrera_Click(object sender, EventArgs e)
		{
			CarreraNegocio objGestorCarrera = new CarreraNegocio();

			CarreraBE entidadNueva = new CarreraBE();
			entidadNueva.NombreDecano = txtNombreDecano.Text;
			entidadNueva.Nombre=txtNombreCarrera.Text;

			try { 
				if (objGestorCarrera.CrearCarrera(entidadNueva))
				{
					MessageBox.Show("¡Se ha creado una nueva carrera!");
				}
				else
				{
					MessageBox.Show("¡Caramba, no se ha podido crear la nueva carrera!");
				}
            }catch(ExcepcionDeNegocio ex)
            {
                MessageBox.Show(ex.MensajeNegocio);
            }

            LimpiarCampos();
		}

		private void btnVerCarreras_Click(object sender, EventArgs e)
		{
			frmListarCarreras frmListar = new frmListarCarreras();
			frmListar.Show();
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			CarreraNegocio gestorNegocio = new CarreraNegocio();
			List<CarreraBE> listaCarreras = gestorNegocio.ListarCarreras();

			cboxCarreras.DataSource = listaCarreras;
			cboxCarreras.DisplayMember = "Nombre";
			cboxCarreras.ValueMember = "NombreDecano";
		}

		private void btnVerDatosCarrera_Click(object sender, EventArgs e)
		{
			CarreraBE carreraSeleccionada = (CarreraBE)cboxCarreras.SelectedItem;

			MessageBox.Show(carreraSeleccionada	.Nombre);
		}
	}
}
