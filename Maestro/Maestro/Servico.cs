using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Maestro
{
    public class Servico
    {
        public Servico()
        {
        }
        private int _idServico;
        [XmlElement(ElementName = "IdServico")]
        public int IdServico
        {
            get { return _idServico; }
            set { _idServico = value; }
        }

        private string _nomeServico;
        [XmlElement(ElementName = "NomeServico")]
        public string NomeServico
        {
            get { return _nomeServico; }
            set { _nomeServico = value; }
        }
        private string _enderecoServico;
        [XmlElement(ElementName = "EnderecoServico")]
        public string EnderecoServico
        {
            get { return _enderecoServico; }
            set { _enderecoServico = value; }
        }
    }
}
