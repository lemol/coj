using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1006 : Problema
    {

        #region Executivos

        public override void Executar()
        {
            string linea;
            while ((linea = Reader.ReadLine()) != null)
            {
                if (linea != "")
                    foreach (char c in DecodeLine(linea))
                        Writer.Write(c);
                Writer.WriteLine();
            }
        }

        #endregion

        #region Metodos

        public void GoIn(string txt, char[] resultado, int ini, int fin)
        {
            int meio = (fin - ini + 1) / 2;

            resultado[ini + meio - 1] = DecodeChar(txt[0]);

            if (meio > 1)
                GoIn(txt.Substring(1, meio - 1), resultado, ini, fin - meio - 1 + (fin - ini) % 2);

            if (txt.Length != 1)
                GoIn(txt.Substring(meio), resultado, ini + meio, fin);
            

        }

        public char[] DecodeLine(string txt)
        {
            char[] resultado = new char[txt.Length];

            GoIn(txt, resultado, 0, txt.Length);

            return resultado;
        }

        public char DecodeChar(char c)
        {
            if (char.IsLetter(c))
            {
                if (c == 'A') return 'Z';
                if (c == 'a') return 'z';

                return (char)((int)c - 1);
            }
            return c;
        }

        #endregion

        #region Constructores

        public P1006() : base() { }
        public P1006(System.IO.TextWriter writer, System.IO.TextReader reader) : base(writer, reader) { }

        #endregion

    }
}
