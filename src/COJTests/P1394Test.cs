using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1394Test : ProblemaTest<P1394>
    {

        #region Teste de fns

        [Test]
        public void Fn_de_3_igual_a_2()
        {

            int r = Problema.Fn(3);
            Assert.AreEqual(2, r);

        }

        [Test]
        public void Fn_de_4_igual_a_2()
        {

            int r = Problema.Fn(4);
            Assert.AreEqual(2, r);

        }

        [Test]
        public void Fn_de_2_igual_a_1()
        {
            
            int r = Problema.Fn(2);
            Assert.AreEqual(1, r);

        }

        [Test]
        public void Fn_de_53_igual_a_27()
        {

            int r = Problema.Fn(53);
            Assert.AreEqual(27, r);

        }

        [Test]
        public void Fn_de_153_igual_a_77()
        {

            int r = Problema.Fn(153);
            Assert.AreEqual(77, r);

        }

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"2 
53
153
-1");

            Problema.Executar();

            ExpectSaida(@"f(2) = 1

f(53) = 27

f(153) = 77");

        }

        #endregion

    }
}
