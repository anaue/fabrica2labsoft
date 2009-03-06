using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Patrimonio.Patrimonio
{
    [XmlRoot(ElementName = "Busca")]
    public class Busca
    {
        public Busca()
        {
        }
        private int idEquipamento = -1;

        public int IdEquipamento
        {
            get { return idEquipamento; }
            set { idEquipamento = value; }
        }
        private DateTime dtCompraMin = DateTime.MinValue;

        public DateTime DtCompraMin
        {
            get { return dtCompraMin; }
            set { dtCompraMin = value; }
        }
        private DateTime dtCompraMax = DateTime.MaxValue;

        public DateTime DtCompraMax
        {
            get { return dtCompraMax; }
            set { dtCompraMax = value; }
        }
        private int numeroNotaFiscal = -1;

        public int NumeroNotaFiscal
        {
            get { return numeroNotaFiscal; }
            set { numeroNotaFiscal = value; }
        }
        private DateTime dtExpGarantiaMin = DateTime.MinValue;

        public DateTime DtExpGarantiaMin
        {
            get { return dtExpGarantiaMin; }
            set { dtExpGarantiaMin = value; }
        }
        private DateTime dtExpGarantiaMax = DateTime.MaxValue;

        public DateTime DtExpGarantiaMax
        {
            get { return dtExpGarantiaMax; }
            set { dtExpGarantiaMax = value; }
        }
        private int idTipoPatrimonio = -1;

        public int IdTipoPatrimonio
        {
            get { return idTipoPatrimonio; }
            set { idTipoPatrimonio = value; }
        }
        private string caminhoFotoNotaFiscal = String.Empty;

        public string CaminhoFotoNotaFiscal
        {
            get { return caminhoFotoNotaFiscal; }
            set { caminhoFotoNotaFiscal = value; }
        }
        private string caminhoFotoPatrimonio = String.Empty;

        public string CaminhoFotoPatrimonio
        {
            get { return caminhoFotoPatrimonio; }
            set { caminhoFotoPatrimonio = value; }
        }
        private int numeroPece = -1;

        public int NumeroPece
        {
            get { return numeroPece; }
            set { numeroPece = value; }
        }
        private string numeroPedido = String.Empty;

        public string NumeroPedido
        {
            get { return numeroPedido; }
            set { numeroPedido = value; }
        }
        private string local = String.Empty;

        public string Local
        {
            get { return local; }
            set { local = value; }
        }
    }
}
