using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1394 : Problema
    {
        #region Metodos

        public int Fn(int n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0) return n / 2;
            else return Fn((n - 1) / 2) + Fn((n + 1) / 2);
        }

        #endregion

        #region Executivos

        public override void Executar()
        {
            string caso = Reader.ReadLine().Trim();
            while (true)
            {
                int resultado = Fn(int.Parse(caso));

                Writer.WriteLine("f({0}) = {1}", caso, Fn(int.Parse(caso)));

                caso = Reader.ReadLine();
                if (caso == "-1")
                    break;
                else
                    Writer.WriteLine();
            }
        }

        #endregion

        #region Constructores
        public P1394() : base() {}
        public P1394(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
