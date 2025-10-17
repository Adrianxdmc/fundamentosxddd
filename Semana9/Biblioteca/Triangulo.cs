using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Triangulo
    {
        public void Area() 
        {
            Console.Write("\nIngrese la base: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese la altura: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÁrea: " + (b + h) / 2);
        }
        public void Perimetro() 
        {
            Console.Write("\nIngrese lado 1: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese lado 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese lado 3: ");
            int l3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerimetro: "+(l1+l2+l3));
        }
    }
}
