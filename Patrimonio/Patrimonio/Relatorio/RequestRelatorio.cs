using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Relatorio
{
    [XmlRoot(ElementName = "RequestRelatorio")]
    public class RequestRelatorio
    {
        public RequestRelatorio()
        {
        }
        private Relatorio _relatorio;
        [XmlElement(ElementName = "Relatorio", IsNullable = true)]
        public Relatorio Relatorio
        {
            get { return _relatorio; }
            set { _relatorio = value; }
        }
    }
}
