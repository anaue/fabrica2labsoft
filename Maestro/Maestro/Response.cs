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
        
        //private int _statusCode;
        //[XmlElement(ElementName = "StatusCode")]
        //public int StatusCode
        //{
        //    get { return _statusCode; }
        //    set { _statusCode = value; }
        //}

        private string _Message;
        [XmlElement(ElementName = "Message",IsNullable=true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        private string _ServiceAddress;
        [XmlElement(ElementName = "ServiceAddress")]
        public string ServiceAddress
        {
            get { return _ServiceAddress; }
            set { _ServiceAddress = value; }
        }

        //private string _TipoClasseObj;
        //[XmlElement(ElementName = "TipoClasseObjeto", IsNullable =true)]
        //public string TipoClasseObj
        //{
        //    get { return _TipoClasseObj; }
        //    set { _TipoClasseObj = value; }
        //}
        //private List<Objeto> _Objetos;

        //[XmlArray(ElementName = "ColecaoObjetos")]
        //public List<Objeto> Objetos
        //{
        //    get { return _Objetos; }
        //    set { _Objetos = value; }
        //}
    
    }
}
