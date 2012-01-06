using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1127 : Problema
    {

        #region Metodos

        public bool Verificar(int lineaX1, int lineaY1, int lineaX2, int lineaY2, int rectTopEsqX, int rectTopEsqY, int rectBaseDirX, int rectBaseDirY)
        {

            for (int x = rectTopEsqX; x <= rectBaseDirX; x++)
            {
                for (int y = rectBaseDirX; y <= rectTopEsqY; y++)
                {
                    return (lineaY2 - lineaX2) * x - (lineaY1 - lineaX1) * y == lineaX1 * lineaY2 - lineaX2 * lineaY1;
                }
            }

            return false;
        }

        #endregion

        #region Executivos

        public override void Executar()
        {
            int caso = int.Parse(Reader.ReadLine());

            for (int i = 0; i < caso; i++)
            {
                string[] entrada = Reader.ReadLine().Split(' ');

                int lineaX1 = int.Parse(entrada[0]);
                int lineaY1 = int.Parse(entrada[1]);
                int lineaX2 = int.Parse(entrada[2]);
                int lineaY2 = int.Parse(entrada[3]);
                int rectTopEsqX = int.Parse(entrada[4]);
                int rectTopEsqY = int.Parse(entrada[5]);
                int rectBaseDirX = int.Parse(entrada[6]);
                int rectBaseDirY = int.Parse(entrada[7]);

                bool res = Verificar(lineaX1, lineaY1, lineaX2, lineaY2, rectTopEsqX, rectTopEsqY, rectBaseDirX, rectBaseDirY);

                if (res)
                    Writer.WriteLine("T");
                else
                    Writer.WriteLine("F");
            }

        }

        #endregion

        #region Constructores
        public P1127() : base() {}
        public P1127(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion

    }
}
