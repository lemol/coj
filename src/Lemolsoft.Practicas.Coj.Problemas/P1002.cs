using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1002 : Problema
    {
        #region Executivos

        public override void Executar()
        {
            
            int casos = int.Parse(Reader.ReadLine());

            for (int k = 0; k < casos; k++)
            {
                
                int n = int.Parse(Reader.ReadLine());
                int maior = 0;

                string[] grade = new string[n];

                for (int i = 0; i < n; i++)
                {
                    grade[i] = Reader.ReadLine();
                }

                for (int x = 0; x < n; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        
                        int actual = 0;
                        bool continuar = true;

                        for (int i = x, j = y; continuar && i < n && j < n; i++, j++)
                        {
                            for (int p = 0; p <= i - x; p++)
                            {
                                if (grade[i - p][j] == '#' || grade[i][j - p] == '#')
                                {
                                    continuar = false;
                                    break;
                                }
                            }

                            if (continuar)
                                actual++;

                        }

                        if (actual > maior)
                            maior = actual;
                    }
                }

                Writer.WriteLine(maior);

            }

        }

        #endregion

        #region Constructores
        public P1002() : base() { }
        public P1002(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
