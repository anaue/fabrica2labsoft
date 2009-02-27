using System;
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
        private int _statusCode;
        [XmlElement(ElementName = "StatusCode")]
        public int StatusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }

        private string _Message;
        [XmlElement(ElementName = "Message", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        private List<TipoPatrimonio> _ListaTipoPatrimonio;
        [XmlArray(ElementName = "ListaTipoPatrimonio", IsNullable = true)]
        public List<TipoPatrimonio> ListaTipoPatrimonio
        {
            get { return _ListaTipoPatrimonio; }
            set { _ListaTipoPatrimonio = value; }
        }
    }
}
