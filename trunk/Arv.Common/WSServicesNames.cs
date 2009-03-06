using System;
using System.Collections.Generic;
using System.Text;

namespace Arv.Common
{
    public static class WSServicesNames
    {
        #region Usuario
        public static string USUARIO_CRIAR = "CriarUsuario";
        public static string USUARIO_DELETAR = "DeletarUsuario";
        public static string USUARIO_CONSULTAR = "ConsultarUsuario";
        public static string USUARIO_ALTERAR = "AlterarUsuario";
        public static string USUARIO_BUSCAR = "BuscarUsuario";
        #endregion Usuario

        #region TipoPatrimonio
        public static string TIPO_PATRIMONIO_CRIAR = "CriarTipoPatrimonio";
        public static string TIPO_PATRIMONIO_DELETAR = "DeletarTipoPatrimonio";
        public static string TIPO_PATRIMONIO_CONSULTAR = "ConsultarTipoPatrimonio";
        public static string TIPO_PATRIMONIO_ALTERAR = "AlterarTipoPatrimonio";
        public static string TIPO_PATRIMONIO_LISTAR = "BuscarTipoPatrimonio";
        public static string TIPO_PATRIMONIO_LISTAR_ATRIBUTOS = "ListarAtributos";
        public static string TIPO_PATRIMONIO_LISTAR_ATRIBUTOS_DISPONIVEIS = "ListarAtributosDisponiveis";
        #endregion TipoPatrimonio

        #region Patrimonio
        public static string PATRIMONIO_CRIAR = "CriarPatrimonio";
        public static string PATRIMONIO_DELETAR = "DeletarPatrimonio";
        public static string PATRIMONIO_CONSULTAR = "ConsultarPatrimonio";
        public static string PATRIMONIO_ALTERAR = "AlterarPatrimonio";
        public static string PATRIMONIO_LISTAR = "BuscarPatrimonio";
        public static string PATRIMONIO_REGISTRAR_MANUTENCAO = "RegistrarManutencao";
        #endregion Patrimonio

        #region Autenticador
        public static string AUTENTICADOR_LOGIN = "Login";
        public static string AUTENTICADOR_VERIFICA_PERMISSOES = "VerificaPermissoes";
        #endregion Autenticador

        #region Atributo
        public static string ATRIBUTO_CRIAR = "CriarAtributo";
        public static string ATRIBUTO_DELETAR = "DeletarAtributo";
        public static string ATRIBUTO_CONSULTAR = "ConsultarAtributo";
        public static string ATRIBUTO_ALTERAR = "AlterarAtributo";
        public static string ATRIBUTO_BUSCAR = "BuscarAtributo";
        #endregion Atributo

    }
}
