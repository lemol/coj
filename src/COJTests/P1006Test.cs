using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1006Test : ProblemaTest<P1006>
    {

        #region Teste de metodos

        [Test]
        public void DecodeChar_Para_letras_minusculas_Devolve_a_Proxima()
        {

            P1006 problema = new P1006();

            char resultado1 = problema.DecodeChar('c');
            char resultado2 = problema.DecodeChar('f');
            char resultado3 = problema.DecodeChar('o');

            Assert.AreEqual('b', resultado1);
            Assert.AreEqual('e', resultado2);
            Assert.AreEqual('n', resultado3);

        }

        [Test]
        public void DecodeChar_Para_letras_Maiusculas_devolve_A_Proxima()
        {

            P1006 problema = new P1006();

            char resultado1 = problema.DecodeChar('C');
            char resultado2 = problema.DecodeChar('F');
            char resultado3 = problema.DecodeChar('O');

            Assert.AreEqual('B', resultado1);
            Assert.AreEqual('E', resultado2);
            Assert.AreEqual('N', resultado3);

        }

        [Test]
        public void DecodeChar_Para_letra_A_devolve_letra_Z()
        {
            P1006 problema = new P1006();

            char resultado1 = problema.DecodeChar('a');
            char resultado2 = problema.DecodeChar('A');

            Assert.AreEqual('z', resultado1);
            Assert.AreEqual('Z', resultado2);
        }

        [Test]
        public void DecodeChar_Para_NoLetra_Devolve_Ela_Mesmo()
        {
            P1006 problema = new P1006();

            char resultado1 = problema.DecodeChar('1');
            char resultado2 = problema.DecodeChar(' ');
            char resultado3 = problema.DecodeChar('(');

            Assert.AreEqual('1', resultado1);
            Assert.AreEqual(' ', resultado2);
            Assert.AreEqual('(', resultado3);

        }

        [Test]
        public void DecodeLine_Para_Texto_de_Uma_Letra_Devolve_Ela_Decoded()
        {
            P1006 problema = new P1006();

            char[] resultado = problema.DecodeLine("L");

            Assert.AreEqual('K', resultado[0]);

        }

        [Test]
        public void DecodeLine_Para_Texto_de_Duas_Letras_Devolve_Ela_Decoded()
        {
            P1006 problema = new P1006();

            char[] resultado = problema.DecodeLine("Le");

            Assert.AreEqual("Kd", resultado.ToWholeString());

        }

        [Test]
        public void DecodeLine_Para_Texto_De_Tres_Letras_OK()
        {

            P1006 problema = new P1006();

            char[] resultado = problema.DecodeLine("Lez");

            Assert.AreEqual("dKy", resultado.ToWholeString());

        }

        [Test]
        public void DecodeLine_Para_Texto_De_Quatro_Letras_OK()
        {

            P1006 problema = new P1006();

            char[] resultado = problema.DecodeLine("Leza");

            Assert.AreEqual("dKyz", resultado.ToWholeString());

        }

        [Test]
        public void DecodeLine_Para_Texto_De_Muitas_Letras_OK()
        {

            P1006 problema = new P1006();

            char[] resultado = problema.DecodeLine("(npqsshb1 q000PqJouv,vuvq)u;");

            Assert.AreEqual("program p1000(Input,Output);", resultado.ToWholeString());

        }

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto_OK()
        {

            NovaEntrada(@"(npqsshb1 q000PqJouv,vuvq)u;
bws
:    ,bcfoJufhs;
hcfjo
e    fSbbom(c,);
f    sXjubom(c+);
ofe.");

            Problema.Executar();

            ExpectSaida(@"program p1000(Input,Output);
var
    a,b:Integer;
begin
    Readln(a,b);
    Writeln(a+b);
end.");

        }

        #endregion

    }

    public static class P1006TestExtensions
    {
        public static string ToWholeString(this char[] array)
        {
            System.Text.StringBuilder sbuilder = new StringBuilder();
            foreach (char c in array)
            {
                sbuilder.Append(c);
            }

            return sbuilder.ToString();
        }
    }
}
