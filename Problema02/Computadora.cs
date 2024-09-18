using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Computadora
    {
        private int codigo { get; set; } 
        private string marca { get; set; }
        private string color { get; set; }
        private double precio_dolares { get; set; }

        public Computadora(int codigo, string marca, string color, double precio_dolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precio_dolares = precio_dolares;
        }
       
       


        public double precio_soles()
        {
             double dolar = 3.35;
            return precio_dolares * dolar;
       
        }

        public double precio_euros()
        {
            double euro = precio_dolares / 1.20;
            return euro;
        }
        public double disminuir_precio() 
        {
            return precio_dolares -= precio_dolares * 0.10;
        }

        public static void mostrar_datos(Computadora computadora) 
        {
            Console.WriteLine("DATOS DE LA COMPUTADORA");
            Console.WriteLine($"Código : {computadora.codigo}");
            Console.WriteLine($"Marca : {computadora.marca}");
            Console.WriteLine($"Color : {computadora.color}");
            Console.WriteLine($"Precio en Soles {computadora.precio_soles()}");
            Console.WriteLine($"Precio en dolares : {computadora.precio_dolares}");
            Console.WriteLine($"Precio en euros {computadora.precio_euros()}");
            Console.WriteLine();
           
        }

    }
}
