using System;
using System.Collections.Generic;

namespace Practica04
{
    public static class Helpers
    {
        //Metodo adicional (personal).
        public static void Display(this List<int> ls)
        {
            int n = 1;
            foreach (var l in ls)
            {
                Console.Write($"{l.ToString("00")} ");
                if (n%10 == 0) Console.Write("\n");
                n += 1;
            }
        }
        public static void Show(this string s) => Console.WriteLine(s);
        public static void DisplayDivision(int n, string line = "_")
        {
            for (int i = 0; i < n; i++) line += "_";
            Console.WriteLine($"\n{line}\n");
        }

        //Practica 04 Ejercicio 01.
        public static List<int> Pares(this List<int> list) => list.FindAll(p => (p % 2 == 0));

        //Practica 04 Ejercicio 02-01.
        public static bool EsImpar(this int x) => (x % 2 != 0);

        //Practica 04 Ejercicio 02-02.
        public static double CalcularITBIS(this double precio) => (precio * 0.18);

        //Practica 04 Ejercicio 02-03.
        // NOTA: Solicito que un metodo void retornara la variable fecha... por lo que no es posible.
        // se Procedio a sustituir el tipo del metodo de un void a un DateTime.
        public static DateTime GetDate() => DateTime.Now;
    }
}


//Anthony Reyes Durán.