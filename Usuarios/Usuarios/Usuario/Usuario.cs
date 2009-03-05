using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Usuarios.Usuario
{
    [XmlRoot(ElementName = "Usuario")]
    public class Usuario
    {
        public Usuario()
        {
        }

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

        private string _senha;
        [XmlElement(ElementName = "Senha")]
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        private string _descricao;
        [XmlElement(ElementName = "Descricao")]
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private TipoAcesso _tipoAcesso;
        [XmlElement(ElementName = "TipoAcesso")]
        public TipoAcesso TipoAcesso
        {
            get { return _tipoAcesso; }
            set { _tipoAcesso = value; }
        }
    }
}
