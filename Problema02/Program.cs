using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora obcomputadora1 = new Computadora(123, "Samsung", "Blanco", 100.00);        

            Computadora.mostrar_datos(obcomputadora1);
            obcomputadora1.disminuir_precio();

            Console.WriteLine("===============PRECIO CON 10% DE DESCUENTO===============");
           
            Computadora.mostrar_datos(obcomputadora1);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
