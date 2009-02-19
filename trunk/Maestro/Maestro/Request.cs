using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Maestro
{
    [XmlRoot(ElementName = "Request")]
    public class Request
    {
        public Request()
        {
        }

        private string _NomeServico;

        [XmlElement(ElementName = "ServiceName")]
        public string NomeServico
        {
            get { return _NomeServico; }
            set { _NomeServico = value; }
        }

        //private string _TipoClasseObj;
        //[XmlElement(ElementName = "TipoClasseObjeto", IsNullable = true)]
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
