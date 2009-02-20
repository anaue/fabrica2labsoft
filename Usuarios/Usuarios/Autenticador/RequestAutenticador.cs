using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Usuarios.Autenticador
{
    [XmlRoot(ElementName = "RequestAutenticador.cs")]
    public class RequestAutenticador
    {
        public RequestAutenticador()
        {
        }

        private bool _idUsuario;
        [XmlElement(ElementName = "IdUsuario", IsNullable = true)]
        public bool IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }        

        private int _idTela;
        [XmlElement(ElementName = "IdTela", IsNullable = true)]
        public int IdTela
        {
            get { return _idTela; }
            set { _idTela = value; }
        }
    }
}
