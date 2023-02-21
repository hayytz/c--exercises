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
            Console.WriteLine("ingresar el sueldo");
            double sueldo = double.Parse(Console.ReadLine());

            if(sueldo > 3000) {
                
            Console.WriteLine("su sueldo es de Q" + sueldo + " y debe pagar la cantidad de impuestos siguiente: " + sueldo * 0.05);
            } else {
                Console.WriteLine("No debe pagar impuestos");
            }

            Console.ReadLine();

        }
    }
}
