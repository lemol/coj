using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1195Test : ProblemaTest<P1195>
    {

        #region Teste de Funcoes

        #endregion

        #region Executivos

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"1111000 2 10
1111000 2 16
2102101 3 10
2102101 3 15
12312 4 2
1A 15 2
1234567 10 16
ABCD 16 15");

            Problema.Executar();

            ExpectSaida(@"----120
-----78
---1765
----7CA
--ERROR
--11001
-12D687
---D071");

        }

        #endregion

    }
}
