using System;
using System.Collections.Generic;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    class P1498Release
    {
        static string e;
        static readonly Dictionary<char, long> c = new Dictionary<char,long>();
        static int i = 0;
        static void Maian(string[] args)
        {
            e = Console.ReadLine();
            string l;
            while ((l = Console.ReadLine()) != null)
            {
                if (l != "")
                {
                    string[] s = l.Split('=');
                    c[s[0][0]] = long.Parse(s[1]);
                }
            }
            try
            {
                Console.WriteLine(S());
            }
            catch(KeyNotFoundException x)
            {
                Console.WriteLine("UNDEFINED");
            }
            Console.ReadKey();
        }
        static public decimal P()
        {
            decimal r = 1;
            while (i < e.Length)
            {
                char d = e[i];
                string n = "";
                while (char.IsDigit(d) || (n != "" && i == (--i)))
                {
                    n += d;
                    if (++i >= e.Length) break;
                    d = e[i];
                }
                if (d == '+' || d == '-')
                {
                    if (n != "")
                    {
                        i++;
                        r *= long.Parse(n);
                    }
                    break;
                }
                if (n != "")
                    r *= long.Parse(n);
                else
                    r *= c[d];
                i++;
            }
            return r;
        }
        static public decimal S()
        {
            decimal r = 0;
            while (i < e.Length)
            {
                char d = e[i];
                if (char.IsDigit(d) || (d != '+' && d != '-'))
                    r += P();
                else
                {
                    i++;
                    if (d == '+')
                        r += P();
                    else
                        r -= P();
                }
            }
            return r;
        }
    }
}
