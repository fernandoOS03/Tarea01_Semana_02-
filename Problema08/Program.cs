using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema08
{
    internal class Program
    {
        static void Main()
        {
        Asesor asesor1 = new Asesor(132,"Lucas",48, 20.00);
        Asesor.mostrar_datos(asesor1);

         Console.WriteLine($"======INFORMACIÓN CON AUMENTO DE HORAS Y DISMINUCIÓN DE TARIFA =======\n");
            asesor1.disminucion_tarifa();
            asesor1.aumento_horas();
            Asesor.mostrar_datos(asesor1);

            Console.ReadKey();

        }
    }
}
