using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema09
{
    internal class Pelota
    {
        private string marca;
        private double peso_gramos;
        private double peso_Libras;
        private double diametro_cm;
        private double precio;

        public string Marca { get => marca; set => marca = value; }
        public double Peso_gramos { get => peso_gramos; set => peso_gramos = value; }
        public double Peso_Libras { get => peso_Libras; set => peso_Libras = value; }
        public double Diametro_cm { get => diametro_cm; set => diametro_cm = value; }
        public double Precio { get => precio; set => precio = value; }

        public Pelota(string marca, double peso_gramos, double peso_Libras, double diametro_cm, double precio)
        {
            this.marca = marca;
            this.peso_gramos = peso_gramos;
            this.peso_Libras = peso_Libras;
            this.diametro_cm = diametro_cm;
            this.precio = precio;
        }

        public double Radio()
        {
            return diametro_cm / 2;
        }

        public double volumen_balon()
        {
            return 4*3.1416 * Radio() * Radio() * Radio() / 3;

        }

        public double descuento()
        {
            return  Precio * 0.10;
        }
        public double importe_pagar()
        {
            return Precio - descuento();
        }

        public double disminuir_precio()
        {
            return precio = precio * 0.75;
        }

        public double aumentar_dm_cm()
        {
            return Diametro_cm = Diametro_cm + 1;
        }

        public static void mostrar_info(Pelota pelota)
        {
            Console.WriteLine($"==============INFORMACIÓN DE LA PELOTA ==============");
            Console.WriteLine($"Marca           :{pelota.Marca}");
            Console.WriteLine($"Peso en Gramo   :{pelota.Peso_gramos}");
            Console.WriteLine($"Peso en Libras  :{pelota.Peso_Libras}");
            Console.WriteLine($"Díametro        :{pelota.Diametro_cm}");
            Console.WriteLine($"Precio          :{pelota.Precio}");
            Console.WriteLine($"Radio           :{pelota.Radio()}");
            Console.WriteLine($"Volumen         :{pelota.volumen_balon()}");
            Console.WriteLine($"Descuento       :{pelota.Radio()}");
            Console.WriteLine($"Importe a pagar :{pelota.importe_pagar()}");
            Console.WriteLine($"-------------------------------------------------\n");


        }
    }
}
