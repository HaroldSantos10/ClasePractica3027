using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica2907
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuál es su nombre: ");
            var nombre = Console.ReadLine();
            var cantidad = 100.50d;

            Console.WriteLine("El tipo de dato para la variable nombre es {0}", nombre.GetType());
            Console.WriteLine("El tipo de dato para la variable nombre es {0}", cantidad.GetType());
            Console.ReadKey();
        }
    }
}
