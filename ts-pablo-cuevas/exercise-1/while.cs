using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            int precioHora;
            string nombre;
            bool seguir = true;
            string peticion;



            while (seguir) {
            Console.WriteLine("Ingresa las horas");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el precio hora");
            precioHora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre");
            nombre = Console.ReadLine();
           
                if (horas <= 40) {
                int salario = horas * precioHora;
                Console.WriteLine(salario);
            } else {
                double salario = 40 * precioHora + 1.5 * precioHora * (horas - 40);
                Console.WriteLine(salario);

            }

                bool seguir2 = true;

                while (seguir2){
                    string peticion2; 
                    Console.WriteLine("Realizar otra operacion? 'si', 'no'");
                    peticion2 = Console.ReadLine().ToLower();

                    if(peticion2 == "si")
                    {
                        seguir2 = false;
                    } else if(peticion2 == "no")
                    {
                        seguir = false;
                        seguir2 = false;
                    }
                } 
                

            }


            Console.ReadLine();

        }
    }
}
