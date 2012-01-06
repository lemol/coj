using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Lemolsoft.Practicas.Coj;
using NUnit.Framework;
using SharpTestsEx;

namespace Lemolsoft.Practicas.Coj.Tests
{
    [TestFixture]
    public class ProblemaTest
    {

        #region Constructores e Inicializacao

        [Test]
        public void Constructor_Throw_ArgumentNullException_se_reader_eh_null()
        {

            Assert.Catch<ArgumentNullException>(() =>
            {
                Problema problema = new FooProblema(null, Console.In);
            });
            
        }

        [Test]
        public void Constructor_Throw_ArgumentNullException_se_writer_eh_null()
        {

            Assert.Catch<ArgumentNullException>(() =>
            {
                Problema problema = new FooProblema(Console.Out, null);
            });

        }

        [Test]
        public void Constructor_TudoOK_OK()
        {

            TextWriter writer = Console.Out;
            TextReader reader = Console.In;

            Problema problema = new FooProblema(writer, reader);

            problema.Executar();
            Assert.IsInstanceOf<Problema>(problema);
            Assert.AreEqual(writer, problema.Writer);
            Assert.AreEqual(reader, problema.Reader);

        }

        #endregion

        #region Metodos concretos

        [Test]
        public void SetReader_Throw_ArgumentNullException_se_reader_eh_null()
        {

            FooProblema problema = new FooProblema(Console.Out, Console.In);

            problema.Executing((p) => p.SetReader(null))
                    .Throws<ArgumentNullException>();

        }

        [Test]
        public void SetReader_TudoOK_OK()
        {
            FooProblema problema = new FooProblema(Console.Out, Console.In);
            TextReader reader = new StringReader("Lemolsoft");

            problema.SetReader(reader);

            problema.Reader.Should()
                           .Be
                           .EqualTo(reader);

        }

        [Test]
        public void SetWriter_Throw_ArgumentNullException_se_writer_eh_null()
        {

            FooProblema problema = new FooProblema(Console.Out, Console.In);

            problema.Executing((p) => p.SetWriter(null))
                    .Throws<ArgumentNullException>();

        }

        [Test]
        public void SetWriter_TudoOK_OK()
        {

            FooProblema problema = new FooProblema(Console.Out, Console.In);
            TextWriter writer = new StringWriter();

            problema.SetWriter(writer);

            problema.Writer.Should()
                           .Be
                           .EqualTo(writer);

        }

        #endregion

    }
}
