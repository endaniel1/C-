using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Herencias de clases
namespace Presentacion6
{
	class Program
	{
		public static void Main (string[] args)
		{
			clsClienteVenta Cliente;
			Cliente = new clsClienteVenta ();
			Cliente.IdCliente = 135;
			Cliente.Apellidos="Rodriguez Mendez";
			Cliente.Nombres="Enrique Daniel";
			Cliente.RFC = "RC#";
			Cliente.Direccion = "Palo Negro";
			Cliente.Municipio = "Santa Elena";
			Cliente.Colonia = "ni idea q colonia es";
			Cliente.EsCredito = true;
			Console.WriteLine (Cliente.Apellidos + " "+ Cliente.Nombres);

			Console.WriteLine (Cliente.Direccion + " "+ Cliente.Colonia + " " + Cliente.Municipio);

			Console.WriteLine (Cliente.RFC);

			if(Cliente.EsCredito)
				Console.WriteLine ("El Cliente Tiene Credito");
			else
				Console.WriteLine ("El Cliente No  Tiene Credito");
			Console.ReadKey ();	
		}
	}
}
