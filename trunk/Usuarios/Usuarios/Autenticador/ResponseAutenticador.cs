using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Arv.Common;

namespace Usuarios.Autenticador
{
    [XmlRoot(ElementName = "ResponseAutenticador")]
    public class ResponseAutenticador : BaseResponse
    {
        public ResponseAutenticador()
        {
        }

        private bool _registroCorreto;
        [XmlElement(ElementName = "RegistroCorreto", IsNullable = true)]
        public bool RegistroCorreto
        {
            get { return _registroCorreto; }
            set { _registroCorreto = value; }
        }

        private Autenticador _autenticador;
        [XmlElement(ElementName = "Autenticador", IsNullable = true)]
        public Autenticador Autenticador
        {
            get { return _autenticador; }
            set { _autenticador = value; }
        }
    }
}
