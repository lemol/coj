using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1473Test : ProblemaTest<P1473>
    {

        #region Teste de Casos

        [Test]
        public void Primeiro_Caso()
        {
            P1473 problema = new P1473();

            int resultado = problema.Caso(2, 2);

            Assert.AreEqual(0, resultado);
        }

        [Test]
        public void Segundo_Caso()
        {
            P1473 problema = new P1473();

            int resultado = problema.Caso(2, 4);

            Assert.AreEqual(4, resultado);
        }


        [Test]
        public void Terceiro_Caso()
        {
            P1473 problema = new P1473();

            int resultado = problema.Caso(3, 5);

            Assert.AreEqual(24, resultado);
        }
        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"2 2
2 4
3 5
0 0");

            Problema.Executar();

            ExpectSaida(@"0
4
24");

        }

        #endregion

    }
}
