using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1473 : Problema
    {
        #region Executivos

        public override void Executar()
        {
            string lin;
            while ((lin = Reader.ReadLine()) != "0 0")
            {
                string[] s = lin.Split(' ');
                Writer.WriteLine(Caso(int.Parse(s[0]), int.Parse(s[1])));
            }
        }

        public int Caso(int m, int n)
        {

            if (m == n) return 0;
            m++;
            n++;
            int resultado = 0;
            char[] h = new char[n];
            char[] v = new char[m];
            for (int j = 1; j <= (n - 1) / 2; j++)
            {
                Writer.WriteLine("j = {0} de {1}", j, (n - 1) / 2);
                int f = ((n % 2 != 0) && (j == (n - 1) / 2)) ? 1 : 2;
                if ((h[j]!='2')&&(h[j] == '1' || Caminhar(0, j, 1, 1, m, n, h, v)))
                {
                    resultado += 2 * f * 2;
                }
            }

            for (int i = 1; i <= (m - 1) / 2; i++)
            {
                Writer.WriteLine("i = {0} de {1}", i, (m - 1) / 2);
                int f = ((m % 2 != 0) && (i == (m - 1) / 2)) ? 1 : 2;
                if (v[i]!='2'&&(v[i] == '1' || Caminhar(i, 0, 1, 1, m, n, h, v)))
                {
                    resultado += 2 * f * 2;
                }
            }

            return resultado;
        }int pa;
        public bool Caminhar(int xi, int yi, int dx, int dy, int m, int n,char[]H,char[]V)
        {
            int x = xi;
            int y = yi;
            int v;
            char r;

            int vy = dy > 0 ? n - 1 - y : y;
            int vx = dx > 0 ? m - 1 - x : x;
            v = vx < vy ? vx : vy;
            List<int> passadosH = new List<int>();
            List<int> passadosV = new List<int>();

            do
            {
                if (H[y] == '1' || V[x] == '1')
                {
                    r = '1';
                    break;
                }
                passadosH.Add(y);
                passadosV.Add(x);
                x += dx * v;
                y += dy * v;

                if (x + dx < 0 || x + dx >= m)
                    dx *= -1;

                if (y + dy < 0 || y + dy >= n)
                    dy *= -1;

                vy = dy > 0 ? n - 1 - y : y;
                vx = dx > 0 ? m - 1 - x : x;
                v = vx < vy ? vx : vy;

            }
            while (!((x == 0 && y == 0) || (x == 0 && y == n - 1) || (x == m - 1 && y == 0) || (x == m - 1 && y == n - 1) || (x == xi && y == yi))) ;

            r = (x == xi && y == yi) ? '2' : '1';

            foreach (int i in passadosH)
                H[i] = r;

            foreach (int i in passadosV)
                V[i] = r;

            return r == '1';

        }

        #endregion
        #region Constructores
        public P1473() : base() {}
        public P1473(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
