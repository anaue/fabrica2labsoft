using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Arv.Common;

namespace Patrimonio.Relatorio
{
    [XmlRoot(ElementName = "ResponseRelatorio")]
    public class ResponseRelatorio : BaseResponse
    {
        public ResponseRelatorio()
        {
        }

        private List<Patrimonio.Patrimonio> _ListaPatrimonios;

        [XmlArray(ElementName = "ListaAtributos", IsNullable = true)]

        public List<Patrimonio.Patrimonio> ListaPatrimonios
        {
            get { return _ListaPatrimonios; }
            set { _ListaPatrimonios = value; }
        }
    }
}
