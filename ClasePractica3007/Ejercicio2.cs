﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            // declaracion de variables
            int opcion;
            double a, b;

            Console.WriteLine("Escriba el valor de a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor de b");
            b = Double.Parse(Console.ReadLine());

            //preguntar opcion al usuario
            Console.WriteLine("Seleccione una operación a realizar: 1-suma, 2 resta, 3-multiplicacion");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                // uso case
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a * b);
                    break;

                case 3:
                    Console.WriteLine(a / b);
                    break;
            }


        }
    }
}
