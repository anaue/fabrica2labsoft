using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

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
        public bool Login(Classes.Usuario _user)
        {
            bool retorno = false;
            ServicoAutenticador.ServicoAutenticador wsAutenticador = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();
            ServicoAutenticador.ServicoAutenticador request = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();
            ServicoAutenticador.ServicoAutenticador response = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();

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

                try
                {
                    response = wsAutenticador.Login(request);
                    if (response != null && response.StatusCode == 200)
                    {
                        // falta implementar a função aqui     
                        //*************************************************
                        //
                        //
                        //
                        //
                        //*************************************************
                        retorno = false; //true;
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
        public bool VerificaPermissoes(Classes.Usuario _user)
        {
            bool retorno = false;
            ServicoAutenticador.ServicoAutenticador wsAutenticador = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();
            ServicoAutenticador.ServicoAutenticador request = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();
            ServicoAutenticador.ServicoAutenticador response = new InterfaceUsuario.ServicoAutenticador.ServicoAutenticador();

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

                try
                {
                    response = wsAutenticador.VerificarPermissoes(request);
                    if (response != null && response.StatusCode == 200)
                    {
                        // falta implementar a função aqui     
                        //*************************************************
                        //
                        //
                        //
                        //
                        //*************************************************
                        retorno = false; //true;
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
