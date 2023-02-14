using System;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  double x = 10;
		  double y = 25;
		  double z = x + y;
		  
		  double w = 4;
		  double a = y / w;
		  
		  double b = y / w;
		  
		  double c = y % w;
		  
		  Console.WriteLine("Sum a" + z);
		  Console.WriteLine("Division " + a);
		  Console.WriteLine("Division b " + b);
		  Console.WriteLine("Modulo c " + c);
		  Console.ReadKey();
		}
	}
}