using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Patrimonio.Patrimonio
{
    /// <summary>
    /// Summary description for ServicoPatrimonio
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]
    public class ServicoPatrimonio : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "CriaPatrimonio")]
        public ResponsePatrimonio CriarPatrimonio(RequestPatrimonio _request)
        {
            ResponsePatrimonio _response = new ResponsePatrimonio();
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
        [WebMethod(MessageName = "BaixaPatrimonio")]
        public ResponsePatrimonio BaixarPatrimonio(RequestPatrimonio _request)
        {
            ResponsePatrimonio _response = new ResponsePatrimonio();
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
        [WebMethod(MessageName = "DeletaPatrimonio")]
        public ResponsePatrimonio DeletarPatrimonio(RequestPatrimonio _request)
        {
            ResponsePatrimonio _response = new ResponsePatrimonio();
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
        [WebMethod(MessageName = "AlteraPatrimonio")]
        public ResponsePatrimonio AlterarPatrimonio(RequestPatrimonio _request)
        {
            ResponsePatrimonio _response = new ResponsePatrimonio();
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
        [WebMethod(MessageName = "ConsultaPatrimonio")]
        public ResponsePatrimonio ConsultarPatrimonio(RequestPatrimonio _request)
        {
            ResponsePatrimonio _response = new ResponsePatrimonio();
            DAOPatrimonio daopatrimonio = new DAOPatrimonio();
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
        [WebMethod(MessageName = "RegistraManutencao")]
        public ResponsePatrimonio RegistrarManutencao(RequestPatrimonio _request)
        {
            ResponsePatrimonio _response = new ResponsePatrimonio();
            DAOPatrimonio daopatrimonio = new DAOPatrimonio();
            try
            {
                if (_request != null)
                {
                    int idGerado = daopatrimonio.InsereManutencao(_request.Manutencao);
                    if (idGerado > 0)
                    {
                        _request.Manutencao.IdManutencao = idGerado;
                    }
                    else
                    {
                        throw new Exception();
                    }

                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
                _response.Message = string.Format("Erro no procedimento de manutenção: {0}", ex.Message);
            }
            return _response;
        }
        
         

    }
}
