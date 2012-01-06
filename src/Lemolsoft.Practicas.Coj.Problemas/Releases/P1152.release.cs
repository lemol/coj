/*using System;class P115Release{const int m=1234,n=5678;static readonly int[]L=new int[1235];static readonly int[]C=new int[5679];static readonly int[][]M=new int[1235][];static void Maian(){for(int i=1;i<=m;i++){M[i]=new int[5679];L[i]=i;for(int j=1;j<=n;j++)M[i][j]=n*(i-1)+j;}for(int j=1;j<=n;j++)C[j]=j;string c;while(!string.IsNullOrEmpty((c=Console.ReadLine()))){string[]s=c.Split(' ');int x=int.Parse(s[1]),y;if(s[0]=="W"){int i=(x-1)/n+1;;Console.WriteLine("{0} {1}",L[i],C[x-n*(i-1)]);}else if(s[0]=="R"){y=int.Parse(s[2]);L[x]=y;L[y]=x;}else if(s[0]=="C"){y=int.Parse(s[2]);C[x]=y;C[y]=x;}else if(s[0]=="Q"){y=int.Parse(s[2]);Console.WriteLine(M[L[x]][C[y]]);}}}}
*/
using System;

namespace Lemolsoft.Practicas.Coj.Problemas
{

    public class P1152Release
    {
        static void Maian()
        {
            P1152Release pro = new P1152Release();
            pro.Executar();
        }
        public const int m = 1234;
        public const int n = 5678;

        readonly int[] linhas = new int[m + 1];
        readonly int[] colunas = new int[n + 1];

        public char LerComando()
        {
            int c;

            while (true)
            {
                c = Console.ReadKey().KeyChar;
                if (c == -1) return '0';
                if (char.IsUpper((char)c)) return (char)c;
            }


        }
        public int LerNumero()
        {
            int c, res;

            while (!char.IsDigit((char)(c = Console.ReadKey().KeyChar))) ;
            res = c - '0';
            while (char.IsDigit((char)(c = Console.ReadKey().KeyChar)))
                res = 10 * res + c - '0';

            return res;

        }

        public void Executar()
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

                switch (com)
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

                        Console.WriteLine(M[linhas[x]][colunas[y]]);

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

                        Console.WriteLine("{0} {1}", linhas[i], colunas[j]);

                        break;

                    default:
                        break;
                }

            }

        }


    }
}
