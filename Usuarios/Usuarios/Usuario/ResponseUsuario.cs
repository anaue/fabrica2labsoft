using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Arv.Common;

namespace Usuarios.Usuario
{
    [XmlRoot(ElementName = "ResponseUsuario")]
    public class ResponseUsuario : BaseResponse
    {
        public ResponseUsuario()
        {
        }

        private string _Message;
        [XmlElement(ElementName = "Message", IsNullable = true)]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        private Usuario _usuario;
        [XmlElement(ElementName = "Usuario", IsNullable = true)]
        public Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private bool _boolUsuario;
        [XmlElement(ElementName = "BoolUsuario")]
        public bool BoolUsuario
        {
            get { return _boolUsuario; }
            set { _boolUsuario = value; }
        }

        private List<Usuario> _listaUsuarios;
        [XmlElement(ElementName = "ListaUsuario", IsNullable = true)]
        public List<Usuario> ListaUsuarios
        {
            get { return _listaUsuarios; }
            set { _listaUsuarios = value; }
        }

    }
}
