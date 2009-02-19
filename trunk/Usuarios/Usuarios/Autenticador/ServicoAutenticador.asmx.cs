using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Usuarios.Autenticador
{
    /// <summary>
    /// Summary description for ServicoAutenticador
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]
    public class ServicoAutenticador : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "Login")]
        public ResponseAutenticador Login(RequestAutenticador _request)
        {
            ResponseAutenticador _response = new ResponseAutenticador();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;
                    ////implementacao da função vai aqui


                    /////
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na criação do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "Logout")]
        public ResponseAutenticador Logout(RequestAutenticador _request)
        {
            ResponseAutenticador _response = new ResponseAutenticador();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;
                    ////implementacao da função vai aqui


                    /////
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na criação do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "VerificaPermissoes")]
        public ResponseAutenticador VerificarPermissoes(RequestAutenticador _request)
        {
            ResponseAutenticador _response = new ResponseAutenticador();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;
                    ////implementacao da função vai aqui


                    /////
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na criação do registro: {0}", ex.Message);
            }
            return _response;
        }
    }
}
