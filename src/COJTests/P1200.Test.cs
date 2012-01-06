using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1200Test : ProblemaTest<P1200>
    {

        #region Teste de Funcoes

        #endregion

        #region Executivos

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"1
21212
12");

            Problema.Executar();

            ExpectSaida(@"3");

        }

        #endregion

    }
}
