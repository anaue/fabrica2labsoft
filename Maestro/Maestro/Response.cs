using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Arv.Common;

namespace Maestro
{ 
    [XmlRoot(ElementName = "Response")]
    public class Response : BaseResponse
    {
    
        public Response()
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
        [XmlElement(ElementName = "Message",IsNullable=true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        public List<Servico> _listaServicos;
        [XmlArray(ElementName = "ListaServicos")]
        public List<Servico> ListaServicos
        {
            get { return _listaServicos; }
            set { _listaServicos = value; }
        }
    
    }
}
