using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{	
	public class clsImpresion 
	{
		public void ImprimeCliente(clsAbsCliente cliente)
		{
			Console.Write (cliente.Clave+" "+cliente.Nombre);
			if(cliente.TipoReglas==1)
				Console.Write ("Tipo Persona Fisica");
			else
				Console.Write ("Tipo Persona Moral");
			
			Console.Write ("RCF: "+cliente.RFC);
			Console.ReadKey ();
		
		}
	}
}

