using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InterfaceUsuario.Classes
{
    public class Manutencao
    {
        public Manutencao()
        {
        }
        #region Accessors
        private int _idManutencao;
        public int IdManutencao
        {
            get { return _idManutencao; }
            set { _idManutencao = value; }
        }
        private DateTime _dtManutencao;
        public DateTime DtManutencao
        {
            get { return _dtManutencao; }
            set { _dtManutencao = value; }
        }
        private string _motivo;
        public string Motivo
        {
            get { return _motivo; }
            set { _motivo = value; }
        }
        private string _observacao;
        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
        private int _idUsuario;
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        private int _idPatrimonio;
        public int IdPatrimonio
        {
            get { return _idPatrimonio; }
            set { _idPatrimonio = value; }
        }

        #endregion Accessors
    }
}
