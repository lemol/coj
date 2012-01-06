using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1510Test : ProblemaTest<P1510>
    {

        #region Teste de funcoes

        [Test]
        public void Comprimir_a_devolve_a()
        {

            string r = Problema.Comprimir("a");
            Assert.AreEqual("@a", r);

        }

        [Test]
        public void Comprimir_aaa_devolve_aaa()
        {

            string r = Problema.Comprimir("aaa");
            Assert.AreEqual("@aaa", r);

        }

        [Test]
        public void Comprimir_aaaa_devolve_4a()
        {

            string r = Problema.Comprimir("aaaa");
            Assert.AreEqual("@4a", r);

        }

        [Test]
        public void Comprimir_aaaaaaaaa_devolve_9a()
        {

            string r = Problema.Comprimir("aaaaaaaaa");
            Assert.AreEqual("@9a", r);

        }

        [Test]
        public void Comprimir_aaaaaaaaaa_devolve_9aa()
        {

            string r = Problema.Comprimir("aaaaaaaaaa");
            Assert.AreEqual("@9aa", r);

        }

        [Test]
        public void Comprimir_aaaaaaaaaaa_devolve_9a2a()
        {

            string r = Problema.Comprimir("aaaaaaaaaaa");
            Assert.AreEqual("@9aaa", r);

        }

        [Test]
        public void Comprimir_aabaaaabbbbbaabaaa_devolve_aab4a4baabaaa()
        {

            string r = Problema.Comprimir("aabaaaabbbbbaabaaa");
            Assert.AreEqual("@aab4a5baabaaa", r);

        }

        [Test]
        public void Merda()
        {
            string r = Problema.Comprimir("aaaaaaaaaababababaaaaba");
            Assert.AreEqual("@9aabababab4aba", r);
        }

        [Test]
        public void Merda2()
        {
            string r = Problema.Comprimir("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

            Assert.AreEqual(66, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa".Length);
            Assert.AreEqual("@9a9a9a9a9a9a9a6a", r);
        }

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"3
AAAAB
aaaaaaaaaab
aaaaaaaaaaaaaab");

            Problema.Executar();

            ExpectSaida(@"@4AB
@9aab
@9a5ab");

        }

        #endregion

    }
}
