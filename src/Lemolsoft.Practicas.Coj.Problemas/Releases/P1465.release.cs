using System;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    class P1465Release
    {
        static void Mains()
        {
            string entrada;
            while ((entrada = Console.ReadLine()) != null)
            {
                Caso(entrada);
            }

        }
        static void append(string s, ref char ultimoChar, StringBuilder builder)
        {
            builder.Append(s); ultimoChar = s[s.Length - 1];
        }
        static void Caso(string entrada)
        {
            StringBuilder builder = new StringBuilder();
            char ultimoChar = ' ';

            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] == ',')
                {
                    append(",", ref ultimoChar, builder);
                    if (i + 1 < entrada.Length && entrada[i + 1] != ' ')
                        append(" ", ref ultimoChar, builder);
                }
                else if (entrada[i] == '.')
                {
                    if (i + 2 < entrada.Length && entrada[i + 1] == '.' && entrada[i + 2] == '.')
                    {
                        if (i != 0 && ultimoChar != ' ')
                            builder.Append(' ');
                        append("...", ref ultimoChar, builder);

                        i++;
                    }
                }
                else if (entrada[i] == ' ')
                {
                    if (!(i + 1 < entrada.Length && entrada[i + 1] == ' '))
                    {
                        if ((!char.IsDigit(ultimoChar) && (i + 1 < entrada.Length && entrada[i + 1] != ',')) || (i + 1 < entrada.Length && entrada[i + 1] == '.'))
                            builder.Append(' ');
                    }
                    ultimoChar = ' ';
                }
                else
                    append(entrada[i].ToString(), ref ultimoChar, builder);


            }

            Console.WriteLine(builder.ToString());
        }

    }
}
