using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Atributo
{
    [XmlRoot(ElementName = "ResponseAtributo")]
    public class ResponseAtributo
    {
        public ResponseAtributo()
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
        private List<Atributo> _ListaAtributos;
        [XmlElement(ElementName = "ListaAtributos", IsNullable = true)]

        public List<Atributo> ListaAtributos
        {
            get { return _ListaAtributos; }
            set { _ListaAtributos = value; }
        }

    }
}
