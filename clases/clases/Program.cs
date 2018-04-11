using System;

namespace clases
{
	//estructura para guardar animal
	struct structAnimal{
		public string nombre;

		public structAnimal(string nombre){
			this.nombre=nombre;
		}

		public void info(){
			Console.WriteLine("Nombre del Animal ->"+nombre);
		}

	}
	//clase para guardar animal
	class claseAnimal{
		public string nombre;

		public claseAnimal(string nombre){
			this.nombre=nombre;
		}

		public void info(){
			Console.WriteLine("Nombre del Animal ->"+nombre);
		}
	}

	class Animal{
		
		public string nombre;
		private double peso;
		public double Peso{
			get{ return peso; }
			set{ 
				if(value
					>0){
					peso = value;
				}else{
					Console.WriteLine ("El valor no puede ser menor a 0");
				}
			}

		}

		protected string sonido;
		public string Sonido{
			get{ return sonido; }
			set{ sonido=value; }

		}

		//constructor por defecto
		public Animal(){
			this.nombre="";
			this.peso=0;
			this.sonido="";

		}

		//constructor por parametros
		public Animal(string nombre,double peso,string sonido){
			this.nombre=nombre;
			this.Peso=peso;
			this.Sonido=sonido;
		}

		//metodo de clase
		public void info(){
			//Console.WriteLine ("Nombre -->"+nombre);
			//Console.WriteLine ("Peso -->"+this.Peso);
			//Console.WriteLine ("Sonido -->"+this.Sonido);
			Console.WriteLine("Nombre -->{0} Peso --> {1} Sonido -->{2}",this.nombre,this.Peso,this.Peso);
		}

		//metoo escpcial de clases
		public override string ToString ()
		{
			return "nombre -->"+ nombre;
		}
	}

	class Pajaro : Animal{

		public bool vuela;
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			structAnimal sPerro = new structAnimal ("Perro");
			structAnimal sPerroCopia = sPerro;

			sPerro.nombre="Gato";

			sPerro.info ();
			sPerroCopia.info ();

			claseAnimal cPerro = new claseAnimal ("Perro");
			claseAnimal cPerroCopia = cPerro;

			cPerro.nombre="Gato";

			cPerro.info ();
			cPerroCopia.info ();
			*/

			Animal perro = new Animal ("tobi",15,"Guao guao");
			//perro.info ();

			Console.WriteLine (perro);
		
		}
	}
}
