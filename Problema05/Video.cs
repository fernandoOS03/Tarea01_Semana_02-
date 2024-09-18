using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Video
    {
        private int codigo;
        private string name_video;
        private double duracion;
        private double precio_soles;
        private double tipo_cambio;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Name_video { get => name_video; set => name_video = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double Precio_soles { get => precio_soles; set => precio_soles = value; }
        public double Tipo_cambio { get => tipo_cambio; set => tipo_cambio = value; }

        public Video(int codigo, string name_video, double duracion, double precio_soles, double tipo_cambio)
        {
            this.Codigo = codigo;
            this.Name_video = name_video;
            this.Duracion = duracion;
            this.Precio_soles = precio_soles;
            this.Tipo_cambio = tipo_cambio;
        }

        public double precio_dolares()
        {
            return Precio_soles / Tipo_cambio;
        }

        public double aumento_precio()
        {
            return Precio_soles = Precio_soles + 5.50;
        }

        public static void mostar_info(Video video)
        {
            Console.WriteLine($"==============INFORMACIÓN DEL VIDEO ==============");
            Console.WriteLine($"Código del Video   :{video.Codigo}");
            Console.WriteLine($"Nombre del Video   :{video.Name_video}");
            Console.WriteLine($"Duración del Video :{video.Duracion}");
            Console.WriteLine($"Precio en Soles    :{video.Precio_soles}");
            Console.WriteLine($"Tipo de cambio     :{video.Tipo_cambio}");
            Console.WriteLine($"Precio en Dolares  :{video.precio_dolares()}");
            Console.WriteLine($"-------------------------------------------------\n");
        }

    }
}
