using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores

            int a = 225;
            int b = 25;

            if (a<b)
            {
                Console.WriteLine("a es menor a b");
            }
            else if (a>b)
            {
                Console.WriteLine("a es mayor que b");
            }

            // IF anidados
           if (a!=b)
            {
                if (a<b)
                {
                    Console.WriteLine("a es menor a b");
                }
                else if (a>b)
                {
                    Console.WriteLine("a es mayor a b");
                }
            }

            //OPERADOR TERNARIO
            //La forma abreviada de if else

            var resultado = a > b ? "a es mayor a b" : "a es menor a b";
            Console.WriteLine("Resultado con operador ternario: {0}", resultado);



            Console.ReadKey();
        }
    }
}
