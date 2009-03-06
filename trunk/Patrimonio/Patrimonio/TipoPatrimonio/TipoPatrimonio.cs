using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.TipoPatrimonio
{
    [XmlRoot(ElementName = "TipoPatrimonio")]
    public class TipoPatrimonio
    {
        public TipoPatrimonio()
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
        private string _descricao;
        [XmlElement(ElementName = "Descricao")]
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private List<Atributo.Atributo> listAtributos;
        [XmlElement(ElementName = "ListAtributos")]
        public List<Atributo.Atributo> ListAtributos
        {
            get { return listAtributos; }
            set { listAtributos = value; }
        }

    }
}
