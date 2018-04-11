using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacio5
{
	public class clsEmpleados
	{
		public clsEmpleados ()
		{
			Nombre = "";
			Sueldo_Diario = 0.0m;
			Edad = 0;
		}

		private string _Nombre;
		public string Nombre
		{
			get{ return _Nombre; }
			set{ _Nombre = value;}
		}

		public decimal Sueldo_Diario{ get; set;}

		public int Edad{ get; set;}

		public decimal CalculaSalario (int NumeroDia)
		{
			return Sueldo_Diario * NumeroDia;
		}
	}
}

