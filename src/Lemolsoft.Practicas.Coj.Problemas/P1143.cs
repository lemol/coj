using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1143 : Problema
    {
        #region Metodos

        public string Comprimir(string texto, int colunas)
        {
            string r = "";
            int lineas = (texto.Length + colunas - 1) / colunas;
            
            for (int j = 0; j < colunas; j++)
            {
                for (int i = 0; i < lineas; i++)
                {
                    int k = ((1 - (int)Math.Pow(-1, i)) / 2) * colunas + (int)Math.Pow(-1, i) * j;
                    r += texto[colunas * i + k];
                }
            }

            return r;
        }

        #endregion

        #region Executivos

        public override void Executar()
        {
            
        }

        #endregion

        #region Constructores
        public P1143() : base() {}
        public P1143(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion


    }
}
