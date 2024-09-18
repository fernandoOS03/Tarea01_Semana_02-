using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Paciente
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Talla { get => talla; set => talla = value; }
        public double Peso { get => peso; set => peso = value; }

        public string estado_edad()
        { 
            if (edad >= 18)
            {
               return("Mayor de edad");
            }

            else
            {
               return("Menor de edad");
            }

        }

        public static void mostrar_info(Paciente paciente)
        {
            Console.WriteLine($"==============INFORMACIÓN DEL PACIENTE ==============");
            Console.WriteLine($"Nombre   :{paciente.Nombre}");
            Console.WriteLine($"Apellido :{paciente.Apellido}");
            Console.WriteLine($"Edad     :{paciente.Edad}");
            Console.WriteLine($"Talla    :{paciente.Talla}");
            Console.WriteLine($"Peso     :{paciente.Peso}");
            Console.WriteLine($"Estado   :{paciente.estado_edad()}");
            Console.WriteLine($"-------------------------------------------------\n");
        }

    }
}
