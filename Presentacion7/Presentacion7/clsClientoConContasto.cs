using System;

namespace Presentacion7
{
	public class clsClientoConContasto : clsClienteBase
	{
		public clsClientoConContasto ()
		{
			_Dirreccion = new clsDirecciones ();
		}
		public clsClientoConContasto(int pId, string pNombre,string pClave, string pRFC, int pTipoReglas,
									string pNumeroContacto,string pTelefono1,string pTelefono2,string pEmail,
									string pCalle,string pNumeroExterior,string pNumeroInterior,string pColonia,
									string pMunicipio,string pEstado, string pCP)
		{
			Id=pId;
			Nombre=pNombre;
			Clave=pClave;
			RFC=pRFC;
			TipoReglas = pTipoReglas;
			NumeroContacto = pNumeroContacto;
			Telefono1 = pTelefono1;
			Telefono2 = pTelefono2;
			Email = pEmail;

			//antes de utilizar el constructor hay q instancialor denuevo para q no se confundan con el del otro
			_Dirreccion = new clsDirecciones ();
			//como la direcion es un objeto q lo instanciamos se le coloca las caracteristicas
			Dirreccion.Calle = pCalle;
			Dirreccion.NumeroExterior = pNumeroExterior;
			Dirreccion.NumeroInterior = pNumeroInterior;
			Dirreccion.Municipio = pMunicipio;
			Dirreccion.Estado = pEstado;
			Dirreccion.CP = pCP;


		}

		public string Telefono1{ get; set;}

		public string Telefono2{ get; set;}

		public string Email{ get; set;}

		private clsDirecciones _Dirreccion;

		public clsDirecciones Dirreccion 
		{
			get{ return _Dirreccion;}
			set { _Dirreccion= value;}
		}

	}
}

