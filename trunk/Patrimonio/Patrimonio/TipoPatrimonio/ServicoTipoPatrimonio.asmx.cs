﻿using System;
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
            DAOTipoPatrimonio daotipopatrimonio = new DAOTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;
                    _response.ListaTipoPatrimonio = new System.Collections.Generic.List<TipoPatrimonio>();
                    ////implementacao da função vai aqui

                    int idGerado = daotipopatrimonio.InsereTipoPatrimonio(_request.TipoPatrimonio);
                    if (idGerado > 0)
                    {
                        _request.TipoPatrimonio.Id = idGerado;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    /////
                    _response.ListaTipoPatrimonio.Add(_request.TipoPatrimonio);
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
            DAOTipoPatrimonio daotipopatrimonio = new DAOTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    ////implementacao da função vai aqui
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;


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
            DAOTipoPatrimonio daotipopatrimonio = new DAOTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    ////implementacao da função vai aqui
                    daotipopatrimonio.alteraTipoPatrimonio(_request.TipoPatrimonio);
                    _response.ListaTipoPatrimonio = new System.Collections.Generic.List<TipoPatrimonio>();
                    _response.ListaTipoPatrimonio.Add(_request.TipoPatrimonio);
                    ///
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
            DAOTipoPatrimonio daotipopatrimonio = new DAOTipoPatrimonio();
            try
            {
                if (_request != null)
                {
                    ////implementacao da função vai aqui
                    TipoPatrimonio tipoPatrimonioConsultado = new TipoPatrimonio();
                    _response.ListaTipoPatrimonio = new System.Collections.Generic.List<TipoPatrimonio>();
                    tipoPatrimonioConsultado = daotipopatrimonio.consultaAtributo(_request.TipoPatrimonio.Id);
                    if (tipoPatrimonioConsultado != null)
                    {
                        _response.ListaTipoPatrimonio.Add(tipoPatrimonioConsultado);
                    }
                    else
                    {
                    }
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
