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
        private int _statusCode;
        [XmlElement(ElementName = "StatusCode")]
        public int StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }

        private string _Message;
        [XmlElement(ElementName = "Message", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        private bool _estaRegistrado;
        [XmlElement(ElementName = "EstaRegistrado", IsNullable = true)]
        public bool EstaRegistrado
        {
            get { return _estaRegistrado; }
            set { _estaRegistrado = value; }
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
