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

        private string _nomeUsuario;

        public string NomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }

        private int _idUsuario;
        [XmlElement(ElementName = "IdUsuario")]
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private string _senha;
        [XmlElement(ElementName = "Senha", IsNullable = true)]
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        private int _idTela;
        [XmlElement(ElementName = "IdTela")]
        public int IdTela
        {
            get { return _idTela; }
            set { _idTela = value; }
        }
    }
}
