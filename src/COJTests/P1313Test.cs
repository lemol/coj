using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1313Test : ProblemaTest<P1313>
    {
        
        #region Testes de Ambiente para GetValor

        [Test]
        public void GetValor_OK_para_Numero_Positivo()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.GetValor("12345");

            Assert.AreEqual(12345, resultado);
        }

        [Test]
        public void GetValor_OK_para_Numero_Negativo()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.GetValor("-12345");

            Assert.AreEqual(-12345, resultado);
        }

        [Test]
        public void GetValor_OK_para_Constante_Positiva()
        {
            P1313 ambiente = new P1313();
            ambiente.constantes["A23"] = 12;

            int resultado = ambiente.GetValor("A23");

            Assert.AreEqual(12, resultado);
        }

        [Test]
        public void GetValor_OK_para_Constante_Negativa()
        {
            P1313 ambiente = new P1313();
            ambiente.constantes["A23"] = -12;

            int resultado = ambiente.GetValor("-A23");

            Assert.AreEqual(12, resultado);
        }

        #endregion

        #region Testes de Ambiente para DivMult

        [Test]
        public void DivMult_Para_Um_Numero_Devolve_Ele_Mesmo()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.MultDiv("10");

            Assert.AreEqual(10, resultado);
        }

        [Test]
        public void DivMult_Para_Um_Numero_Negativo_Devolve_Ele_Mesmo()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.MultDiv("-10");

            Assert.AreEqual(-10, resultado);
        }

        [Test]
        public void DivMult_Para_Uma_Constante_Devolve_Ele_Mesmo()
        {
            P1313 ambiente = new P1313();

            ambiente.constantes["zz9"] = 20;

            int resultado = ambiente.MultDiv("zz9");

            Assert.AreEqual(20, resultado);
        }

        [Test]
        public void DivMult_Para_Uma_Constante_Negativa_Devolve_Ele_Negativo()
        {
            P1313 ambiente = new P1313();

            ambiente.constantes["zz9"] = 20;

            int resultado = ambiente.MultDiv("- zz9");

            Assert.AreEqual(-20, resultado);
        }

        [Test]
        public void DivMult_OK_Para_Dois_Numeros_1()
        {

            P1313 ambiente = new P1313();

            int resultado = ambiente.MultDiv("24/12");

            Assert.AreEqual(2, resultado);

        }

        [Test]
        public void DivMult_OK_Para_Dois_Numeros_2()
        {

            P1313 ambiente = new P1313();

            int resultado = ambiente.MultDiv("1 /2");

            Assert.AreEqual(0, resultado);

        }

        [Test]
        public void DivMult_OK_Para_Tres_Numeros_1()
        {

            P1313 ambiente = new P1313();

            int resultado = ambiente.MultDiv("63/3 /3");

            Assert.AreEqual(7, resultado);

        }

        [Test]
        public void DivMult_OK_Para_Tres_Numeros_2()
        {

            P1313 ambiente = new P1313();

            int resultado = ambiente.MultDiv("62/31 * 22");

            Assert.AreEqual(44, resultado);
            // 3* 2/3 *3
        }

        [Test]
        public void DivMult_OK_Para_Muitos_Numeros_1()
        {

            P1313 ambiente = new P1313();

            int resultado = ambiente.MultDiv("62/31 * 22 / 4 / 2 * 2 / 5 / 1 * 1");

            Assert.AreEqual(2, resultado);
            // 3* 2/3 *3
        }

        [Test]
        public void DivMult_OK_Para_Constante_1()
        {

            P1313 ambiente = new P1313();

            ambiente.constantes["A21"] = 5;

            int resultado = ambiente.MultDiv("A21 *  5");

            Assert.AreEqual(25, resultado);

        }

        [Test]
        public void DivMult_OK_Para_Constante_2()
        {

            P1313 ambiente = new P1313();

            ambiente.constantes["zz2"] = 2;

            int resultado = ambiente.MultDiv("zz2 /  3");

            Assert.AreEqual(0, resultado);

        }

        [Test]
        public void DivMult_OK_Para_Constante_3()
        {

            P1313 ambiente = new P1313();

            ambiente.constantes["A21"] = 5;
            ambiente.constantes["B15"] = 2;
            ambiente.constantes["C3"] = 10;

            int resultado = ambiente.MultDiv("C3/A21 *  5* 2/ B15 ");

            Assert.AreEqual(10, resultado);

        }

        #endregion

        #region Testes de Ambiente para Soma e Subtaccao

        [Test]
        public void SomSub_para_1_Numero_Devolve_Ele_Mesmo()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.SomSub("10");

            Assert.AreEqual(10, resultado);
        }

        [Test]
        public void SomSub_para_1_Numero_Negativo_Devolve_Ele_Mesmo()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.SomSub("- 10");

            Assert.AreEqual(-10, resultado);
        }

        [Test]
        public void SomSub_para_1_Constante_Negativa_Devolve_Menos_Ele_Mesmo()
        {
            P1313 ambiente = new P1313();

            ambiente.constantes["c4"] = -12;

            int resultado = ambiente.SomSub("- c4");

            Assert.AreEqual(12, resultado);
        }

        [Test]
        public void SomSub_para_2_Numeros_1()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.SomSub(" 1 +  1");

            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void SomSub_para_Muitos_Numeros_1()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.SomSub("1 +  1 + 2 +5+ 6 ");

            Assert.AreEqual(15, resultado);
        }

        [Test]
        public void SomSub_para_Muitos_Numeros_2()
        {
            P1313 ambiente = new P1313();

            int resultado = ambiente.SomSub("1 -  1 + 2 -5+ 6 ");

            Assert.AreEqual(3, resultado);
        }

        #endregion

        #region Testes de Ambiente para GetValor para Variaveis

        [Test]
        public void GetValor_OK_para_Variavel_Positiva()
        {
            P1313 ambiente = new P1313();
            ambiente.variaveis["A23"] = "12 + 13";

            int resultado = ambiente.GetValor("A23");

            Assert.AreEqual(25, resultado);

            Assert.IsTrue(ambiente.constantes.ContainsKey("A23"));
            Assert.AreEqual(25, ambiente.constantes["A23"]);
        }

        [Test]
        public void GetValor_OK_para_Variavel_Negativa()
        {
            P1313 ambiente = new P1313();
            ambiente.variaveis["A23"] = "12 + 13";

            int resultado = ambiente.GetValor("-A23");

            Assert.AreEqual(-25, resultado);

            Assert.IsTrue(ambiente.constantes.ContainsKey("A23"));
            Assert.AreEqual(-25, ambiente.constantes["A23"]);
        }

        [Test]
        public void GetValor_OK_para_Varievel_Com_Constantes()
        {
            P1313 ambiente = new P1313();
            ambiente.variaveis["A23"] = "zz11 + 13";
            ambiente.constantes["zz11"] = 12;

            int resultado = ambiente.GetValor("A23");

            Assert.AreEqual(25, resultado);

            Assert.IsTrue(ambiente.constantes.ContainsKey("A23"));
            Assert.AreEqual(25, ambiente.constantes["A23"]);
        }

        [Test]
        public void GetValor_OK_para_Varievel_Com_Variaveis()
        {
            P1313 ambiente = new P1313();
            ambiente.variaveis["A23"] = "zz11 + 13 * A1";
            ambiente.variaveis["A1"] = "12 - zz11";
            ambiente.constantes["zz11"] = 12;

            int resultado = ambiente.GetValor("A23");

            Assert.AreEqual(12, resultado);

            Assert.IsTrue(ambiente.constantes.ContainsKey("A23"));
            Assert.IsTrue(ambiente.constantes.ContainsKey("A1"));
            Assert.AreEqual(12, ambiente.constantes["A23"]);
            Assert.AreEqual(0, ambiente.constantes["A1"]);
        }

        #endregion

        #region Testes para SetExp

        [Test]
        public void SetExp_Para_Constanstes_OK()
        {

            P1313 ambiente = new P1313();

            ambiente.SetExp("A23 = 12");
            ambiente.SetExp("zz9 =22");

            Assert.AreEqual(2, ambiente.constantes.Count);
            Assert.AreEqual(2, ambiente.chaves.Count);

            Assert.IsTrue(ambiente.constantes.ContainsKey("A23"));
            Assert.IsTrue(ambiente.constantes.ContainsKey("zz9"));
            
            Assert.IsTrue(ambiente.chaves.Contains("A23"));
            Assert.IsTrue(ambiente.chaves.Contains("zz9"));

            Assert.AreEqual(ambiente.constantes["A23"], 12);
            Assert.AreEqual(ambiente.constantes["zz9"], 22);

        }

        [Test]
        public void SetExp_Para_Variaveis_OK()
        {

            P1313 ambiente = new P1313();

            ambiente.SetExp("A47 = 5 + ZZ22");
            ambiente.SetExp("A9 = 13 + A47 * ZZ22 ");

            Assert.AreEqual(2, ambiente.variaveis.Count);
            Assert.AreEqual(2, ambiente.chaves.Count);

            Assert.IsTrue(ambiente.variaveis.ContainsKey("A47"));
            Assert.IsTrue(ambiente.variaveis.ContainsKey("A9"));
            Assert.IsTrue(ambiente.chaves.Contains("A47"));
            Assert.IsTrue(ambiente.chaves.Contains("A9"));

            Assert.AreEqual(ambiente.variaveis["A47"], "5 + ZZ22");
            Assert.AreEqual(ambiente.variaveis["A9"], "13 + A47 * ZZ22");

        }

        [Test]
        public void SetExp_OK()
        {

            P1313 ambiente = new P1313();

            ambiente.SetExp("A47 = 5 + ZZ22");
            ambiente.SetExp("ZZ22 = 3");
            ambiente.SetExp("A9 = 13 + A47 * ZZ22 ");

            Assert.AreEqual(2, ambiente.variaveis.Count);
            Assert.AreEqual(1, ambiente.constantes.Count);
            Assert.AreEqual(3, ambiente.chaves.Count);

            Assert.IsTrue(ambiente.variaveis.ContainsKey("A47"));
            Assert.IsTrue(ambiente.constantes.ContainsKey("ZZ22"));
            Assert.IsTrue(ambiente.variaveis.ContainsKey("A9"));

            Assert.IsTrue(ambiente.chaves.Contains("A47"));
            Assert.IsTrue(ambiente.chaves.Contains("ZZ22"));
            Assert.IsTrue(ambiente.chaves.Contains("A9"));

            Assert.AreEqual(ambiente.variaveis["A47"], "5 + ZZ22");
            Assert.AreEqual(ambiente.constantes["ZZ22"], 3);
            Assert.AreEqual(ambiente.variaveis["A9"], "13 + A47 * ZZ22");

        }

        #endregion

        #region Testes para ImprimirOrdenado

        [Test]
        public void ImprimirOrdenado_OK()
        {

            P1313 ambiente = Problema;

            ambiente.constantes["A47"] = 8;
            ambiente.constantes["ZZ22"] = 3;
            ambiente.constantes["A9"] = 37;

            ambiente.chaves.AddRange(new string[] { "A47", "ZZ22", "A9" });

            ambiente.ImprimirOrdenado();

            ExpectSaida(@"A47 = 8
A9 = 37
ZZ22 = 3");

        }

        #endregion

        #region Teste de Caso

        [Test]
        public void Teste_de_Caso_OK_1()
        {
            
            NovaEntrada(@"3 
A47 = 5 + ZZ22 
ZZ22 = 3 
A9 = 13 + A47 * ZZ22");

            Problema.Caso();

            ExpectSaida(@"A47 = 8
A9 = 37
ZZ22 = 3");

        }

        [Test]
        public void Teste_de_Caso_OK_2()
        {

            NovaEntrada(@"2 
A1 = 4 / 7 + 4 / 7 
B2 = 3 * 3 / 7");

            Problema.Caso();

            ExpectSaida(@"A1 = 0
B2 = 1");

        }

        #endregion

        #region Teste Geral

        [Test]
        public void Teste_Proposto_OK()
        {

            NovaEntrada(@"2

3
A47 = 5 + ZZ22 
ZZ22 = 3 
A9 = 13 + A47 * ZZ22 

2
A1 = 4 / 7 + 4 / 7 
B2 = 3 * 3 / 7");

            Problema.Executar();

            ExpectSaida(@"A47 = 8
A9 = 37
ZZ22 = 3

A1 = 0
B2 = 1");


        }


        #endregion
    }
}
