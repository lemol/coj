using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Lemolsoft.Practicas.Coj.Problemas
{
    class Programa
    {
        static void Mains(string[] args)
        {
            string texto = Console.ReadLine();
            Linea1_5(texto);
            Linea2_4(texto);
            Linea3(texto);
            Linea2_4(texto);
            Linea1_5(texto);
        }
        public static void Linea1_5(string texto)
        {
            for (int i = 1; i <= texto.Length ; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 3)
                        Console.Write(i % 3 == 0 ? '*' : '#');
                    else
                        Console.Write('.');
                }
            }
            Console.WriteLine('.');
        }
        public static void Linea2_4(string texto)
        {
            for (int i = 1; i <= texto.Length; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(i % 3 == 0 ? '*' : '#');
                    else
                        Console.Write('.');
                }
            }
            Console.WriteLine('.');
        }
        public static void Linea3(string texto)
        {
            for (int i = 1; i <= texto.Length; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1)
                        Console.Write(i % 3 == 0 || (i != 1 && (i - 1) % 3 == 0) ? '*' : '#');
                    if (j % 2 == 0)
                        Console.Write('.');
                    if (j == 3)
                        Console.Write(texto[i-1]);
                }
            }
            Console.WriteLine(texto.Length % 3 == 0 ? '*' : '#');
        }

    }
}
