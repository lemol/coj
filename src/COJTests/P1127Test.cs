using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1127Test : ProblemaTest<P1127>
    {

        #region Teste de funcioes

        [Test]
        public void Teste_Executivo_1()
        {
            
            bool r = Problema.Verificar(1, 1, 3, 3, 1, 4, 3, 2);
            Assert.IsTrue(r);

        }

        [Test]
        public void Teste_Executivo_2()
        {

            bool r = Problema.Verificar(1, 3, 3, 2, 1, 4, 3, 2);
            Assert.IsTrue(r);

        }

        [Test]
        public void Teste_Executivo_3()
        {

            bool r = Problema.Verificar(1, 1, 3, 2, 1, 4, 3, 2);
            Assert.IsTrue(r);

        }

        [Test]
        public void Teste_Executivo_4()
        {

            bool r = Problema.Verificar(2, 1, 4, 3, 1, 4, 3, 2);
            Assert.IsTrue(r);

        }

        [Test]
        public void Teste_Executivo_5()
        {

            bool r = Problema.Verificar(0, 0, 4, 3, 1, 4, 3, 2);
            Assert.IsTrue(r);

        }

        [Test]
        public void Teste_Executivo_6()
        {

            bool r = Problema.Verificar(0, 0, 4, 1, 1, 4, 3, 2);
            Assert.IsFalse(r);

        }

        [Test]
        public void Teste_Executivo_7()
        {

            bool r = Problema.Verificar(0, 0, 1, 5, 1, 4, 3, 2);
            Assert.IsFalse(r);

        }

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"1
4 9 11 2 1 5 7 1");

            Problema.Executar();

            ExpectSaida(@"F");

        }

        #endregion

    }
}
