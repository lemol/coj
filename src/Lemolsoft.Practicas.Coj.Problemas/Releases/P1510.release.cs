using System;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    class P1510Release
    {
        static string C(string c)
        {
            string r = "@";
            int l = 1;
            for (int i = 1; i < c.Length; i++)
            {
                if (c[i] == c[i - 1]) l++;
                else
                {
                    D(c[i - 1], l, ref r);
                    l = 1;
                }
            }
            D(c[c.Length - 1], l, ref r);
            return r;
        }
        static void D(char l, int L, ref string r)
        {
            if (L > 3)
            {
                int R = L % 9;
                for (int j = 0; j < L / 9; j++) r += "9" + l;
                if (R > 3) r += R.ToString() + l;
                else for (int j = 0; j < R; j++) r += l;
            }
            else for (int j = 0; j < L; j++) r += l;
        }
        static void Maain()
        {
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)Console.WriteLine(C(Console.ReadLine()));
        }

    }
}
