using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Patrimonio
{
    [XmlRoot(ElementName = "Patrimonio")]
    public class Patrimonio
    {
        public Patrimonio()
        { 
        }
        private int _idEquipamento;
        [XmlElement(ElementName = "IdEquipamento")] 
        public int IdEquipamento
        {
            get { return _idEquipamento; }
            set { _idEquipamento = value; }
        }

        private int _numeroPECE;
        [XmlElement(ElementName = "NumeroPECE")]
        public int NumeroPECE
        {
            get { return _numeroPECE; }
            set { _numeroPECE = value; }
        }
        private DateTime _dtCompra;
        [XmlElement(ElementName = "DataCompra")]
        public DateTime DtCompra
        {
            get { return _dtCompra; }
            set { _dtCompra = value; }
        }
        private int _numeroNotaFiscal;
        [XmlElement(ElementName = "NumeroNotaFiscal")]
        public int NumeroNotaFiscal
        {
            get { return _numeroNotaFiscal; }
            set { _numeroNotaFiscal = value; }
        }
        private DateTime _dtExpGarantia;
        [XmlElement(ElementName = "DataExpGarantia")]
        public DateTime DtExpGarantia
        {
            get { return _dtExpGarantia; }
            set { _dtExpGarantia = value; }
        }


    }
}
