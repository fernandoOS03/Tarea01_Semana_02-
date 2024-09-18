using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Edificio
    {
        private int codigo { get; set; }
        private int nmro_departamentos { get; set; }
        private int cantidad_pisos { set; get; }
        private double precio_dolar { set; get; }

        public Edificio(int codigo, int nmro_departamentos, int cantidad_pisos, double precio_dolar)
        {
            this.codigo = codigo;
            this.nmro_departamentos = nmro_departamentos;
            this.cantidad_pisos = cantidad_pisos;
            this.precio_dolar = precio_dolar;
        }

        public double precio_edificio() 
        {
            return nmro_departamentos * precio_dolar;
        
        }

        public double aumento_precio()
        {
            return precio_dolar += precio_dolar * 0.20;
        }

        public static void mostrar_info ( Edificio edificio) 
        {
            Console.WriteLine($"Código : {edificio.codigo} ");
            Console.WriteLine($"N° de Departamento : {edificio.nmro_departamentos}" );
            Console.WriteLine($"Precio de Departamento en Dolares : {edificio.precio_dolar}");
            Console.ReadKey();
           
        }
    }
}
