using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Empleado
    {

        private int codigo;
        private string nombre;
        private int nmro_cel;
        private double sueldo;

        public Empleado(int codigo, string nombre, int nmro_cel, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.nmro_cel = nmro_cel;
            this.sueldo = sueldo;
        }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nmro_cel { get => nmro_cel; set => nmro_cel = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public string rango_sueldo()
        {
            if (Sueldo > 3500.00)
            {
                return "mayor a 3500";
            }
            else if (Sueldo < 3500.00)
            {
                return "menor a 3500.00";
            }
            else 
            { return "igual a 3500"; }
        }

        public double aumento_sueldo()
        {
            return Sueldo = Sueldo + 200;
       }

        public static void mostrar_datos(Empleado empleado) 
        {
            Console.WriteLine($"==============INFORMACIÓN DEL EMPLEADO ==============");
            Console.WriteLine($"Código        :{empleado.Codigo}");
            Console.WriteLine($"Nombre        :{empleado.Nombre}");
            Console.WriteLine($"N° de Celular :{empleado.Nmro_cel}");
            Console.WriteLine($"Sueldo        :{empleado.Sueldo}");
            Console.WriteLine($"Su sueldo es {empleado.rango_sueldo()}");
            Console.WriteLine($"-------------------------------------------------\n");

        }
    }
}
