using System;
using System.IO;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1330 : Problema
    {

        #region Propriedades

        readonly string[] alcool = new string[] { "ABSINTH", "BEER", "BRANDY", "CHAMPAGNE", "GIN", "RUM", "SAKE", "TEQUILA", "VODKA", "WHISKEY", "WINE" };

        #endregion

        #region Metodos

        public bool Contains(string[] array, string valor)
        {
            foreach (string s in array) if (s == valor) return true;
            return false;
        }

        #endregion

        #region Executivos

        public override void Executar()
        {
            int t = int.Parse(Reader.ReadLine());

            for (; t > 0; t--)
            {
                int n = int.Parse(Reader.ReadLine());
                int r = 0;

                for (; n > 0; n--)
                {

                    string s = Reader.ReadLine();
                    int i;
                    if ((int.TryParse(s, out i) && (i < 18)) || Contains(alcool,s)) r++;
                   
                }

                Writer.WriteLine(r);

            }
        }

        #endregion

        #region Constructores
        public P1330() : base() { }
        public P1330(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
