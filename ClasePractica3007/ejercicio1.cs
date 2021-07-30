using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class ejercicio1
    {
        //declaracion de ENUm
        public enum Dias
        {
            // son basicamente una lista de constantes con un nombre
            // TODOS SE ESCRIBEN EN MAYUSCULAS
            // se les puede asignar valores de ser necesario
            // se van a usar cuando se conocen todos los posibles valores
            LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO
        }

        static void Main(string[] args)
        {
            //ENUM
            //clase especial, representa un conjunto de constantes
            Console.WriteLine("Escriba el numero coreespondiente al dia de la semana:");
            int dia = Convert.ToInt32(Console.ReadLine()); // se utiliza para convertir de string a int

            // otra variante de conversion
            int ddias = int.Parse(Console.ReadLine());

            //int otrodia = int.TryParse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine(Dias.LUNES );
                    break;
                case 2:
                    Console.WriteLine(Dias.MARTES);
                    break;
            }

            Console.ReadKey();

        }
    }
}
