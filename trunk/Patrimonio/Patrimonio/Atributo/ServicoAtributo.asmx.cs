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
                    _response.StatusCode = 200;
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
                _response.StatusCode = 500;
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
                    ////implementacao da função vai aqui


                    /////
                    _response.StatusCode = 200;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
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


                    /////
                    _response.StatusCode = 200;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
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
                    ////implementacao da função vai aqui


                    /////
                    _response.StatusCode = 200;
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na consulta do registro: {0}", ex.Message);
            }
            return _response;
        }
    }
}
