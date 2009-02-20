using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using Usuarios.Usuario;

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
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;

                    //DAOUsuario uDAO = new DAOUsuario();
                    ServicoUsuario sU = new ServicoUsuario();
                    //Usuario.Usuario u = sU.ConsultarUsuario(_request.IdUsuario);
                    
                    //_response.RegistroCorreto = false;
                    //if (u != null)
                    //{
                    //    if(u.Senha.Equals(_request.Senha))
                    //    {
                    //        _response.RegistroCorreto = true;
                    //    }
                    //}                                       
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
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
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;

                    //DAOAutenticador aDAO = new DAOAutenticador();
                    //_response.Autenticador = aDAO.VerificaPermissoes(_request.IdUsuario, _request.IdTela);                    

                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
                _response.Message = string.Format("Erro na criação do registro: {0}", ex.Message);
            }
            return _response;
        }
    }
}
