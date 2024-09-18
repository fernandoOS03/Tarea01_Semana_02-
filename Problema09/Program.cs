using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pelota1 = new Pelota("Nike",20.5,50.5, 10.00,1200.50);
            Pelota.mostrar_info(pelota1);

            Console.WriteLine($"======INFORMACIÓN CON DESCUENTO DE PRECIO Y AUMENTO DE MEDIDADA =======\n");
            pelota1.disminuir_precio();
            pelota1.aumentar_dm_cm();
            Pelota.mostrar_info(pelota1);
            Console.ReadLine();
         }
    }
}
