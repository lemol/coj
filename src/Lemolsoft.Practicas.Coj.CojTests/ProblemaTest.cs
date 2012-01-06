using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NUnit.Framework;

namespace Lemolsoft.Practicas.Coj.CojTests.NUnit
{
    public abstract class ProblemaTest<TProblema>
        where TProblema : Problema, new()
    {

        #region Campos

        TProblema _problema;

        TextWriter _writer;
        MemoryStream _streamOut;

        TextReader _reader;
        MemoryStream _streamIn;

        #endregion

        #region Propriedades

        public TProblema Problema
        {
            get
            {
                return _problema;
            }
        }

        #endregion

        #region Configuracoes

        [TestFixtureSetUp]
        public virtual void SetupGeral()
        {
            _streamOut = new MemoryStream();
            _writer = new StreamWriter(_streamOut);

            _streamIn = new MemoryStream();
            _reader = new StreamReader(_streamIn);

            _problema = new TProblema();
            _problema.SetWriter(_writer);
            _problema.SetReader(_reader);
        }

        [TearDown]
        public virtual void SetupTearDown()
        {
            //LimparEntrada();
            //LimparSaida();
        }

        [TestFixtureTearDown]
        public virtual void TearDownGeral()
        {
            _streamOut.Close();
            _writer.Close();
            _streamIn.Close();
            _reader.Close();
        }

        #endregion

        #region Metodos

        public void LimparEntrada()
        {
            
            LimparStream<MemoryStream>(ref _streamIn);

        }
        
        public void LimparSaida()
        {

            LimparStream<MemoryStream>(ref _streamOut);

        }

        public void NovaEntrada(string texto)
        {

            byte[] bytes = ASCIIEncoding.ASCII.GetBytes(texto);
            _streamIn.Write(bytes, 0, bytes.Length);
            _streamIn.Seek(0, SeekOrigin.Begin);

        }

        public void ExpectSaida(string texto)
        {
            _writer.Flush();
            _streamOut.Seek(0, SeekOrigin.Begin);
            Assert.AreEqual(texto + "\r\n", GetReaderFor(_streamOut).ReadToEnd());

        }

        #endregion

        #region Metodos Privados
        
        TextReader GetReaderFor(Stream stream)
        {
            return new StreamReader(stream);
        }

        void LimparStream<T>(ref T stream) where T : Stream, new()
        {
            stream.Close();
            stream = new T();
        }

        #endregion
        
    }
}
