using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Patrimonio.Atributo
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]

    public class ServicoAtributo : System.Web.Services.WebService
    {
        
        [WebMethod(MessageName = "CriaAtributo")]
        public ResponseAtributo CriarAtributo(RequestAtributo _request)
        {
            ResponseAtributo _response = new ResponseAtributo();
            DAOAtributo daoatributo = new DAOAtributo();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.OK;
                    _response.ListaAtributos = new System.Collections.Generic.List<Atributo>();
                    
                    int idGerado = daoatributo.InsereAtributo(_request.Atributo);
                    if (idGerado > 0)
                    {
                        _request.Atributo.Id = idGerado;
                        _response.ListaAtributos.Add(_request.Atributo);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = Arv.Common.BaseResponse.ResponseStatus.InternalServerError;
                _response.Message = string.Format("Erro na criação do registro: {0}", ex.Message);
            }
            return _response;
        }

        [WebMethod(MessageName = "DeletaAtributo")]
        public ResponseAtributo DeletarAtributo(RequestAtributo _request)
        {
            ResponseAtributo _response = new ResponseAtributo();
            DAOAtributo daoatributo = new DAOAtributo();
            try
            {
                if (_request != null)
                {
                  
                     daoatributo.deletaAtributo(_request.Atributo.Id);
                   
               
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
        [WebMethod(MessageName = "AlteraAtributo")]
        public ResponseAtributo AlterarAtributo(RequestAtributo _request)
        {
            ResponseAtributo _response = new ResponseAtributo();
            DAOAtributo daoatributo = new DAOAtributo();
            try
            {
                if (_request != null)
                {
                    ////implementacao da função vai aqui

                    _response.ListaAtributos.Add(daoatributo.alteraAtributo(_request.Atributo));

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
        [WebMethod(MessageName = "ConsultaAtributo")]
        public ResponseAtributo ConsultarAtributo(RequestAtributo _request)
        {
            ResponseAtributo _response = new ResponseAtributo();
            DAOAtributo daoatributo = new DAOAtributo();
            try
            {
                if (_request != null)
                {
                    
                    _response.ListaAtributos.Add(daoatributo.consultaAtributo(_request.IdAtributo));
                  
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
        [WebMethod(MessageName = "BuscaAtributos")]
        public ResponseAtributo BuscarAtributos(RequestAtributo _request)
        {
            ResponseAtributo _response = new ResponseAtributo();
            DAOAtributo daoatributo = new DAOAtributo();
            try
            {
                if (_request != null)
                {
                    _response.ListaAtributos = daoatributo.buscaAtributos(_request.Atributo.Nome,_request.Atributo.Descricao,_request.Atributo.Tipo,_request.Atributo.Nulo,_request.Atributo.ListaValores,_request.Atributo.Valor);
                    
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
