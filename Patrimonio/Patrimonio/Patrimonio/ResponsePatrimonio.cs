using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Arv.Common;

namespace Patrimonio.Patrimonio
{
    [XmlRoot(ElementName = "ResponsePatrimonio")]
    public class ResponsePatrimonio : BaseResponse
    {
        public ResponsePatrimonio()
        {
        }
        private Manutencao _manutencao;
        [XmlElement(ElementName = "Manutencao")]
        public Manutencao Manutencao
        {
            get { return _manutencao; }
            set { _manutencao = value; }
        }


        private List<Patrimonio> _listaPatrimonio;
        [XmlElement(ElementName = "ListaPatrimonio")]
        public List<Patrimonio> ListaPatrimonio
        {
            get { return _listaPatrimonio; }
            set { _listaPatrimonio = value; }
        }

    }
}
