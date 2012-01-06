using System;
namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1006Release
    {
        static void Mains(string[] args)
        {
            string linea;
            while ((linea = Console.ReadLine()) != null)
            {
                if (linea != "")
                    foreach (char c in DecodeLine(linea))
                        Console.Write(c);
                Console.WriteLine();
            }
        }
        static void GoIn(string txt, char[] resultado, int ini, int fin)
        {
            int meio = (fin - ini + 1) / 2;

            resultado[ini + meio - 1] = DecodeChar(txt[0]);

            if (meio > 1)
                GoIn(txt.Substring(1, meio - 1), resultado, ini, fin - meio - 1 + (fin - ini) % 2);

            if (txt.Length != 1)
                GoIn(txt.Substring(meio), resultado, ini + meio, fin);
            
        }
        static char[] DecodeLine(string txt)
        {
            char[] resultado = new char[txt.Length];

            GoIn(txt, resultado, 0, txt.Length);

            return resultado;
        }
        static char DecodeChar(char c)
        {
            if (char.IsLetter(c))
            {
                if (c == 'A') return 'Z';
                if (c == 'a') return 'z';

                return (char)((int)c - 1);
            }
            return c;
        }

    }
}
