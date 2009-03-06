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
        private Manutencao _manutencao;
        [XmlElement(ElementName = "Manutencao", IsNullable = true)]
        public Manutencao Manutencao
        {
            get { return _manutencao; }
            set { _manutencao = value; }
        }
        private Baixa _baixa;
        [XmlElement(ElementName = "BaixaPatrimonio", IsNullable = true)]
        public Baixa Baixa
        {
            get { return _baixa; }
            set { _baixa = value; }
        }

    }
}
