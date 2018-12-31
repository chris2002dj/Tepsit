using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tepsit
{
    class Program
    {
        static void Main(string[] args)
        { 
            int a = int.MaxValue;
            Console.WriteLine(a); //Rappresenta il numero massimo supportato dall'int 
            Console.WriteLine(a + 1); //Rappresenta il numero minimo supportato aggiungendo +1
            int b = -128; //HO dato come valore -128 nell'int b
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2)); //Il valore c lo divido in base 2
            int value = 31;
            int somma = value;
            value = ~value + 1; //NOT
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
            Console.ReadLine();
        }
    }
}
