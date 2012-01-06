using System;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1394Release
    {
        static long F(long n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0) return n / 2;
            else return F((n - 1) / 2) + F((n + 1) / 2);
        }
        static void Maain()
        {
            string c = Console.ReadLine().Trim();
            while (true)
            {
                Console.WriteLine("f({0}) = {1}", c, F(long.Parse(c)));
                c = Console.ReadLine();
                if (c == "-1")
                    break;
                else
                    Console.WriteLine();
            }
        }
    }
}
