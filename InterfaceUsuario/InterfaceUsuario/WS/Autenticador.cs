﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Arv.Common;

namespace InterfaceUsuario.WS
{
    public class Autenticador
    {

        //TODO:  tratar as exceptions


        /// <summary>
        /// Metodo Incompleto
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool Login(int idUsuario, string senha)
        {
            bool retorno = false;
            ServicoAutenticador.ServicoAutenticador wsAutenticador = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();
            ServicoAutenticador.RequestAutenticador request = new InterfaceUsuario.ServicoAutenticador.RequestAutenticador();
            ServicoAutenticador.ResponseAutenticador response = new InterfaceUsuario.ServicoAutenticador.ResponseAutenticador();
            
            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("Login");
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsAutenticador.Url = _url;

                request.IdUsuario = idUsuario;
                request.Senha = senha;

                try
                {
                    response = wsAutenticador.Login(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAutenticador.ResponseStatus.OK)
                    {
                        retorno = response.RegistroCorreto;
                    }

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

            return retorno;
        }
        
        /// <summary>
        /// Metodo Incompleto
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public Classes.Autenticador VerificaPermissoes(int idUsuario, int idTela)
        {
            Classes.Autenticador retorno = new Classes.Autenticador();
            ServicoAutenticador.ServicoAutenticador wsAutenticador = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();
            ServicoAutenticador.RequestAutenticador request = new InterfaceUsuario.ServicoAutenticador.RequestAutenticador();
            ServicoAutenticador.ResponseAutenticador response = new InterfaceUsuario.ServicoAutenticador.ResponseAutenticador();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("Login");
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsAutenticador.Url = _url;

                request.IdUsuario = idUsuario;
                request.IdTela = idTela;

                try
                {
                    response = wsAutenticador.VerificarPermissoes(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAutenticador.ResponseStatus.OK)
                    {
                        retorno.PermissaoIncluir = response.Autenticador.PermissaoIncluir;
                        retorno.PermissaoExcluir = response.Autenticador.PermissaoExcluir;
                        retorno.PermissaoConsultar = response.Autenticador.PermissaoConsultar;
                        retorno.PermissaoEditar = response.Autenticador.PermissaoEditar;
                    }

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

            return retorno;
        }
    }
}
