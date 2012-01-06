using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{

    public class P1152 : Problema
    {
        static void Maain()
        {
            P1152 pro = new P1152(Console.Out, Console.In);
            pro.LerComando();
            pro.LerNumero();
        }
        public const int m = 1234;
        public const int n = 5678;

        readonly int[] linhas = new int[m + 1];
        readonly int[] colunas = new int[n + 1];

        #region Executivos
        public char LerComando()
        {
            int c;

            while (true)
            {
                c = Reader.Read();
                if (c == -1) return '0';
                if (char.IsUpper((char)c)) return (char)c;
            }


        }
        public int LerNumero()
        {
            int c, res;

            while(!char.IsDigit((char)(c=Reader.Read())));
                res = c - '0';
                while (char.IsDigit((char)(c = Reader.Read())))
                    res = 10 * res + c - '0';

                return res;

        }

        public override void Executar()
        {

            int[][] M = new int[m + 1][];

            for (int i = 1; i <= m; i++)
            {
                M[i] = new int[n + 1];
                linhas[i] = i;

                for (int j = 1; j <= n; j++)
                {

                    M[i][j] = n * (i - 1) + j;

                }
            }

            for (int j = 1; j <= n; j++)
            {

                colunas[j] = j;

            }

            char com;

            while ((com = LerComando()) != '0')
            {
                int x, y, z;

                switch(com)
                {
                    case 'R':

                        x = LerNumero();
                        y = LerNumero();

                        linhas[x] = y;
                        linhas[y] = x;

                        break;
                    case 'C':

                        x = LerNumero();
                        y = LerNumero();

                        colunas[x] = y;
                        colunas[y] = x;

                        break;
                    case 'Q':

                        x = LerNumero();
                        y = LerNumero();

                        Writer.WriteLine(M[linhas[x]][colunas[y]]);

                        break;
                    case 'W':

                        z = LerNumero();
                        int i, j;
                        /*
                        if (z % n == 0)
                        {
                            i = z / n;
                        }
                        else
                        {
                            i = z / n + 1;
                        }
                        */
                        i = (z - 1) / n + 1;
                        //j = z % n == 0 ? n : z % n;
                        j = z - n * (i - 1);
                        
                        Writer.WriteLine("{0} {1}", linhas[i], colunas[j]);

                        break;

                    default:
                        break;
                }

            }

        }

        #endregion

        #region Constructores
        public P1152() : base() { }
        public P1152(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion


    }
}
