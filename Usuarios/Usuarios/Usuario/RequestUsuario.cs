using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Usuarios.Usuario
{
    [XmlRoot(ElementName = "RequestUsuario")]
    public class RequestUsuario
    {
        public RequestUsuario()
        {
        }

        private string _nomeUsuario;

        public string NomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }

        private int _idUsuario;
        [XmlElement(ElementName = "idUsuario", IsNullable = false)]
        public int idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }


        private Usuario _usuario;
        [XmlElement(ElementName = "Usuario", IsNullable = true)]
        public Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
    }
}
