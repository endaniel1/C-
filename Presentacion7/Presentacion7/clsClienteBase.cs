using System;

namespace Presentacion7
{
	public class clsClienteBase : clsAbsCliente
	{
		public override int Id {get; set;}

		public override string Nombre {get; set;}

		public override string Clave {get; set;}

		public override string RFC {get; set;}

		public override int TipoReglas {get; set;}

		public override string NumeroContacto {get; set;}


		public clsClienteBase ()
		{
			Id = 0;
			Nombre = string.Empty;
			Clave = string.Empty;
			RFC = string.Empty;
			TipoReglas = 0;
			NumeroContacto = string.Empty;
		}
		public clsClienteBase(int pId, string pNombre,string pClave, string pRFC, int pTipoReglas,string pNumeroContacto){
			Id=pId;
			Nombre=pNombre;
			Clave=pClave;
			RFC=pRFC;
			TipoReglas = pTipoReglas;
			NumeroContacto = pNumeroContacto;
		}
	}
}

