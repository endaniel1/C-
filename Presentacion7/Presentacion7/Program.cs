using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
	class Program
	{
		public static void Main (string[] args)
		{
			clsClienteBase cliente = new clsClienteBase (0,"Enrique","1234","ni idea",3,"04123555187");

			Console.Write (cliente.Clave+" "+cliente.Nombre);
			Console.Write (cliente.TipoReglas);
			Console.Write (cliente.NumeroContacto);
			Console.ReadKey ();
		}
	}
}
