using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1498 : Problema
    {
        #region Propriedades
        public string exp;
        public readonly Dictionary<char, long> constantes = new Dictionary<char,long>();
        int i = 0;
        #endregion

        #region Executivos

        public override void Executar()
        {
            exp = Reader.ReadLine();
            string l;
            while ((l = Reader.ReadLine()) != null)
            {
                if (l != "")
                {
                    string[] s = l.Split('=');
                    constantes[s[0][0]] = long.Parse(s[1]);
                }
            }
            try
            {
                Writer.WriteLine(Soma());
            }
            catch(Exception e)
            {
                Writer.WriteLine("UNDEFINED");
            }
        }

        #endregion

        #region Metodos
        public long Producto()
        {
            long resultado = 1;

            while (i < exp.Length)
            {

                char dig = exp[i];
                string numero = "";
                
                while (char.IsDigit(dig) || (numero != "" && i == (--i)))
                {
                    numero += dig;
                    if (++i >= exp.Length)
                        break;
                    dig = exp[i];
                }

                if (dig == '+' || dig == '-')
                {
                    if (numero != "")
                    {
                        i++;
                        resultado *= long.Parse(numero);
                    }
                    break;
                }

                if (numero != "")
                    resultado *= long.Parse(numero);
                else
                    resultado *= constantes[dig];

                i++;

            }

            return resultado;
        }
        public long Soma()
        {
            long resultado = 0;
            while (i < exp.Length)
            {
                char dig = exp[i];

                if (char.IsDigit(dig) || (dig != '+' && dig != '-'))
                    resultado += Producto();
                else
                {
                    i++;
                    if (dig == '+')
                        resultado += Producto();
                    else
                        resultado -= Producto();
                }

            }
            return resultado;
        }
        #endregion

        #region Constructores
        public P1498() : base() {}
        public P1498(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion
    }
}
