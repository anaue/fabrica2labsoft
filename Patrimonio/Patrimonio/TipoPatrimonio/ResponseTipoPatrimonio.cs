﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Arv.Common;

namespace Patrimonio.TipoPatrimonio
{
    [XmlRoot(ElementName = "ResponseTipoPatrimonio")]
    public class ResponseTipoPatrimonio : BaseResponse
    {
        public ResponseTipoPatrimonio()
        {
        }
        private List<TipoPatrimonio> _ListaTipoPatrimonio;
        [XmlArray(ElementName = "ListaTipoPatrimonio", IsNullable = true)]
        public List<TipoPatrimonio> ListaTipoPatrimonio
        {
            get { return _ListaTipoPatrimonio; }
            set { _ListaTipoPatrimonio = value; }
        }
        private List<Atributo.Atributo> _ListaAtributo;
        [XmlArray(ElementName = "ListaAtributo", IsNullable = true)]
        public List<Atributo.Atributo> ListaAtributo
        {
            get { return _ListaAtributo; }
            set { _ListaAtributo = value; }
        }
    }
}
