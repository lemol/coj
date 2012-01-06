using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{

    [TestFixture]
    public class P1302Test : ProblemaTest<P1302>
    {

        #region Teste

        [Test]
        public void Linea1_5_OK_1()
        {
            Problema.Linea1_5("DOG");
            ExpectSaida("..#...#...*..");
        }

        [Test]
        public void Linea1_5_OK_2()
        {
            Problema.Linea1_5("DOGS");
            ExpectSaida("..#...#...*...#..");
        }

        [Test]
        public void Linea2_4_OK()
        {
            Problema.Linea2_4("DOG");
            ExpectSaida(".#.#.#.#.*.*.");
        }

        [Test]
        public void Linea3_OK_1()
        {
            Problema.Linea3("DOG");
            ExpectSaida("#.D.#.O.*.G.*");
        }

        [Test]
        public void Linea3_OK_2()
        {
            Problema.Linea3("LEMOLSOFT");
            ExpectSaida("#.L.#.E.*.M.*.O.#.L.*.S.*.O.#.F.*.T.*");
        }

        #endregion

        #region Teste Mais Geral

        [Test]
        public void Teste_Proposto1()
        {
            NovaEntrada("DOG");
            Problema.Executar();
            ExpectSaida(@"..#...#...*..
.#.#.#.#.*.*.
#.D.#.O.*.G.*
.#.#.#.#.*.*.
..#...#...*..");

        }

        #endregion

    }
}
