using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Program
    {
        static void Main()
        {
            Paciente paciente1 = new Paciente("Fernando", "Olivera", 20, 1.78, 62.5);
            Paciente.mostrar_info(paciente1);

            Console.WriteLine($"======INFORMACIÓN DEL PACIENTE CON EDAD CAMBIADA======\n");

            paciente1.Edad = 10;
            Paciente.mostrar_info(paciente1);
            Console.ReadKey();

        }
    }
}
