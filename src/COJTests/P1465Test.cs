using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1465Test : ProblemaTest<P1465>
    {

        #region Testes Pequenos
        
        [Test]
        public void Toda_Coma_eh_seguido_por_exatamente_um_espaco()
        {

            Problema.Caso(",,5,...,,,,");
            ExpectSaida(", , 5, ..., , , ,");

        }

        [Test]
        public void Cada_TresPontos_eh_Precedido_de_exatamente_um_espaco_1()
        {

            Problema.Caso("...5......,...");
            ExpectSaida("...5 ... ..., ...");

        }

        [Test]
        public void Cada_TresPontos_eh_Precedido_de_exatamente_um_espaco_2()
        {

            Problema.Caso("...5 ......, ...");
            ExpectSaida("...5 ... ..., ...");

        }

        [Test]
        public void Cada_TresPontos_eh_Precedido_de_exatamente_um_espaco_3()
        {

            Problema.Caso("...5 ... ..., ...");
            ExpectSaida("...5 ... ..., ...");

        }

        [Test]
        public void Cada_TresPontos_eh_Precedido_de_exatamente_um_espaco_4()
        {

            Problema.Caso("...5  ...   ...,   ...");
            ExpectSaida("...5 ... ..., ...");

        }

        [Test]
        public void Nao_Pode_Existir_mais_de_um_espaco_entre_Dois_Numeros_1()
        {
            Problema.Caso("...5  6 ... ..., ...");
            ExpectSaida("...5 6 ... ..., ...");
        }

        [Test]
        public void Nao_Pode_Haver_Espaco_entre_Numero_e_Virgula_1()
        {
            Problema.Caso("...2 ,......");
            ExpectSaida("...2, ... ...");
        }

        [Test]
        public void Nao_Pode_Haver_Espaco_entre_Numero_e_Virgula_2()
        {
            Problema.Caso("...2  ,......");
            ExpectSaida("...2, ... ...");
        }

        #endregion

        #region Teste Mais Geral
        
        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada
            (@"4,2 ,1,..., 25
1,,,4...5......6
...,1,2,3,...");
            Problema.Executar();
            ExpectSaida
            (@"4, 2, 1, ..., 25
1, , , 4 ...5 ... ...6
..., 1, 2, 3, ...");

        }

        #endregion
        
    }

}
