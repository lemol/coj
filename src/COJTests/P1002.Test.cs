using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1002Test : ProblemaTest<P1002>
    {

        #region Teste de Funcoes

        #endregion

        #region Executivos

        [Test]
        public void Teste_1()
        {

            NovaEntrada(@"1
5
.....
.####
.....
...##
...#.");

            Problema.Executar();

            ExpectSaida(@"3");

        }

        [Test]
        public void Teste_2()
        {

            NovaEntrada(@"1
1
.");

            Problema.Executar();

            ExpectSaida(@"1");

        }

        [Test]
        public void Teste_3()
        {

            NovaEntrada(@"1
1
#");

            Problema.Executar();

            ExpectSaida(@"0");

        }


        [Test]
        public void Teste_4()
        {

            NovaEntrada(@"1
6
#.....
##....
......
......
###...
....#.");

            Problema.Executar();

            ExpectSaida(@"4");

        }
        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"2
10
..........
.#####....
..#..###..
...##.....
...#..#...
...#...###
....######
..........
##########
#########.
5
##..#
....#
.#..#
####.
.#..#");

            Problema.Executar();

            ExpectSaida(@"3
2");

        }

        #endregion

    }
}
