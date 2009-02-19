using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Patrimonio
{
    [XmlRoot(ElementName = "Manutencao")]
    public class Manutencao
    {

        public Manutencao()
        {
        }
        private int _idManutencao;
        [XmlElement(ElementName = "IdManutencao")]
        public int IdManutencao
        {
            get { return _idManutencao; }
            set { _idManutencao = value; }
        }
        private DateTime _dtManutencao;
        [XmlElement(ElementName = "DataManutencao")]
        public DateTime DtManutencao
        {
            get { return _dtManutencao; }
            set { _dtManutencao = value; }
        }
        private string _motivo;
        [XmlElement(ElementName = "Motivo")]
        public string Motivo
        {
            get { return _motivo; }
            set { _motivo = value; }
        }
        private string _observacao;
        [XmlElement(ElementName = "Observacao")]
        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
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
