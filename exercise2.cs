using System;

namespace EjerciciosCsharp
{
	public class Program
	{
		public static void Main(string[] args)
		{
		 
		 string nombre;
		 int edad; 
		 
		 Console.WriteLine("Ingrese un nombre");
		 nombre = Console.ReadLine();
		 
		 if(nombre == ""){
		   Console.WriteLine("No ingreso ningun nombre");
		 } else {
		   Console.WriteLine("Bienvenido " + nombre);
		 }
		 
		}
	}
}