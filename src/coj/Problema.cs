using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Lemolsoft.Practicas.Coj
{
    public abstract class Problema
    {

        #region Campos

        TextWriter _writer;
        TextReader _reader;

        #endregion

        #region Propriedades

        public TextWriter Writer
        {
            get
            {
                return _writer;
            }
        }

        public TextReader Reader
        {
            get
            {
                return _reader;
            }
        }

        #endregion

        #region Constructores

        public Problema()
            : this(TextWriter.Null, TextReader.Null)
        {
        }

        public Problema(TextWriter writer, TextReader reader)
        {

            if (writer == null)
                throw new ArgumentNullException("writer");

            if (reader == null)
                throw new ArgumentNullException("reader");

            _writer = writer;
            _reader = reader;

        }

        #endregion

        #region Metodos Abstractos
        public abstract void Executar();
        #endregion

        #region Metodos concretos

        public void SetReader(TextReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException("reader");

            _reader = reader;
        }

        public void SetWriter(TextWriter writer)
        {

            if (writer == null)
                throw new ArgumentNullException("writer");

            _writer = writer;

        }

        #endregion

    }
}
