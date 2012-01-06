using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lemolsoft.Practicas.Coj.Problemas
{
    public class P1313 : Problema
    {
        #region Propriedades
        
        public readonly Dictionary<string, int> constantes = new Dictionary<string, int>();
        public readonly Dictionary<string, string> variaveis = new Dictionary<string, string>();
        public readonly List<string> chaves = new List<string>();
        #endregion

        #region Overrides
        
        public override void Executar()
        {
            int casos = int.Parse(Reader.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                Reader.ReadLine();
                Caso();
                if (i != casos - 1)
                    Writer.WriteLine();
            }

        }

        public void Caso()
        {

            int expLenght = int.Parse(Reader.ReadLine());

            variaveis.Clear();
            constantes.Clear();
            chaves.Clear();

            for (int i = 0; i < expLenght; i++)
            {
                SetExp(Reader.ReadLine());
            }

            foreach(string key in variaveis.Keys)
            {
                if (!constantes.ContainsKey(key))
                    constantes[key] = Evaluar(variaveis[key]);
                
            }

            ImprimirOrdenado();
        }

        public void SetExp(string exp)
        {

            string[] split = exp.Split('=');
            string nome = split[0].Trim();
            string valor = split[1].Trim();
            int valorC;

            if (int.TryParse(valor, out valorC))
            {
                constantes[nome] = valorC;
            }
            else
                variaveis[nome] = valor;

            chaves.Add(nome);
        }

        public int Evaluar(string exp)
        {
            return SomSub(exp);
        }

        public void ImprimirOrdenado()
        {
            chaves.Sort();
            foreach (string chave in chaves)
                Writer.WriteLine("{0} = {1}", chave, constantes[chave]);
        }

        #endregion

        #region Metodos

        public int MultDiv(string exp)
        {
            
            int resultado = 1;
            string digito = "";
            char lastOp = 'x';

            for (int i = 0; i <= exp.Length; i++ )
            {

                char dig = i == exp.Length ? '*' : exp[i];

                if (char.IsLetter(dig) || char.IsDigit(dig) || dig == '-')
                {
                    digito += dig;
                }
                else if (dig == ' ') ;
                else
                {

                    if (lastOp != 'x')
                        resultado = Operacao(lastOp, resultado, GetValor(digito));
                    else
                        resultado = GetValor(digito);

                    lastOp = dig;
                    digito = "";

                }

            }

            return resultado;
        }

        public int SomSub(string exp)
        {
            int resultado = 0;
            string subExp = exp[0].ToString();
            char lastOp = 'x';

            for (int i = 1; i <= exp.Length; i++)
            {

                char dig = i == exp.Length ? '+' : exp[i];

                if (dig == '+' || dig == '-')
                {

                    if (lastOp == 'x' || lastOp == '+')
                        resultado += MultDiv(subExp);
                    else
                        resultado -= MultDiv(subExp);

                    lastOp = dig;
                    subExp = "";
                }
                else if (dig == ' ') ;
                else
                {
                    subExp += dig;
                }

            }

            return resultado;
        }

        public int Operacao(char operador, int oper1, int oper2)
        {
            if (operador == '*')
                return oper1 * oper2;
            else if (operador == '/')
                return oper1 / oper2;
            else throw new Exception();
        }

        public int GetValor(string exp)
        {
            int resultado;
            int sinal = 1;

            if (!int.TryParse(exp, out resultado))
            {
                
                if (exp[0] == '-')
                {
                    sinal = -1;
                    exp = exp.Substring(1);
                }

                if (!constantes.TryGetValue(exp, out resultado))
                {
                    resultado = SomSub(variaveis[exp]);
                    constantes[exp] = resultado * sinal;
                }

            }

            return resultado * sinal;
        }

        #endregion

        #region Constructores
        public P1313() : base() {}
        public P1313(TextWriter writer, TextReader reader) : base(writer, reader) { }
        #endregion

    }
}
