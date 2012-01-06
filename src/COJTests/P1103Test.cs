using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1103Test : ProblemaTest<P1103>
    {

        #region Teste de funcioes

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"11
26");

            Problema.Executar();

            ExpectSaida(@"4
13");

        }

        #endregion

    }
}
