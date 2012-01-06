using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1498Test : ProblemaTest<P1498>
    {

        #region Teste de Producto

        [Test]
        public void Producto_De_um_numeros_Devolve_ele_mesmo()
        {
            P1498 problema = new P1498();
            problema.exp = "3";

            long resultado = problema.Producto();

            Assert.AreEqual(3, resultado);
        }

        [Test]
        public void Producto_De_dois_numeros_OK()
        {
            P1498 problema = new P1498();
            problema.constantes['a'] = 2;
            problema.exp = "3a";

            long resultado = problema.Producto();

            Assert.AreEqual(6, resultado);
        }

        [Test]
        public void Producto_Tres_dois_numeros_OK()
        {
            P1498 problema = new P1498();
            problema.constantes['a'] = 2;
            problema.constantes['b'] = 3;
            problema.constantes['c'] = 3;
            problema.exp = "3abc";

            long resultado = problema.Producto();

            Assert.AreEqual(54, resultado);
        }

        [Test]
        public void Producto_Comecando_com_variavel_OK()
        {
            P1498 problema = new P1498();
            problema.constantes['a'] = 2;
            problema.constantes['b'] = 3;
            problema.constantes['c'] = 3;
            problema.exp = "a3bc";

            long resultado = problema.Producto();

            Assert.AreEqual(54, resultado);
        }

        [Test]
        public void Producto_de_variaveis_OK()
        {
            P1498 problema = new P1498();
            problema.constantes['a'] = 2;
            problema.constantes['b'] = 3;
            problema.constantes['c'] = 3;
            problema.exp = "abc";

            long resultado = problema.Producto();

            Assert.AreEqual(18, resultado);
        }
        #endregion

        #region Testes de Soma

        [Test]
        public void Soma_1_numero_devolve_ele_mesmo()
        {

            P1498 problema = new P1498();
            problema.exp = "44";

            long resultado = problema.Soma();

            Assert.AreEqual(44, resultado);

        }

        [Test]
        public void Soma_1_variavel_devolve_ele_mesmo()
        {

            P1498 problema = new P1498();
            problema.constantes['a'] = 44;
            problema.exp = "a";

            long resultado = problema.Soma();

            Assert.AreEqual(44, resultado);

        }

        [Test]
        public void Soma_2_numeros_OK()
        {

            P1498 problema = new P1498();
            problema.exp = "44+123";

            long resultado = problema.Soma();

            Assert.AreEqual(167, resultado);

        }

        [Test]
        public void Soma_2_variaveis_OK()
        {

            P1498 problema = new P1498();
            problema.constantes['a'] = 44;
            problema.constantes['b'] = 123;
            problema.exp = "a+b";

            long resultado = problema.Soma();

            Assert.AreEqual(167, resultado);

        }

        [Test]
        public void Soma_muitos_numeros_OK()
        {

            P1498 problema = new P1498();
            problema.exp = "44+123-20-7";

            long resultado = problema.Soma();

            Assert.AreEqual(140, resultado);

        }

        [Test]
        public void Soma_muitas_variaveis_OK()
        {

            P1498 problema = new P1498();
            problema.constantes['a'] = 44;
            problema.constantes['b'] = 123;
            problema.constantes['c'] = 20;
            problema.constantes['d'] = 7;

            problema.exp = "a+b-c-d";

            long resultado = problema.Soma();

            Assert.AreEqual(140, resultado);

        }


        [Test]
        public void Soma_muitas_variaveis_com_muitos_numeros_OK()
        {

            P1498 problema = new P1498();
            problema.constantes['a'] = 44;
            problema.constantes['b'] = 123;
            problema.constantes['c'] = 20;
            problema.constantes['d'] = 7;

            problema.exp = "a+20+b-10+20-c-d-10-20";

            long resultado = problema.Soma();

            Assert.AreEqual(140, resultado);

        }

        [Test]
        public void Menos_numero_OK()
        {
            P1498 problema = new P1498();

            problema.exp = "-2011";

            long resultado = problema.Soma();

            Assert.AreEqual(-2011, resultado);
        }

        [Test]
        public void Menos_variable_OK()
        {
            P1498 problema = new P1498();
            problema.constantes['a'] = 2011;
            problema.exp = "-a";

            long resultado = problema.Soma();

            Assert.AreEqual(-2011, resultado);
        }

        [Test]
        public void Menos_numero_somando_com_otro_numero_OK()
        {
            P1498 problema = new P1498();

            problema.exp = "-2011+2012";

            long resultado = problema.Soma();

            Assert.AreEqual(1, resultado);
        }

        [Test]
        public void Menos_variable_somando_com_otra_coisa_OK()
        {
            P1498 problema = new P1498();
            problema.constantes['a'] = 2011;
            problema.exp = "-a+2012";

            long resultado = problema.Soma();

            Assert.AreEqual(1, resultado);
        }

        #endregion

        #region Testes Integral de Soma e Producto

        [Test]
        public void Soma_Com_Productos_1()
        {
            P1498 problema = new P1498();
            problema.constantes['a'] = 2;
            problema.constantes['b'] = 3;
            problema.constantes['c'] = 10;
            problema.constantes['d'] = 0;

            problema.exp = "3a2+2cb-10+20dabc-20";

            long resultado = problema.Soma();

            Assert.AreEqual(42, resultado);
        }

        #endregion

        #region Outros Testes

        [Test]
        public void Se_nao_for_dado_alguma_das_constante_Devolve_UNDEFINED()
        {
            NovaEntrada(@"235ahah+c-12bb
b=1
c=-7
h=2");

            Problema.Executar();

            ExpectSaida(@"UNDEFINED");

        }

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_proposto_OK()
        {
            NovaEntrada(@"235ahah+c-12bb
b=1
c=-7
a=10
h=2");

            Problema.Executar();

            ExpectSaida(@"93981");

        }

        #endregion

    }
}
