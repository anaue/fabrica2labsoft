using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Arv.Common;

namespace Patrimonio.Atributo
{
    [XmlRoot(ElementName = "ResponseAtributo")]
    public class ResponseAtributo : BaseResponse
    {
        public ResponseAtributo()
        {
        }

        private string _Message;
        [XmlElement(ElementName = "Message", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        private List<Atributo> _ListaAtributos;

        [XmlArray(ElementName = "ListaAtributos", IsNullable = true)]

        public List<Atributo> ListaAtributos
        {
            get { return _ListaAtributos; }
            set { _ListaAtributos = value; }
        }

    }
}
