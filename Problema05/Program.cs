using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Program
    {
        static void Main()
        {
            Video video1 = new Video(1001,"Video 001",10.5,10.0,3.75);

            Video.mostar_info(video1);

            Console.WriteLine("======== CON AUMENTO DE PRECIO ========\n");
            video1.aumento_precio();
            Video.mostar_info(video1);
            Console.ReadKey();

            
        }
    }
}
