using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Program
    {
        static void Main()            
        {
            Empleado empleado1 = new Empleado( 1001, "Fernando", 987456123, 3500.00);
            Empleado.mostrar_datos(empleado1);

            Console.WriteLine($"=======INFORMACIÓN N° CAMBIADO Y SUELDO AUMENTADO =======\n");
            empleado1.Nmro_cel = 999888777;
            empleado1.aumento_sueldo();
            Empleado.mostrar_datos(empleado1);
            Console.ReadKey();

        }
    }
}
