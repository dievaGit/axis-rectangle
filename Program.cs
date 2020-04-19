using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjeRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float ancho = 1.0f, alto = 1.0f;
            float area = 0.0f, perimetro = 0.0f;

            Console.Write("Escribe el ancho del rectangulo:");
            ancho = Convert.ToSingle(Console.ReadLine());
            Console.Write("Escribe el alto del rectangulo:");
            alto = Convert.ToSingle(Console.ReadLine());

            area = alto * ancho;
            perimetro = 2 * (alto + ancho);

            Console.WriteLine("El area del rectangulo es: {0} unidades cuadradas", area);
            Console.WriteLine("El perimetro del rectangulo es: {0} unidades", perimetro);

            Console.ReadKey(); 




        }
    }
}
