using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class condicional
    {
        static void Main(string[] args)
        {
            //instruccion switch
            int a = 10;

            switch(a)
            {
                case 5:
                    Console.WriteLine("el valor es 5");
                    break;
                case 10:
                    Console.WriteLine("el valor es 10");
                    break;
                default:
                    Console.WriteLine("el valor no es conocido");
                    break;
            }

            //Declaración anidadas usando switch

            switch (a)
            {
                case 5:
                    Console.WriteLine("el valor es 5");
                    switch (a-1)
                    {
                        case 4:
                            Console.WriteLine("el valor es 10");
                            switch (a-2)
                                {
                                    case 3:
                                        Console.WriteLine("el valor no es conocido");
                                        break;
                                }
                            break;
                    }
       
                    break;
                case 10:
                    Console.WriteLine("el valor es 10");
                    break;
                default:
                    Console.WriteLine("el valor no es conocido");
                    break;
            }



            Console.ReadKey();
        }
    }
}
