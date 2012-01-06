using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1302 : Problema
    {
        #region Constructores
        public P1302() : base() { }
        public P1302(TextWriter w, TextReader r) : base(w, r) { }
        #endregion

        #region Executivos
        
        public override void Executar()
        {
            string texto = Reader.ReadLine();
            Linea1_5(texto);
            Linea2_4(texto);
            Linea3(texto);
            Linea2_4(texto);
            Linea1_5(texto);

        }

        public void Linea1_5(string texto)
        {
            for (int i = 1; i <= texto.Length ; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 3)
                        Writer.Write(i % 3 == 0 ? '*' : '#');
                    else
                        Writer.Write('.');
                }
            }
            Writer.WriteLine('.');
        }

        public void Linea2_4(string texto)
        {
            for (int i = 1; i <= texto.Length; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j % 2 == 0)
                        Writer.Write(i % 3 == 0 ? '*' : '#');
                    else
                        Writer.Write('.');
                }
            }
            Writer.WriteLine('.');
        }

        public void Linea3(string texto)
        {
            for (int i = 1; i <= texto.Length; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1)
                        Writer.Write(i % 3 == 0 || (i != 1 && (i - 1) % 3 == 0) ? '*' : '#');
                    if (j % 2 == 0)
                        Writer.Write('.');
                    if (j == 3)
                        Writer.Write(texto[i-1]);
                }
            }
            Writer.WriteLine(texto.Length % 3 == 0 ? '*' : '#');
        }

        #endregion
    }
}
