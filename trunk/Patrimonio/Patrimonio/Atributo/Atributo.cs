using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Atributo
{
    [XmlRoot(ElementName = "Atributo")]
    public class Atributo
    {
        Atributo()
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
        private string _tipo;
        [XmlElement(ElementName = "Tipo")]
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private bool _nulo;
        [XmlElement(ElementName = "Nulo")]
        public bool Nulo
        {
            get { return _nulo; }
            set { _nulo = value; }
        }
        private List<string> _listaValores;
        [XmlElement(ElementName = "ListaValores")]
        public List<string> ListaValores
        {
            get { return _listaValores; }
            set { _listaValores = value; }
        }

        private string _valor;
        [XmlElement(ElementName = "Valor")]
        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

    }
}
