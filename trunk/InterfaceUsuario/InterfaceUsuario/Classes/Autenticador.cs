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
        private int _idUsuario;
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        private int _idTipoAcesso;
        public int IdTipoAcesso
        {
            get { return _idTipoAcesso; }
            set { _idTipoAcesso = value; }
        } 
        #endregion Accessors

        #region Methods
        public Classes.Autenticador Login(string nomeUsuario, string senha)
        {
            Classes.Autenticador retorno;
            WS.Autenticador ws = new InterfaceUsuario.WS.Autenticador();
            retorno = ws.Login(nomeUsuario, senha);            

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

    }
}
