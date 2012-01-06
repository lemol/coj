using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1165 : Problema
    {
        #region Metodos
        public int Adivinhar(string str)
        {
            int r = 1;
            for (int i = 1; i <= str.Length; i++)
            {
                bool isMultiploDeI = str[i-1] == 'Y';

                if (isMultiploDeI)
                {
                    r = i*r/Mdc(i, r);
                }
                else
                {
                    if (Mdc(i, r) == i) return -1;
                }
            }

            for (int i = 1; i <= str.Length; i++)
            {
                if (str[i - 1] != 'Y' && Mdc(i, r) == i) 
                    return -1;
            }

            return r;
        }
        public int Mdc(int x, int y)
        {
            while (y != 0)
            {
                int a = y;
                y = x % y;
                x = a;
            }
            return x;
        }
        public int Mmc(int x, int y)
        {
            return x * y / Mdc(x, y);
        }
        #endregion
        #region .Net 4
        /*
        public int Adivinhar(string str)
        {

            int r = 1;
            bool[] isMultiploDe = new bool[str.Length];

            for (int i = str.Length - 1; i >= 0; i--)
            {

                if (isMultiploDe[i]) continue;

                bool isMultiplodeI = str[i] == 'Y';

                if (isMultiplodeI)
                {
                    foreach (int j in (i + 1).Multiplos())
                    {
                        if (str[j - 1] != 'Y')
                            return -1;
                        else
                            isMultiploDe[j - 1] = true;
                    }

                    r *= (i + 1);
                }
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (!isMultiploDe[j] && (j + 1).IsMultiploDe(r))
                        return -1;
                }

            }

            return r;
        }
        */
        #endregion
        #region Executivos

        public override void Executar()
        {
            string linea;
            while ((linea = Reader.ReadLine()) != "*")
            {
                int r = Adivinhar(linea);
                Writer.WriteLine(r);
            }
        }

        #endregion

        #region Constructores
        public P1165() : base() {}
        public P1165(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion


    }

    public static class P1165Extensions
    {
        public static bool IsMultiploDe(this int y, int x)
        {
            return (double)x / y == Math.Ceiling((double)x / y);
        }
        public static IEnumerable<int> Multiplos(this int x)
        {
            yield return x;
            for (int i = x / 2; i > 1; i--)
            {
                if (i.IsMultiploDe(x))
                {
                    yield return i;
                }
            }
            yield return 1;
        }
    }
}
