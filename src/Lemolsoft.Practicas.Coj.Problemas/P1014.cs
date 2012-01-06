using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1014 : Problema
    {
        #region Executivos

        public override void Executar()
        {

            int jogos = int.Parse(Reader.ReadLine());

            for (int w = 0; w < jogos; w++)
            {

                int[][] carta = new int[5][];

                for (int i = 0; i < 5; i++)
                    carta[i] = new int[5];

                for (int i = 0; i < 5; i++)
                {

                    for (int j = 0; j < 5; j++)
                    {

                        if (i == 2 && j == 2)
                        {
                            carta[j][i] = -1;
                            j++;
                        }
                        carta[j][i] = GetInt();

                    }
                }

                int saidos = 0;
                int vezes = 0;

                while (saidos++ < 75)
                {
                    int num = GetInt();

                    if (vezes == 0)
                    {
                        int i = (num - 1) / 15;
                        int j;

                        if ((j = Array.IndexOf(carta[i], num)) != -1)
                        {
                            carta[i][j] = -1;

                            bool sucesso = false;

                            for (int x = 0; x < 5; x++)
                            {
                                
                                for (int y = 0; y < 5 && (sucesso = (carta[x][y] == -1)); y++) ;

                                if (sucesso)
                                {
                                    vezes = saidos;
                                    break;
                                }

                                for (int y = 0; y < 5 && (sucesso = (carta[y][x] == -1)); y++) ;

                                if (sucesso)
                                {
                                    vezes = saidos;
                                    break;
                                }

                            }

                            for (int x = 0; x < 5 && (sucesso = carta[x][x] == -1); x++) ;
                            if (sucesso)
                            {
                                vezes = saidos;
                                break;
                            }

                            for (int x = 0, y = 4; x < 5 && y >= 0 && (sucesso = carta[x][y] == -1); x++, y--) ;
                            if (sucesso)
                            {
                                vezes = saidos;
                                break;
                            }

                        }
                    }

                }

                Writer.WriteLine("BINGO after {0} numbers announced", vezes);

            }
        }

        public int GetInt()
        {
            int c, res;
            while (!char.IsDigit((char)(c = Reader.Read()))) ;
            res = c - '0';
            while (char.IsDigit((char)(c = Reader.Read())))
                res = 10 * res + c - '0';

            return res;
        }

        #endregion

        #region Constructores
        public P1014() : base() { }
        public P1014(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
