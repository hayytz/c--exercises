using System;

class Program
{
    static void Main() {
     
     Console.WriteLine("Ingrese numero");
     int n = Convert.ToInt32(Console.ReadLine());
     
     int resultado = n % 23;
     
      switch (resultado){
            case 0: Console.WriteLine("T");
            break;
            case 1: Console.WriteLine("R");
            break;
            case 2: Console.WriteLine("W");
            break;
            case 3: Console.WriteLine("A");
            break;
            case 4: Console.WriteLine("G");
            break;
            case 5: Console.WriteLine("M");
            break;
            case 6: Console.WriteLine("Y");
            break;
            case 7: Console.WriteLine("F");
            break;
            case 8: Console.WriteLine("P");
            break;
            case 9: Console.WriteLine("D");
            break;
            case 10: Console.WriteLine("X");
            break;
            case 11: Console.WriteLine("B");
            break;
            case 12: Console.WriteLine("N");
            break;
            case 13: Console.WriteLine("J");
            break;
            case 14: Console.WriteLine("Z");
            break;
            case 15: Console.WriteLine("S");
            break;
            case 16: Console.WriteLine("Q");
            break;
            case 17: Console.WriteLine("V");
            break;
            case 18: Console.WriteLine("H");
            break;
            case 19: Console.WriteLine("L");
            break;
            case 20: Console.WriteLine("C");
            break;
            case 21: Console.WriteLine("K");
            break;
            case 22: Console.WriteLine("E");
            break;
            case 23: Console.WriteLine("T");
            break;
            default: Console.WriteLine("Numero invalido");
            break;
        }
     
    }
}