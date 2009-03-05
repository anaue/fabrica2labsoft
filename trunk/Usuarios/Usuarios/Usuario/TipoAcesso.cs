using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Usuarios.Usuario
{
    public class TipoAcesso
    {
        private int _id;
        [XmlElement(ElementName = "Id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nome;
        [XmlElement(ElementName = "Nome")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
