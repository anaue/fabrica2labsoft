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
        
        private string _Message;
        [XmlElement(ElementName = "Message", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
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
