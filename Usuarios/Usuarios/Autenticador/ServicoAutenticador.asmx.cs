﻿using System;
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
                    _response.StatusCode = 200;

                    DAOUsuario uDAO = new DAOUsuario();
                    ServicoUsuario sU = new ServicoUsuario();
                    Usuario.Usuario u = sU.ConsultarUsuario(_request.IdUsuario);

                    if (u == null)
                    {
                        _response.EstaRegistrado = false;   
                    }
                    else
                    {
                        _response.EstaRegistrado = true;
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
        
        [WebMethod(MessageName = "VerificaPermissoes")]
        public ResponseAutenticador VerificarPermissoes(RequestAutenticador _request)
        {
            ResponseAutenticador _response = new ResponseAutenticador();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;

                    DAOAutenticador aDAO = new DAOAutenticador();
                    _response.Autenticador = aDAO.VerificaPermissoes(_request.IdUsuario, _request.IdTela);                    

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