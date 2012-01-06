using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1173 : Problema
    {

        #region Metodos

        #endregion

        #region Executivos

        public override void Executar()
        {
            string linea;

            while ((linea = Reader.ReadLine()) != null)
            {
                string res = linea.Replace("BUG", "");
                Writer.WriteLine(res);
            }

        }

        #endregion

        #region Constructores
        public P1173() : base() {}
        public P1173(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion

    }
}
