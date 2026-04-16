using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UniversidadTresCapas.Excepciones
{
    public class ExcepcionDeNegocio : Exception
    {
		private string _mensajeNegocio;

		public string MensajeNegocio
		{
			get { return _mensajeNegocio; }
			set { _mensajeNegocio = value; }
		}

		public ExcepcionDeNegocio(string mensajeNegocio)
		{
			_mensajeNegocio = mensajeNegocio;
		}
	}
}
