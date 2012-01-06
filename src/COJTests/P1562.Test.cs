using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1562Test : ProblemaTest<P1562>
    {

        #region Teste de Funcoes

        #endregion

        #region Executivos

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"Program Tomas;
Var
A, B, C: Integer;
Begin
A := 4;
B := A + 5;
C := (B + 3) * 4 ^ 2;
End.");

            Problema.Executar();

            ExpectSaida(@"In line 5, variable A is assigned the value 4
In line 6, variable B is assigned the value 9
In line 7, variable C is assigned the value 192");

        }

        #endregion

    }
}
