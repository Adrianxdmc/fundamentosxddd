using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace Semana9_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Cuadrado c = new Cuadrado();
            string conti;
            int opc2, opc3;
            do
            {
                Console.Clear();
                menu1();
                do
                {
                    Console.Write("Ingrese una opción: ");
                    opc2 = int.Parse(Console.ReadLine());
                    if (opc2 < 0 & opc2 > 4)
                        Console.WriteLine("Error. Ingrese una opción valida.\n");
                    else break;
                }while (true);

                switch (opc2)
                {
                    case 0: return;
                    case 1:
                        opc3 = menu2();

                        switch (opc3)
                        {
                            case 1: t.Area(); break;
                            case 2: t.Perimetro(); break;
                        }
                        break;
                    case 2:
                        opc3 = menu2();

                        Console.WriteLine("\nIngrese lado: ");
                        int lado = int.Parse(Console.ReadLine());

                        switch (opc3)
                        {
                            case 1: t.Area(lado); break;
                            case 2: t.Perimetro(lado); break;
                        }
                        break;

                    case 3: return;
                    case 4: return;
                }
                do
                {
                    Console.Write("¿Desea  continuar? (s/n)");
                    conti = Console.ReadLine();
                    if (conti != "n" || conti != "s")
                        Console.WriteLine("Error. Ingrese solo s o n.\n");
                    else break;
                } while (true);
            } while (conti == "s");
        }
        static void menu1() 
        {
            Console.WriteLine("Bienvenidos a calculos de áreas y perimetros\n");
            Console.WriteLine("**************** Menú de opciones ************");
            Console.WriteLine("*    1.Triangulo                             *");
            Console.WriteLine("*    2.Cuadrado                              *");
            Console.WriteLine("*    3.Rectangulo                            *");
            Console.WriteLine("*    4.Trapecio                              *");
            Console.WriteLine("**********************************************");
        }
        static void menu2() 
        {
            Console.WriteLine("\n********* Seleccione cálculo **********");
            Console.WriteLine("*    1.Area                             *");
            Console.WriteLine("*    1.Perimetro                        *");
            Console.WriteLine("*****************************************");

            Console.WriteLine("\nIngrese una opción");
            int opc = int.Parse(Console.ReadLine());

            return opc;
        }
    }
}
