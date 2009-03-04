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

        private List<Servico> _listaServicos;
        [XmlArray(ElementName = "ListaServicos",IsNullable=true)]
        public List<Servico> ListaServicos
        {
            get { return _listaServicos; }
            set { _listaServicos = value; }
        }
    
    }
}
