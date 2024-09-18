using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular Ob_celular = new Celular(123123, "Fernando", 50, 30.23);

            Console.WriteLine("Numero de Usuario : " + Ob_celular.Numero);
            Console.WriteLine("Nombre de Usuario : " + Ob_celular.Usuario);
            Console.WriteLine("Segundos Consumidos: " + Ob_celular.Segundos_consumidos);
            Console.WriteLine("Precio por Segundo : " + Ob_celular.Precio_segundo);
            Console.WriteLine("IGV : " + Ob_celular.impuesto_igv());
            Console.WriteLine("Total a pagar : " + Ob_celular.total_pagar());

            Console.ReadKey();
        }
    }
}
