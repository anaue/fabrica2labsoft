using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Patrimonio
{
    [XmlRoot(ElementName = "RequestPatrimonio")]
    public class RequestPatrimonio
    {
        public RequestPatrimonio()
        {
        }
        private Patrimonio _patrimonio;
        [XmlElement(ElementName = "Patrimonio", IsNullable = true)]
        public Patrimonio Patrimonio
        {
            get { return _patrimonio; }
            set { _patrimonio = value; }
        }
    }
}
