
//Práctica 2 Ejercicio 3: Ingrese si es una vocal, consonante o un numero
//Estudiante: José Pablo Muloz Zúñiga
//Carrera: Ingeniería Informática
//Materia: Programácion 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingrese_una_vocal_consonante_numero
{
    internal class Ingrese_si_es_una_vocal_consonante_numero
    {
        static void Main(string[] args)
        {
            // Ingrese si es vocal, consonante o un numero
            string letra;
            Console.Write("Digite una letra: ");
            letra = Console.ReadLine();
            // En esta parte el usuario ingreso una letra
            if (letra == "a" || letra == "b" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.Write("Usted digito la letra \"{0}\" una vocal", letra);
            }
            // En esta parte el usuario ingreso una consonante
            else if (letra == "q" || letra == "w" || letra == "e" || letra == "r" || letra == "t" || letra == "y" || letra == "u" || letra == "i" || letra == "o" || letra == "p" || letra == "s" || letra == "d" || letra == "f" || letra == "f" || letra == "g" || letra == "h" || letra == "j" || letra == "k" || letra == "l" || letra == "z" || letra == "x" || letra == "c" || letra == "v" || letra == "b" || letra == "n" || letra == "m")
            {
                Console.WriteLine("Usted digito al letra \"{0}\" una consonante", letra);
            }
            //En esta parte el usuario ingreso un numero
            else
            {
                Console.WriteLine("Usted digito un numero siendo el \"{0}\"", letra);
            }
            Console.ReadKey();
        }
    }
}
