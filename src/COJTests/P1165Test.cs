using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1165Test : ProblemaTest<P1165>
    {

        #region Teste de funcioes

        [Test]
        public void Caso_1_eh_Multiplo_de_1()
        {

            var r = Problema.Adivinhar("Y");
            Assert.AreEqual(1, r);

        }

        [Test]
        public void _1_Eh_Multiplo_de_1_Mas_nao_de_2_OK()
        {

            var r = Problema.Adivinhar("YN");
            Assert.AreEqual(1, r);

        }


        [Test]
        public void _1_E_2_Sao_Multiplos_De_2_mas_3_nao_eh_OK()
        {

            var r = Problema.Adivinhar("YYN");
            Assert.AreEqual(2, r);

        }


        [Test]
        public void Multiplos_de_6()
        {

            var r = Problema.Adivinhar("YYYNN");
            Assert.AreEqual(6, r);

        }

        [Test]
        public void Multiplos_de_6_extendido()
        {

            var r = Problema.Adivinhar("YYYNNYNNNNNNNNNN");
            Assert.AreEqual(6, r);

        }

        [Test]
        public void Multiplos_de_13()
        {

            var r = Problema.Adivinhar("YNNNNNNNNNNNY");
            Assert.AreEqual(13, r);

        }

        [Test]
        public void Multiplos_de_12()
        {

            var r = Problema.Adivinhar("YYYYN");
            Assert.AreEqual(12, r);

        }

        [Test]
        public void Multiplos_de_12_Sem_O_6()
        {

            var r = Problema.Adivinhar("YYYYNN");
            Assert.AreEqual(-1, r);

        }

        [Test]
        public void Minimo_Multiplo_1_2_3_4_6_Eh_12()
        {

            var r = Problema.Adivinhar("YYYYNY");
            Assert.AreEqual(12, r);

        }

        [Test]
        public void Se_eh_multiplo_de_8_tambem_eh_multiplo_de_4_e_de_2()
        {

            var r = Problema.Adivinhar("YNNNNNNY");
            Assert.AreEqual(-1, r);

        }

        [Test]
        public void Se_eh_multiplo_de_12_tambem_eh_de_6_4_3_e_de_2()
        {

            var r = Problema.Adivinhar("YNNNNNNNNNNY");
            Assert.AreEqual(-1, r);

        }

        [Test]
        public void Caso_Proposto_1()
        {

            var r = Problema.Adivinhar("YYNYY");
            Assert.AreEqual(20, r);

        }

        [Test]
        public void Caso_Proposto_2()
        {

            var r = Problema.Adivinhar("YYYNNN");
            Assert.AreEqual(-1, r);

        }

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"YYNYY
YYYNNN
*");

            Problema.Executar();

            ExpectSaida(@"20
-1");

        }

        #endregion

    }
}
