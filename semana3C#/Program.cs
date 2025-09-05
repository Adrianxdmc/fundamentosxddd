using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3C_
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey(); 
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }