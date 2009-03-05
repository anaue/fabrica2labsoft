using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using Arv.Common;
using System.Collections.Generic;

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
                    DAOPatrimonio daoPatrimonio = new DAOPatrimonio();
                    int idGerado = daoPatrimonio.InserePatrimonio(_request.Patrimonio);
                    
                    if (idGerado > 0)
                    {
                        _request.Patrimonio.IdEquipamento = idGerado;
                        _response.ListaPatrimonio.Add(_request.Patrimonio);
                    }
                    else
                    {
                        throw new Exception("Erro ao tentar inserir Patrimonio: idGerado <= 0");
                    }
                    _response.StatusCode = BaseResponse.ResponseStatus.OK;
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
                    DAOPatrimonio daoPatrimonio = new DAOPatrimonio();
                    int idGerado = daoPatrimonio.ExecutaBaixaPatrimonio(_request.Patrimonio, _request.Baixa);

                    if (idGerado > 0)
                    {
                        _request.Baixa.IdBaixa = idGerado;
                        _response.Message = "Baixa de patrimonio executada com sucesso.";
                    }
                    else
                    {
                        throw new Exception("Erro ao tentar executar baixa de Patrimonio: idGerado <= 0");
                    }
                    _response.StatusCode = BaseResponse.ResponseStatus.OK;
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
                    DAOPatrimonio daoPatrimonio = new DAOPatrimonio();
                    int idGerado = daoPatrimonio.DeletaPatrimonio(_request.Patrimonio);

                    if (idGerado > 0)
                    {
                        _request.Baixa.IdBaixa = idGerado;
                        _response.Message = "Remocao de Patrimonio executada com sucesso.";
                    }
                    else
                    {
                        throw new Exception("Erro ao tentar remover Patrimonio: idGerado <= 0");
                    }
                    _response.StatusCode = BaseResponse.ResponseStatus.OK;
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
                    DAOPatrimonio daoPatrimonio = new DAOPatrimonio();
                    bool sucesso = daoPatrimonio.AlteraPatrimonio(_request.Patrimonio);

                    if (sucesso)
                    {
                    //    _request.Baixa.IdBaixa = idGerado;
                        _response.Message = "Remocao de Patrimonio executada com sucesso.";
                    }
                    else
                    {
                        throw new Exception("Erro ao tentar remover Patrimonio: idGerado <= 0");
                    }
                    _response.StatusCode = BaseResponse.ResponseStatus.OK;
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
                    _response.ListaPatrimonio = new System.Collections.Generic.List<Patrimonio>();

                    DAOPatrimonio daoPatrimonio = new DAOPatrimonio();

                    List<Patrimonio> listPatrimonio = daoPatrimonio.ObterPatrimonios(_request.Patrimonio);

                    if (listPatrimonio.Count > 0)
                    {
                        _response.ListaPatrimonio = listPatrimonio;
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
                _response.Message = string.Format("Erro na consulta do registro: {0}", ex.Message);
            }
            return _response;
        }

        public ResponsePatrimonio ObterPatrimonio(RequestPatrimonio _request)
        {
            ResponsePatrimonio _response = new ResponsePatrimonio();
            throw new NotImplementedException();
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
