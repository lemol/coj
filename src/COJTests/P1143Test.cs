using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1143Test : ProblemaTest<P1143>
    {

        #region Teste de funcioes

        [Test]
        public void Caso_Proposto_1()
        {

            string r = Problema.Comprimir("toioynnkpheleaigshareconhtomesnlewx", 5);
            Assert.AreEqual("theresnoplacelikehomeonasnowynightx", r);

        }

        [Test]
        public void Caso_Proposto_2()
        {

            string r = Problema.Comprimir("ttyohhieneesiaabss", 3);
            Assert.AreEqual("thisistheeasyoneab", r);

        }

        [Test]
        public void Caso_3()
        {

            string r = Problema.Comprimir("lolderuazatxaioxmsnx", 4);
            Assert.AreEqual("lezamoraislutondaxxx", r);

        }

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"5
toioynnkpheleaigshareconhtomesnlewx
3
ttyohhieneesiaabss
0");

            Problema.Executar();

            ExpectSaida(@"theresnoplacelikehomeonasnowynightx
thisistheeasyoneab");

        }

        #endregion

    }
}
