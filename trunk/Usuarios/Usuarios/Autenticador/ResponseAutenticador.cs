using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Usuarios.Autenticador
{
    [XmlRoot(ElementName = "ResponseAutenticador")]
    public class ResponseAutenticador
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
    }
}
