using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1510 : Problema
    {

        #region Metodos

        public string Comprimir(string code)
        {
            string r = "@";

            int lastCount = 1;
            int codeLength = code.Length;

            for (int i = 1; i < codeLength; i++)
            {
                if (code[i] == code[i - 1])
                {
                    lastCount++;
                }
                else
                {
                    Descarregar(code[i - 1], lastCount, ref r);
                    lastCount = 1;
                }
            }

            Descarregar(code[code.Length - 1], lastCount, ref r);

            return r;
        }

        public void Descarregar(char lastChar, int lastCount, ref string r)
        {
            if (lastCount > 3)
            {
                int noves = lastCount / 9;
                int resto = lastCount % 9;

                for (int j = 0; j < noves; j++)
                    r += "9" + lastChar;

                if (resto > 3)
                    r += resto.ToString() + lastChar;
                else
                {
                    for (int j = 0; j < resto; j++)
                        r += lastChar;
                }
            }
            else
            {
                for (int j = 0; j < lastCount; j++)
                    r += lastChar;
            }
        }

        #endregion

        #region Executivos

        public override void Executar()
        {
            int casos = int.Parse(Reader.ReadLine());
            for (int i = 0; i < casos; i++)
                Caso();
        }

        public void Caso()
        {
            string code = Reader.ReadLine();
            string res = Comprimir(code);

            Writer.WriteLine(res);
        }

        #endregion

        #region Constructores
        public P1510() : base() {}
        public P1510(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
