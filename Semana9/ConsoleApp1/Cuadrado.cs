using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuadrado
    {
        public void Area (int l)
        {
            Console.WriteLine("\nÁrea: " + l + l);
        }
        public void Perimetro(int l)
        {
            Console.WriteLine("\nPerimetro: "+4*l);
        }
    }
}
