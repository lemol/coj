using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1173Test : ProblemaTest<P1173>
    {

        #region Teste de funcioes

        #endregion

        #region Teste Proposto

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada("print \"No bugs here...\"\n\nvoid hello() {\nBUGBUG\nprintfBUG(\"Hello, world!\\n\");\n}\n\nwriBUGBUGtelBUGn(\"Hello B-U-G\");");

            Problema.Executar();

            ExpectSaida("print \"No bugs here...\"\r\n\r\n" +

"void hello() {\r\n\r\n" +

"printf(\"Hello, world!\\n\");\r\n" +
"}\r\n\r\n" +

"writeln(\"Hello B-U-G\");");

        }

        #endregion

    }
}
