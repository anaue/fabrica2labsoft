using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web; 
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Maestro
{
    /// <summary>
    /// Summary description for Servicos
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]
    public class Servicos : System.Web.Services.WebService
    {
        [WebMethod]
        public Response ObtemEnderecoServico(Request _request)
        {
            Response _response = new Response();
            try
            {
                DAOServico _servico = new DAOServico();
                if (_request != null)
                {//se tudo ocorrer bem executa o serviço
                    _response.ServiceAddress = _servico.ConsultarEndereco(_request.NomeServico);
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK; //200 significa recebido com sucesso
                }
                else
                {
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.NoContent; //204, no content
                    _response.Message = "Erro no recebimento do request";
                }

            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;//internal server error
                _response.Message = string.Format("Erro no serviço: {0}", ex.Message);
    
            }
            return _response;


        }
        [WebMethod]
        public Response ObtemServicos(Request _request)
        {
            Response _response = new Response();
            try
            {
                DAOServico _servico = new DAOServico();
                if (_request != null)
                {//se tudo ocorrer bem executa o serviço
                    _response.ServiceAddress = _servico.ConsultarServicos();
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK; //200 significa recebido com sucesso
                }
                else
                {
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.NoContent; //204, no content
                    _response.Message = "Erro no recebimento do request";
                }

            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;//internal server error
                _response.Message = string.Format("Erro no serviço: {0}", ex.Message);
            }
            return _response;


        }

    }

}
