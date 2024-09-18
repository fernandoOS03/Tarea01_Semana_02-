using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Obrero
    {
        private int codigo { get; set;}
        private string nombre { get; set; }
        private int horas_trabajadas { get; set; }
        private double tarifa_hora { get; set; }

        public Obrero(int codigo, string nombre, int horas_trabajadas, double tarifa_hora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas_trabajadas = horas_trabajadas;
            this.tarifa_hora = tarifa_hora;
        }

        public double sueldo_bruto()
        { 
        return horas_trabajadas * tarifa_hora;
        }

        public double descuento_AFP() 
        {
        return sueldo_bruto() *0.10;
        }

        public double descuento_EPS()
        {
            return sueldo_bruto() * 0.05;
        }

        public double sueldo_neto()
        { 
        return sueldo_bruto() - descuento_AFP() - descuento_AFP();
        }

        public int aumento_horas_trabajadas()
        {
            return horas_trabajadas = horas_trabajadas + 8;
        }

        public double descuento_tarifa()
        { 
        return tarifa_hora -= tarifa_hora * 0.015;
        }

        public static void mostrar_info(Obrero obrero)
        {
            Console.WriteLine($"==============INFORMACIÓN DEL OBRERO ==============");
            Console.WriteLine($"Código del obrero :{obrero.codigo}");
            Console.WriteLine($"Nombre del obrero :{obrero.nombre}");
            Console.WriteLine($"Horas que trabajo :{obrero.horas_trabajadas}");
            Console.WriteLine($"Tarifa por Hora   :{obrero.tarifa_hora}");
            Console.WriteLine($"Sueldo Bruto      :{obrero.sueldo_bruto()}");
            Console.WriteLine($"Descuento AFP     :{obrero.descuento_AFP()}");
            Console.WriteLine($"Descuento EPS     :{obrero.descuento_EPS()}");
            Console.WriteLine($"Sueldo Neto       :{obrero.sueldo_neto()}");
            Console.WriteLine("----------------------------------------------\n");
        }
    }


}
