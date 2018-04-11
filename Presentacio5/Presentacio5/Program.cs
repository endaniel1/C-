using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacio5
{
	class Program
	{
		static void Main (string[] args)
		{
			clsEmpleados empleado;
			empleado = new clsEmpleados ();
			empleado.Edad = 20;
			empleado.Nombre="Enrique";
			empleado.Sueldo_Diario =12.5m;

			decimal total;
			total = empleado.CalculaSalario (30);
			Console.WriteLine ("el empleado "+empleado.Nombre);
			Console.WriteLine ("sueldo es "+total.ToString("C"));
			Console.ReadKey ();
		}
	}
}
