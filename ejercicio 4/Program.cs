using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Genere una contraseña: ");
            string contra = Console.ReadLine();

            int intentos = 3;
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("---    Valida tu contraseña   ---");
            Console.WriteLine("---------------------------------\n");
            while (intentos > 0) 
            {
               Console.WriteLine("Ingrese tu contraseña: ");
               string pass = Console.ReadLine();

                if (contra == pass)
                {
                    Console.WriteLine("\nAcceso concedido");
                    return;
                }
                else 
                {
                    Console.WriteLine($"\nContraseña incorrecta le resta {intentos} intentos");
                    intentos--;
                }
            }
            Console.WriteLine("Acceso denegado ya termino todos sus intentos");
            Console.ReadKey();
        }
    }
}
