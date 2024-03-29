﻿using System;
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

        private List<Atributo.Atributo> _listAtributos;
        [XmlElement(ElementName = "ListAtributos")]
        public List<Atributo.Atributo> ListAtributos
        {
            get { return _listAtributos; }
            set { _listAtributos = value; }
        }

        private string _caminhoFotoNotaFiscal;
        [XmlElement(ElementName = "CaminhoFotoNotaFiscal")]
        public string CaminhoFotoNotaFiscal
        {
            get { return _caminhoFotoNotaFiscal; }
            set { _caminhoFotoNotaFiscal = value; }
        }

        private string _caminhoFotoPatrimonio;
        [XmlElement(ElementName = "CaminhoFotoPatrimonio")]
        public string CaminhoFotoPatrimonio
        {
            get { return _caminhoFotoPatrimonio; }
            set { _caminhoFotoPatrimonio = value; }
        }

        private string _localPatrimonio;
        [XmlElement(ElementName = "LocalPatrimonio")]
        public string LocalPatrimonio
        {
            get { return _localPatrimonio; }
            set { _localPatrimonio = value; }
        }

        private string _numeroPedido;
        [XmlElement(ElementName = "NumeroPedido")]
        public string NumeroPedido
        {
            get { return _numeroPedido; }
            set { _numeroPedido = value; }
        }

        private int _idTipoPatrimonio;
        [XmlElement(ElementName = "IdTipoPatrimonio")]
        public int IdTipoPatrimonio
        {
            get { return _idTipoPatrimonio;}
            set { _idTipoPatrimonio = value; }
        }

    }
}
