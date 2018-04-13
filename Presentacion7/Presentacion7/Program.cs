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
			clsClientoConContasto cliente = new clsClientoConContasto (0,"Enrique","1234","ni idea",3,"04123555187","04123555187","04121594525","enriq_1997@hotmail.com","Miranda","ninguno","ninguno","ni idea","libertador","Aragua","2117");

			clsImpresion Impresion = new clsImpresion ();

			Impresion.ImprimeCliente (cliente);
		}
	}
}
