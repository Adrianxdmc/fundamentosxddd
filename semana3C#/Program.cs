using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3C_
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey();
        }

        static void ejer3()
        {
            Console.WriteLine("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y: ");
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            double divi = (double)x / (double)y;

            Console.WriteLine("\nSuma: "+sum);
            Console.WriteLine("\nResta: " + (x - y));
            Console.WriteLine("\nMulti: " + (x * y));
            Console.WriteLine("\nDivi: " + (x / y)+ divi);
        }
    }
}