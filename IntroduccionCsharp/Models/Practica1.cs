using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            // int, string, bool, double, char
            string dato1, dato2;
            int cal1 = 0;
            int cal2, cal3, resultado = 0;

            Console.WriteLine("Ingresa primera calificación: ");
            dato1 = Console.ReadLine();
            cal1 = Convert.ToInt32(dato1);
            Console.WriteLine("Ingresa segunda calificación: ");
            dato2 = Console.ReadLine();
            cal2 = Convert.ToInt32(dato2);
            int suma = cal1 + cal2;

            Console.WriteLine("La suma de las calificaciones es: " + suma);
            //if
            if (cal1 > cal2)
            {
                Console.WriteLine("la nota mayor es: " + cal1);
            }
            else
            {
                Console.WriteLine("la nota mayor es:" + cal2);
            }
            //while
            int x;
            x = 1;
            while (x <= 100)
            {
                Console.Write(x);
                Console.Write(" - ");
                x++;
            }
            //do while
            int y = 1;
            do
            {
                Console.Write(y);
                Console.Write(" - ");
                y++;
            } while (y <= 100);
            //for
            int f;
            for (f = 1; f <= 100; f++)
            {
                Console.Write(f);
                Console.Write(" - ");
            }
        }
    }
}