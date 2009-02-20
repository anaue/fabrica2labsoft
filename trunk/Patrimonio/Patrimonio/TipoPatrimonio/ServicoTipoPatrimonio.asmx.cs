using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Patrimonio.TipoPatrimonio
{
    /// <summary>
    /// Summary description for ServicoTipoPatrimonio
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]

    public class ServicoTipoPatrimonio : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "CriaTipoPatrimonio")]
        public ResponseTipoPatrimonio CriarTipoPatrimonio(RequestTipoPatrimonio _request)
        {
            ResponseTipoPatrimonio _response = new ResponseTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;
                    //_response.ListaAtributos = new System.Collections.Generic.List<Atributo>();
                    ////implementacao da função vai aqui


                    /////

                    // _request.Atributo.Id = 1;
                    //_response.ListaAtributos.Add(_request.Atributo);
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
                _response.Message = string.Format("Erro na criação do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "DeletaTipoPatrimonio")]
        public ResponseTipoPatrimonio DeletarTipoPatrimonio(RequestTipoPatrimonio _request)
        {
            ResponseTipoPatrimonio _response = new ResponseTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    ////implementacao da função vai aqui


                    /////
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
                _response.Message = string.Format("Erro na exclusão do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "AlteraTipoPatrimonio")]
        public ResponseTipoPatrimonio AlterarTipoPatrimonio(RequestTipoPatrimonio _request)
        {
            ResponseTipoPatrimonio _response = new ResponseTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    ////implementacao da função vai aqui


                    /////
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
                _response.Message = string.Format("Erro na alteração do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "ConsultaTipoPatrimonio")]
        public ResponseTipoPatrimonio ConsultarTipoPatrimonio(RequestTipoPatrimonio _request)
        {
            ResponseTipoPatrimonio _response = new ResponseTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    ////implementacao da função vai aqui


                    /////
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
                _response.Message = string.Format("Erro na consulta do registro: {0}", ex.Message);
            }
            return _response;
        }
    }
}
