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

        private string _Message;
        [XmlElement(ElementName = "Message", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
    }
}
