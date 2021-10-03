using System;
using System.Collections.Generic;

namespace Practica04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Definiendo la lista.
            var list = new List<int>();
            for (int i = 1; i <= 100; i++) list.Add(i);
            list.Display();

            //Ejecicio 01.
            Helpers.DisplayDivision(29);
            list.Pares().Display();

            //Ejecicio 02-01.
            Helpers.DisplayDivision(29);
            3.EsImpar().ToString().Show();

            //Ejecicio 02-02.
            Helpers.DisplayDivision(29);
            1503.12d.CalcularITBIS().ToString("0,0,0.00").Show();

            //Ejecicio 02-03.
            Helpers.DisplayDivision(29);
            Helpers.GetDate().ToString().Show();
        }
    }
}


//Anthony Reyes Durán.