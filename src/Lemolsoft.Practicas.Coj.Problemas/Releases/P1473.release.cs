using System;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    class P1473Release
    {
        static void Maain()
        {
            new P1473(Console.Out, Console.In).Executar();
            /*string l;
            while ((l = Console.ReadLine()) != "0 0")
            {
                string[] s = l.Split(' ');
                Console.WriteLine(C(int.Parse(s[0]), int.Parse(s[1])));
            }*/
        }
        static int C(int m, int n)
        {
            if (m == n) return 0;
            m++;
            n++;
            int r = 0;
            byte[] h = new byte[n];
            byte[] v = new byte[m];
            for (int j = 1; j <= (n - 1) / 2; j++)
            {
                int f = ((n % 2 != 0) && (j == (n - 1) / 2)) ? 1 : 2;
                    if (K(0, j, 1, 1, m, n))
                    {
                        r += 2 * f;
                        if (K(0, j, 1, -1, m, n))
                            r += 2 * f;
                    }
            }
            for (int i = 1; i <= (m - 1) / 2; i++)
            {
                int f = ((m % 2 != 0) && (i == (m - 1) / 2)) ? 1 : 2;
                if (K(i, 0, 1, 1, m, n))
                {
                    r += 2 * f;
                    if (K(i, 0, -1, 1, m, n))
                        r += 2 * f;
                }
            }

            return r;
        }
        static bool K(int i, int j, int p, int q, int m, int n)
        {
            int x = i;
            int y = j;
            int a = q > 0 ? n - 1 - y : y;
            int b = p > 0 ? m - 1 - x : x;
            int v = b < a ? b : a;
            do
            {
                x += p * v;
                y += q * v;

                if (x + p < 0 || x + p >= m)
                    p *= -1;

                if (y + q < 0 || y + q >= n)
                    q *= -1;

                a = q > 0 ? n - 1 - y : y;
                b = p > 0 ? m - 1 - x : x;
                v = b < a ? b : a;
            }
            while (!((x == 0 && y == 0) || (x == 0 && y == n - 1) || (x == m - 1 && y == 0) || (x == m - 1 && y == n - 1) || (x == i && y == j)));

            if (x == i && y == j)
                return false;
            else
                return true;

        }

    }
}
