using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{

    [TestFixture]
    public class P1152Test : ProblemaTest<P1152>
    {

        #region Testes Propostos

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"R 1 2
Q 1 1
Q 2 1
W 1
W 5679
C 1 2
Q 1 1
Q 2 1
W 1
W 5679");

            Problema.Executar();

            ExpectSaida(@"5679
1
2 1
1 1
5680
2
2 2
1 2");

        }

        #endregion

    }

}
