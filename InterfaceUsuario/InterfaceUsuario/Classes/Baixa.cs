using System;
using System.Data;

namespace InterfaceUsuario.Classes
{
    public class Baixa
    {
        public Baixa()
        {
        }
        #region Accessors
        private int _idBaixa;
        public int IdBaixa
        {
            get { return _idBaixa; }
            set { _idBaixa = value; }
        }
        private DateTime _dtBaixa;
        public DateTime DtBaixa
        {
            get { return _dtBaixa; }
            set { _dtBaixa = value; }
        }
        private string _destinoBaixa;
        public string DestinoBaixa
        {
            get { return _destinoBaixa; }
            set { _destinoBaixa = value; }
        }
        private string _observacoesBaixa;
        public string ObservacoesBaixa
        {
            get { return _observacoesBaixa; }
            set { _observacoesBaixa = value; }
        }
        private int _idUsuario;
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        #endregion Accessors

    }
}
