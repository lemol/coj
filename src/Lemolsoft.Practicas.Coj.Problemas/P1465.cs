using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1465 : Problema
    {
        #region Constructores

        public P1465()
            : base()
        {
        }

        public P1465(TextWriter writer, TextReader reader)
            : base(writer, reader)
        {
        }

        #endregion

        #region Executivos

        public override void Executar()
        {
            string entrada;
            while ((entrada = Reader.ReadLine()) != null)
            {
                Caso(entrada);
            }
            
        }
        void append(string s, ref char ultimoChar, StringBuilder builder)
        {
            builder.Append(s); ultimoChar = s[s.Length - 1];
        }
        public void Caso(string entrada)
        {
            StringBuilder builder = new StringBuilder();
            char ultimoChar = ' ';

            //Action<string> append = new Action<string>((s) => { builder.Append(s); ultimoChar = s[s.Length - 1]; });
            
            for (int i = 0; i < entrada.Length; i++)
            {

                #region Toda_Coma_eh_seguido_por_exatamente_um_espaco

                if (entrada[i] == ',')
                {
                    append(",", ref ultimoChar, builder);
                    if (i + 1 < entrada.Length && entrada[i + 1] != ' ')
                        append(" ", ref ultimoChar, builder);
                }

                #endregion

                #region Cada_TresPontos_eh_Precedido_de_exatamente_um_espaco

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

                #endregion

                #region Espacos

                else if (entrada[i] == ' ')
                {
                    if (!(i + 1 < entrada.Length && entrada[i + 1] == ' '))
                    {
                        //if (ultimoChar != ' ' && !(char.IsDigit(ultimoChar) && (i + 1 < entrada.Length && entrada[i + 1] == ',')))
                        if ((!char.IsDigit(ultimoChar) && (i + 1 < entrada.Length && entrada[i + 1] != ',')) || (i + 1 < entrada.Length && entrada[i + 1] == '.'))
                            builder.Append(' ');
                    }
                    ultimoChar = ' ';
                }

                #endregion

                else
                    append(entrada[i].ToString(), ref ultimoChar, builder);


            }

            Writer.WriteLine(builder.ToString());
        }

        #endregion

        #region Privados

        void Append(string str, StringBuilder sb)
        {
            sb.Append(str);
            
        }

        #endregion

    }
}
