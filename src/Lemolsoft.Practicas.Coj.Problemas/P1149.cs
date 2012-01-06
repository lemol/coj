using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{

    public class P1149 : Problema
    {
        #region Executivos

        static void Maain()
        {
            P1149 problema = new P1149(Console.Out, Console.In);
            problema.Executar();
        }

        public override void Executar()
        {
            
            int caso = 0;

            while (true)
            {
                string[] split = Reader.ReadLine().Split(' ');
                int s = int.Parse(split[0]), t = int.Parse(split[1]), n = int.Parse(split[2]);

                if (s == t && t == n && n == 0)
                    break;

                Writer.WriteLine("Case " + ++caso + ":");

                for (int k = 1; k <= n * 2 + 1; k++)
                {

                    for (int p = 1; p <= (k % 2 == 0 ? s : t); p++)
                    {
                        for (int j = 1; j <= n + 1; j++)
                        {
                            for (int i = 1; i <= t; i++)
                                Writer.Write("*");

                            if (j != n + 1)
                            {
                                for (int i = 1; i <= s; i++)
                                    Writer.Write(k % 2 == 0 ? "." : "*");
                            }
                        }
                        Writer.WriteLine();
                    }
                }

                Writer.WriteLine();

            }


        }

        #endregion

        #region Constructores
        public P1149() : base() { }
        public P1149(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion


    }
}
