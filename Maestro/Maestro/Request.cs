using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Maestro
{
    [XmlRoot(ElementName = "Request")]
    public class Request
    {
        public Request()
        {
        }
        private int _VersaoServico;
        [XmlElement(ElementName = "ServiceVersion")]
        public int VersaoServico
        {
            get { return _VersaoServico; }
            set { _VersaoServico = value; }
        }

        private string _NomeServico;
        [XmlElement(ElementName = "ServiceName")]
        public string NomeServico
        {
            get { return _NomeServico; }
            set { _NomeServico = value; }
        }

    

    }
}
