using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1108 : Problema
    {
        #region Classes

        struct Par { public int X; public int Y;}

        #endregion

        #region Executivos

        public override void Executar()
        {

            int tamanho = int.Parse(Reader.ReadLine());
            int[] lista = new int[tamanho];
            int[] elms = new int[] { 1, 2 }; // new int[] { 1, 2, 3 }; Nao contei o 3 porque ele eh o maior e nao sera necessario na comparacao
            int[] elmsCount = new int[4]; //[0] nao eh de ninguem mas sera util
                                          //[1] sera do 1, [2] sera do 2, [3] do 3
            //List<Par> cambios = new List<Par>();

            int r = 0;

            for (int i = 0; i < tamanho; i++)
            {
                lista[i] = int.Parse(Reader.ReadLine());
                elmsCount[lista[i]]++;
            }

            for (int i = elmsCount[1]; i < tamanho; i++)
            {
                if (lista[i] == 1)
                {
                    int k = 0;

                    for (int j = 0; j < elmsCount[1]; j++)
                    {
                        if (lista[j] == 2)
                        {
                            k = j;
                            break;
                        }
                        else
                            k = j;
                    }

                    int a = lista[i];
                    lista[i] = lista[k];
                    lista[k] = a;
                    r++;


                }
            }

            for (int i = elmsCount[1] + elmsCount[2]; i < tamanho; i++)
            {
                if (lista[i] == 2)
                    r++;
            }

                /*
                foreach (int elm in elms)
                {
                    for (int i = elmsCount[elm - 1] + elmsCount[elm]; i < tamanho; i++)
                    {

                        if (elm != lista[i]) continue;

                        for (int j = elmsCount[elm - 1]; j < elmsCount[elm - 1] + elmsCount[elm]; j++)
                        {
                            if (lista[j] > elm)
                            {
                                lista[i] = lista[j];
                                lista[j] = elm;
                                cambios.Add(new Par { X = j + 1, Y = i + 1 });
                                r++;
                                break;
                            }
                        }

                    }
                }
                */


                /*
                int r = 0;



                for (int i = 0; i < tamanho; i++)
                {
                    int elm = lista[i] = int.Parse(Reader.ReadLine());
                    int k;

                    while ((k = IsMenorQueElementoAt(elm, i, lista)) != -1)
                    {
                        int a = elm;
                        elm = lista[k];
                        lista[k] = a;
                        r++;
                    }

                }
                */
                Writer.WriteLine(r);
            //foreach (Par cambio in cambios)
              //  Writer.WriteLine("{0} {1}", cambio.X, cambio.Y);
        }

        #endregion

        #region Constructores
        public P1108() : base() {}
        public P1108(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion

    }

}
