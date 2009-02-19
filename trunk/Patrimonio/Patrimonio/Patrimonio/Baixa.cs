using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Patrimonio
{
    [XmlRoot(ElementName = "Baixa")]
    public class Baixa
    {
        public Baixa()
        {
        }
        private int _idBaixa;
        [XmlElement(ElementName = "IdBaixa")]
        public int IdBaixa
        {
            get { return _idBaixa; }
            set { _idBaixa = value; }
        }
        private DateTime _dtBaixa;
        [XmlElement(ElementName = "DataManutencao")]
        public DateTime DtBaixa
        {
            get { return _dtBaixa; }
            set { _dtBaixa = value; }
        }
        private string _destinoBaixa;
        [XmlElement(ElementName = "DestinoBaixa")]
        public string DestinoBaixa
        {
            get { return _destinoBaixa; }
            set { _destinoBaixa = value; }
        }
        private string _observacoesBaixa;
        [XmlElement(ElementName = "ObservacoesBaixa")]
        public string ObservacoesBaixa
        {
            get { return _observacoesBaixa; }
            set { _observacoesBaixa = value; }
        }
        private int _idUsuario;
        [XmlElement(ElementName = "IdUsuario")]
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
    }
}
