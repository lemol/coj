using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1330Test : ProblemaTest<P1330>
    {

        #region Teste de Funcoes

        #endregion

        #region Executivos

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"1
5
18
VODKA
COKE
19
17");

            Problema.Executar();

            ExpectSaida(@"2");

        }

        #endregion

    }
}
