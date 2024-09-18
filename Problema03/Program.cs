using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Edificio Edifio1 = new Edificio(0001, 50, 4,100);

            Edificio.mostrar_info(Edifio1);
            Edifio1.aumento_precio();

            Console.WriteLine("===============PRECIO CON 20% DE AUMENTO===============");
            Edificio.mostrar_info(Edifio1);

            Console.ReadKey();


        }
    }
}
