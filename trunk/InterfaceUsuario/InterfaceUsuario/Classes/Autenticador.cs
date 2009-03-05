using System;
using System.Data;


namespace InterfaceUsuario.Classes
{
    public class Autenticador
    {
        public Autenticador()
        {
        }
        #region Accessors
        private bool _permissaoIncluir;
        public bool PermissaoIncluir
        {
            get { return _permissaoIncluir; }
            set { _permissaoIncluir = value; }
        }
        private bool _permissaoExcluir;
        public bool PermissaoExcluir
        {
            get { return _permissaoExcluir; }
            set { _permissaoExcluir = value; }
        }
        private bool _permissaoConsultar;
        public bool PermissaoConsultar
        {
            get { return _permissaoConsultar; }
            set { _permissaoConsultar = value; }
        }
        private bool _permissaoEditar;
        public bool PermissaoEditar
        {
            get { return _permissaoEditar; }
            set { _permissaoEditar = value; }
        } 
        #endregion Accessors

        #region Methods
        public bool Login(int idUsuario, string senha)
        {
            bool retorno;
            WS.Autenticador ws = new InterfaceUsuario.WS.Autenticador();
            retorno = ws.Login(idUsuario, senha);            

            return retorno;
        }        
        public Autenticador VerificaPermissoes(int idUsuario, int idTela)
        {
            Autenticador retorno;
            WS.Autenticador ws = new InterfaceUsuario.WS.Autenticador();
            retorno = ws.VerificaPermissoes(idUsuario, idTela);

            return retorno;
        }
        #endregion Methods



        internal bool Login(string p, string p_2)
        {
            throw new NotImplementedException();
        }
    }
}
