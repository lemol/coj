using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1200 : Problema
    {
        #region Executivos

        public readonly Queue<int> Primeiros = new Queue<int>();

        public int Find(string n, char k)
        {
            if (Primeiros.Count == 0) return -1;

            for (int i = Primeiros.Dequeue(); i < n.Length; i++)
            {
                if (n[i] == k)
                    return i;
            }

            return -1;
        }

        public override void Executar()
        {

            int casos = int.Parse(Reader.ReadLine());

            for (int t = 0; t < casos; t++)
            {
                string N = Reader.ReadLine();
                string K = Reader.ReadLine();
                int vezes = 0;

                Primeiros.Clear();
                Primeiros.Enqueue(0);

                for (int i = 0; i < N.Length; i++)
                {
                    for (int j = 0; j < K.Length; j++)
                    {
                        //Find(N,K[j])
                    }
                }

            }

        }

        #endregion

        #region Constructores
        public P1200() : base() { }
        public P1200(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
