using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios07
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* recorre los numeros del 1 al 100*/
            int i = 1;
            Console.WriteLine("los numeros del 1 al 100");
            while (i <= 100)
            {
                Console.Write(i + "  ");
                i++;
            }
            
            Console.ReadLine();
        }
    }
}
