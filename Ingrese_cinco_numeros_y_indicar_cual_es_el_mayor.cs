
//Práctica 2 Ejercicio 1: Ingrese cinco numeros para descubrir cual es el mayor
//Estudiante: José Pablo Muñoz Zúñiga
//Carrera: Ingeniería Informática
//Materia: Programácion 2

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingrese_cinco_numeros_y_indicar_cual_es_el_mayor
{
    internal class Ingrese_cinco_numeros_y_indicar_cual_es_el_mayor
    {
        static void Main(string[] args)
        {

            //Digite cinco numeros para descubrir cual es el mayor

            int num1, num2, num3, num4, num5;
            Console.Write("\n\n");
            Console.Write("Encuentra cual de los cinco numeros digitados es el mayor: \n");
            Console.Write("-------------------------------------------------------------");
            Console.Write("\n\n");

            //En esta parte se digita el primer numero
            Console.Write("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //En esta parte se digita el segundo numero
            Console.Write("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //En esta parte se digita el tercer numero
            Console.Write("Digite el tercer numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            //En esta parte se digita el cuarto numero
            Console.Write("Digite el cuarto numero: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            //En esta parte se digita el quinto numero
            Console.Write("Digite el quinto numero: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            //En esta parte se descubre cual de los cinco numeros digitados es el mayor
            if (num1 > num2)
            {
                //En esta parte el primer numeor digitado es el mayor
                if (num1 > num5)
                {
                    Console.Write("El primer numero digitado es el mayor. \n\n");
                }
                //En esta parte el quinto numero digitado es el mayor
                else
                {
                    Console.Write("El quinto numero digitado es el mayor. \n\n");
                }
            }
            //En esta parte el segundo numero digitado es el mayor
            else if (num2 > num5)
                Console.Write("El segundo numero digitado es el mayor. \n\n");
            //En esta parte el tercer numero digitado es el mayor
            else if (num3 > num5)
                Console.Write("El tercer numero digitado es el mayor. \n\n");
            //En esta parte el cuarto numero digitado es el mayor
            else if (num4 > num5)
                Console.Write("El cuarto numero digitado es el mayor. \n\n");
            //En esta parte el quinto numero digitado es el mayor
            else
                Console.Write("El quinto numero digitado es el mayor. \n\n");


            Console.ReadKey();

        }
    }
}
