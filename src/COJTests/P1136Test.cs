using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{

    [TestFixture]
    public class P1136Test : ProblemaTest<P1136>
    {

        #region Teste Proposto

        [Test]
        public void Caso_proposto_1()
        {
            NovaEntrada(@"1 10");

            Problema.Caso();

            ExpectSaida(@"2
3
5
7");
        }


        [Test]
        public void Caso_proposto_2()
        {
            NovaEntrada(@"3 5");

            Problema.Caso();

            ExpectSaida(@"3
5");
        }

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"2
1 10
3 5");

            Problema.Executar();

            ExpectSaida(@"2
3
5
7

3
5");

        }

        #endregion

    }
}
