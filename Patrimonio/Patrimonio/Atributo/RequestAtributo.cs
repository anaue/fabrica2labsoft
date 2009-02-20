using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Atributo
{
    [XmlRoot(ElementName = "RequestAtributo")]
    public class RequestAtributo
    {
        public RequestAtributo()
        {
        }
        private Atributo _atributo;
        [XmlElement(ElementName = "Atributo", IsNullable = true)]
        public Atributo Atributo
        {
            get { return _atributo; }
            set { _atributo = value; }
        }
        private int _idAtributo;
        [XmlElement(ElementName = "IdAtributo", IsNullable = true)]
        public int IdAtributo
        {
            get { return _idAtributo; }
            set { _idAtributo = value; }
        }

    }
}
