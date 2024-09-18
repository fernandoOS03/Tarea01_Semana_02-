using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema08
{
    internal class Asesor
    {

        private int codigo;
        private string nombre;
        private int horas_trabajadas;
        private double tarifa_hora;

        public Asesor(int codigo, string nombre, int horas_trabajadas, double tarifa_hora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas_trabajadas = horas_trabajadas;
            this.tarifa_hora = tarifa_hora;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Horas_trabajadas { get => horas_trabajadas; set => horas_trabajadas = value; }
        public double Tarifa_hora { get => tarifa_hora; set => tarifa_hora = value; }

        public double sueldo_bruto()
        {
            return horas_trabajadas * tarifa_hora;
        }

        public double descuento()
        {
            return sueldo_bruto() * 0.15;
        }

        public double sueldo_neto()
        {
            return sueldo_bruto() - descuento();
        }

        public double disminucion_tarifa()
        {
            return Tarifa_hora -= 0.015;
        }
        public double aumento_horas()
        {
            return Horas_trabajadas = horas_trabajadas + 10;
        }


        public static void mostrar_datos(Asesor asesor)
        {
            Console.WriteLine($"==============INFORMACIÓN DEL ASESOR ==============");
            Console.WriteLine($"Código           :{asesor.Codigo}");
            Console.WriteLine($"Nombre           :{asesor.Nombre}");
            Console.WriteLine($"Horas Trabajadas :{asesor.Horas_trabajadas}");
            Console.WriteLine($"Tarifa por Hora  :{asesor.Tarifa_hora}");
            Console.WriteLine($"Sueldo Buto      :{asesor.sueldo_bruto()}");
            Console.WriteLine($"Descuento        :{asesor.descuento()}");
            Console.WriteLine($"Sueldo Neto      :{asesor.sueldo_neto()}");
            Console.WriteLine($"-------------------------------------------------\n");

        }

    }
}
