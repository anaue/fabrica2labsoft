using System;
using System.Data;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace InterfaceUsuario.Classes
{
    public class Patrimonio
    {
        public Patrimonio()
        {
        }
        #region Acessors
        private int _idEquipamento;
        public int IdEquipamento
        {
            get { return _idEquipamento; }
            set { _idEquipamento = value; }
        }

        private int _numeroPECE;
        public int NumeroPECE
        {
            get { return _numeroPECE; }
            set { _numeroPECE = value; }
        }
        private DateTime _dtCompra;
        public DateTime DtCompra
        {
            get { return _dtCompra; }
            set { _dtCompra = value; }
        }
        private int _numeroNotaFiscal;
        public int NumeroNotaFiscal
        {
            get { return _numeroNotaFiscal; }
            set { _numeroNotaFiscal = value; }
        }
        private DateTime _dtExpGarantia;
        public DateTime DtExpGarantia
        {
            get { return _dtExpGarantia; }
            set { _dtExpGarantia = value; }
        }
        private List<Atributo> _listAtributos;
        [XmlElement(ElementName = "ListAtributos")]
        public List<Atributo> ListAtributos
        {
            get { return _listAtributos; }
            set { _listAtributos = value; }
        }

        private string _caminhoFotoNotaFiscal;
        public string CaminhoFotoNotaFiscal
        {
            get { return _caminhoFotoNotaFiscal; }
            set { _caminhoFotoNotaFiscal = value; }
        }

        private string _caminhoFotoPatrimonio;
        public string CaminhoFotoPatrimonio
        {
            get { return _caminhoFotoPatrimonio; }
            set { _caminhoFotoPatrimonio = value; }
        }

        private string _localPatrimonio;
        public string LocalPatrimonio
        {
            get { return _localPatrimonio; }
            set { _localPatrimonio = value; }
        }

        private string _numeroPedido;
        public string NumeroPedido
        {
            get { return _numeroPedido; }
            set { _numeroPedido = value; }
        }
        #endregion Acessors


        internal void CadastraPatrimonio()
        {
            throw new NotImplementedException();
        }
    }
}
