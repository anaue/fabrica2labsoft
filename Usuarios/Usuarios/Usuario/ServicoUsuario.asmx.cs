using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Usuarios.Usuario
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]
    public class ServicoUsuario : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "CriaUsuario")]
        public ResponseUsuario CriarUsuario(RequestUsuario _request)
        {
            ResponseUsuario _response = new ResponseUsuario();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;

                    DAOUsuario daoUsuario = new DAOUsuario();
                    _response.boolUsuario = daoUsuario.CriarUsuario(_request.Usuario);  
                    //devolve uma variavel dizendo se foi cadastrado corretamente ou naum         
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na criação do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "DeletaUsuario")]
        public ResponseUsuario DeletarUsuario(RequestUsuario _request)
        {
              ResponseUsuario _response = new ResponseUsuario();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;

                    DAOUsuario daoUsuario = new DAOUsuario();
                    _response.BoolUsuario = daoUsuario.DeletarUsuario(_request.idUsuario);    

                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na exclusão do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "AlteraUsuario")]
        public ResponseUsuario AlterarUsuario(RequestUsuario _request)
        {
            ResponseUsuario _response = new ResponseUsuario();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;

                    DAOUsuario daoUsuario = new DAOUsuario();

                    _response.BoolUsuario = daoUsuario.AlterarUsuario(_request.Usuario); 
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na alteração do registro: {0}", ex.Message);
            }
            return _response;
        }
        [WebMethod(MessageName = "ConsultaUsuario")]
        public ResponseUsuario ConsultarUsuario(RequestUsuario _request)
        {
            ResponseUsuario _response = new ResponseUsuario();
            try
            {
                if (_request != null)
                {

                    _response.StatusCode = 200;

                    DAOUsuario daoUsuario = new DAOUsuario();

                    _response.Usuario = daoUsuario.ConsultarUsuario(_request.idUsuario);
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na consulta do registro: {0}", ex.Message);
            }
            return _response;
        }

        [WebMethod(MessageName = "BuscaUsuarios")]
        public ResponseUsuario BuscaUsuarios(RequestUsuario _request)
        {
            ResponseUsuario _response = new ResponseUsuario();
            try
            {
                if (_request != null)
                {

                    _response.StatusCode = 200;

                    DAOUsuario daoUsuario = new DAOUsuario();

                    _response.ListaUsuarios = daoUsuario.BuscaUsuarios(_request.Usuario.Nome, _request.Usuario.Descricao);
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
