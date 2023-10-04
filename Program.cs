
//Práctica 2 Ejercicio 2: Ingrese un numero (1 al 7) para indicar si corresponde con un dia de la semana
//Estudiante: José Pablo Muñoz Zúñiga
//Carrera: Ingeniería Informática
//Materia: Programácion 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingrese_un_numero_de_la_semana
{
    internal class Program
    {
        //En este algoritmo puedes cambiar un numero del (1 al 7), para indicar cual dia de la semana pertenece
        static void Main(string[] args)
        {
            //Cambie el numero que esta en los parentesis para descubrir cual dia de la semana

            Console.WriteLine(GetDay(1));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;


            switch (dayNum)
            {
                //Ingreso el numero uno, el cual correspondio el dia lunes

                case 1:
                    dayName = "Hoy es lunes";
                    break;

                //Ingreso el numero dos, el cual correspondio el dia martes

                case 2:
                    dayName = "Hoy es martes";
                    break;

                //Ingreso el numero tres, el cual correspondio el dia miercoles

                case 3:
                    dayName = "Hoy es miercoles";
                    break;

                //Ingreso el numero cuatro, el cual correspondio el dia jueves

                case 4:
                    dayName = "Hoy es jueves";
                    break;

                //Ingreso el numero cinco, el cual correspondio el dia viernes

                case 5:
                    dayName = "Hoy es viernes";
                    break;

                //Ingreso el numero seis, el cual correspondio el dia sabado

                case 6:
                    dayName = "Hoy es sabado";
                    break;

                //Ingreso el numero siete, el cual correspondio el dia domingo

                case 7:
                    dayName = "Hoy es domingo";
                    break;

                //Ingreso un numero incorrecto, por lo tanto no existe ese un dia en base a ese numero

                default:
                    dayName = "Numero de la semana invalido";
                    break;
            }

            return dayName;

        }
    }
}
