using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Celular
    {
        //creamos los atributos
        private int numero;
        private string usuario;
        private int segundos_consumidos;
        private double precio_segundo;
        public int Numero { get => numero; set => numero = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int Segundos_consumidos { get => segundos_consumidos; set => segundos_consumidos = value; }
        public double Precio_segundo { get => precio_segundo; set => precio_segundo = value; }

        //generamos un constructor
        public Celular(int numero, string usuario, int segundos_consumidos, double precio_segundo)
        {
            this.Numero = numero;
            this.Usuario = usuario;
            this.Segundos_consumidos = segundos_consumidos;
            this.Precio_segundo = precio_segundo;
        }


        //Un método que retorne el costo por consumo (segundos*precio). 
        public double costo_consumo()
        {
            return Segundos_consumidos * Precio_segundo;
        }

        //Un método que retorne el impuesto por IGV (18% del costo por consumo).

        public double impuesto_igv()
        {
            const double IGV = 0.18;
            return costo_consumo() * IGV;
        }

        //Un método que retorne el total a pagar (costo por consumo + impuesto por IGV).

        public double total_pagar()
        {
            return costo_consumo() + impuesto_igv();
        }

    }



}
