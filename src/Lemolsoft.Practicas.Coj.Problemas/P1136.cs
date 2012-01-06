using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{


    /// <summary>
    /// This is a modification of the standard Sieve of Eratosthenes. It would be highly inefficient, using up far too much memory and time, to run the standard sieve all the way up to n. However, no composite number less than or equal to n will have a factor greater than \lfloor \sqrt{n}\rfloor, so we only need to know all primes up to this limit, which is no greater than 31622 (square root of 109). This is accomplished with a sieve. Then, for each query, we sieve through only the range given, using our pre-computed table of primes to eliminate composite numbers. 
    /// </summary>
    public class P1136 : Problema
    {
        public static void Maain()
        {
            P1136 problema = new P1136(Console.Out, Console.In);
            problema.Executar();
            Console.ReadKey();
        }
        /*
        #region Metodos
        List<uint> primos = new List<uint>();
        public bool IsPrimo(uint x)
        {
            if ((x <= 1) ||
               (x % 2 == 0 && x != 2) ||
               (x % 3 == 0 && x != 3) ||
               (x % 5 == 0 && x != 5) ||
               (x % 7 == 0 && x != 7) ||
               (x % 11 == 0 && x != 11) ||
               (x % 13 == 0 && x != 13) ||
               (x % 17 == 0 && x != 17) ||
               (x % 19 == 0 && x != 19) ||
               (x % 23 == 0 && x != 23) ||
               (x % 29 == 0 && x != 29) ||
               (x % 31 == 0 && x != 31) ||
               (x % 37 == 0 && x != 37) ||
               (x % 41 == 0 && x != 41) ||
               (x % 43 == 0 && x != 43) ||
               (x % 47 == 0 && x != 47) ||
               (x % 53 == 0 && x != 53) ||
               (x % 59 == 0 && x != 59) ||
               (x % 61 == 0 && x != 61) ||
               (x % 67 == 0 && x != 67) ||
               (x % 71 == 0 && x != 71) ||
               (x % 73 == 0 && x != 73) ||
               (x % 79 == 0 && x != 79) ||
               (x % 83 == 0 && x != 83) ||
               (x % 89 == 0 && x != 89) ||
               (x % 97 == 0 && x != 97) ||
               (x % 101 == 0 && x != 101) ||
               (x % 103 == 0 && x != 103) ||
               (x % 107 == 0 && x != 107) ||
               (x % 109 == 0 && x != 109) ||
               (x % 113 == 0 && x != 113) ||
               (x % 127 == 0 && x != 127) ||
               (x % 131 == 0 && x != 131) ||
               (x % 137 == 0 && x != 137) ||
               (x % 139 == 0 && x != 139))
            {
                return false;
            }
            else
            {
                foreach (int i in primos)
                    if (x % i == 0 && x != i)
                        return false;

                uint divisor = 101;

                while (divisor <= Math.Ceiling(Math.Sqrt(x)))
                {
                    if (x % divisor == 0)  //if (x % divisor == 0 && x != divisor) x sempre diferente de divisor
                        return false;

                    divisor++;
                }

                primos.Add(x);
                return true;

            }

        }

        #endregion
        */

        #region Metodos

        readonly bool[] isPrimo = new bool[31622];

        public void InicializaPrimos()
        {

        }

        public bool IsPrimo(uint x)
        {
            return false;
        }

        #endregion
        #region Executivos

        public override void Executar()
        {
            int casos = int.Parse(Reader.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                Caso();
                if (i != casos - 1)
                    Writer.WriteLine();
            }

        }

        public void Caso()
        {
            string[] s = Reader.ReadLine().Split(' ');
            uint x = uint.Parse(s[0]), y = uint.Parse(s[1]);

            for (uint i = x; i <= y; i++)
            {/*
                if (primos.Contains(i))
                {
                    Writer.WriteLine(i);
                    continue;
                }
                if (IsPrimo(i))
                {
                    primos.Add(i);
                    Writer.WriteLine(i);
                }*/
            }

        }

        #endregion

        #region Constructores
        public P1136() : base() {}
        public P1136(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion

    }

}
