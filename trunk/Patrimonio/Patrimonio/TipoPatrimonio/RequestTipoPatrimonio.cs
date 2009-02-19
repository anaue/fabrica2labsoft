using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.TipoPatrimonio
{
    [XmlRoot(ElementName = "RequestTipoPatrimonio")]
    public class RequestTipoPatrimonio
    {
        public RequestTipoPatrimonio()
        {
        }
        private TipoPatrimonio _tipoPatrimonio;
        [XmlElement(ElementName = "TipoPatrimonio", IsNullable = true)]
        public TipoPatrimonio TipoPatrimonio
        {
            get { return _tipoPatrimonio; }
            set { _tipoPatrimonio = value; }
        }
    }
}
