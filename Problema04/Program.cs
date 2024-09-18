using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main()
        {
            Obrero obrero1 = new Obrero(123, "Luis", 24, 10);

            Obrero.mostrar_info(obrero1);

            Console.WriteLine("======== CON AUMENTO DE HORAS Y DISMINUCIÓN DE TARIFA ========\n");
            obrero1.descuento_tarifa();
            obrero1.aumento_horas_trabajadas();
            Obrero.mostrar_info(obrero1);

           Console.ReadKey();

        }
    }
}
