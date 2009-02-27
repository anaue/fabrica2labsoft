using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InterfaceUsuario.WS
{
    public class Usuario
    {

        public int CriarUsuario(Classes.Usuario _usuario)
        {
            int retorno = -1;
            ServicoUsuario.ServicoUsuario wsUsuario = new InterfaceUsuario.ServicoUsuario.ServicoUsuario();
            ServicoUsuario.RequestUsuario request = new InterfaceUsuario.ServicoUsuario.RequestUsuario();
            ServicoUsuario.ResponseUsuario response = new InterfaceUsuario.ServicoUsuario.ResponseUsuario();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("CriarAtributo");
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                wsUsuario.Url = _url;

                request.Usuario = new InterfaceUsuario.ServicoUsuario.Usuario();
                request.Usuario.Nome = _usuario.Nome;
                request.Usuario.Descricao = _usuario.Descricao;
                request.Usuario.Senha = _usuario.Senha;

                try
                {
                    response = wsUsuario.CriarUsuario(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoUsuario.ResponseStatus.OK && response.BoolUsuario)
                        retorno = response.Id;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }
            }

            return retorno;
        }


        public bool DeletaUsuario(int Id)
        {
            bool retorno = false;
            ServicoUsuario.ServicoUsuario wsUsuario = new InterfaceUsuario.ServicoUsuario.ServicoUsuario();
            ServicoUsuario.RequestUsuario request = new InterfaceUsuario.ServicoUsuario.RequestUsuario();
            ServicoUsuario.ResponseUsuario response = new InterfaceUsuario.ServicoUsuario.ResponseUsuario();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("DeletarUsuario");
            dir = null;
            #endregion

            //Properties.Settings.Default.InterfaceUsuario_ServicoAtributo_ServicoAtributo;

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsUsuario.Url = _url;

                request.Usuario = new InterfaceUsuario.ServicoUsuario.Usuario();
                request.Usuario.Id = Id;
                try
                {
                    response = wsUsuario.DeletarUsuario(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoUsuario.ResponseStatus.OK)
                        retorno = true;

                }
                catch (Exception ex)
                {
                   retorno = false;
                }

            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Devolve usuario ou null</returns>
        public Classes.Usuario ConsultaUsuario(int Id)
        {
            Classes.Usuario retorno = null;
            ServicoUsuario.ServicoUsuario wsUsuario = new InterfaceUsuario.ServicoUsuario.ServicoUsuario();
            ServicoUsuario.RequestUsuario request = new InterfaceUsuario.ServicoUsuario.RequestUsuario();
            ServicoUsuario.ResponseUsuario response = new InterfaceUsuario.ServicoUsuario.ResponseUsuario();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("ConsultaUsuario");
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsUsuario.Url = _url;

                request.Usuario = new InterfaceUsuario.ServicoUsuario.Usuario();
                request.Usuario.Id = Id;
                try
                {
                    response = wsUsuario.ConsultarUsuario(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoUsuario.ResponseStatus.OK)
                    {
                        retorno = new Classes.Usuario();
                        retorno.Descricao = response.Usuario.Descricao;
                        retorno.Id = response.Usuario.Id;
                        retorno.Nome = response.Usuario.Nome;
                        retorno.Senha = response.Usuario.Senha;
                    }

                }
                catch (Exception ex)
                {
                   //
                }

            }

            return retorno;
        }

        public bool AlteraUsuario(Classes.Usuario usuario)
        {
            bool retorno = false;
            ServicoUsuario.ServicoUsuario wsUsuario = new InterfaceUsuario.ServicoUsuario.ServicoUsuario();
            ServicoUsuario.RequestUsuario request = new InterfaceUsuario.ServicoUsuario.RequestUsuario();
            ServicoUsuario.ResponseUsuario response = new InterfaceUsuario.ServicoUsuario.ResponseUsuario();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("AlterarUsuario");
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsUsuario.Url = _url;

                request.Usuario = new InterfaceUsuario.ServicoUsuario.Usuario();
                request.Usuario.Id = usuario.Id;
                request.Usuario.Nome = usuario.Nome;
                request.Usuario.Descricao = usuario.Descricao;
                request.Usuario.Senha = usuario.Senha;

                try
                {
                    response = wsUsuario.AlterarUsuario(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoUsuario.ResponseStatus.OK)
                        retorno = response.BoolUsuario;     

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

            return retorno;
        }


        public List<Classes.Usuario> BuscaUsuarios(String nome, String descricao)
        {
            List<Classes.Usuario> retorno = new List<Classes.Usuario>();
            ServicoUsuario.ServicoUsuario wsUsuario = new InterfaceUsuario.ServicoUsuario.ServicoUsuario();
            ServicoUsuario.RequestUsuario request = new InterfaceUsuario.ServicoUsuario.RequestUsuario();
            ServicoUsuario.ResponseUsuario response = new InterfaceUsuario.ServicoUsuario.ResponseUsuario();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("ConsultaUsuario");
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsUsuario.Url = _url;

                request.Usuario = new InterfaceUsuario.ServicoUsuario.Usuario();
                request.Usuario.Nome = nome;
                request.Usuario.Descricao = descricao;
                try
                {
                    response = wsUsuario.BuscaUsuarios(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoUsuario.ResponseStatus.OK & response.ListaUsuario.Length != 0)
                    {
                        foreach (InterfaceUsuario.ServicoUsuario.Usuario u in response.ListaUsuario)
                        {
                            Classes.Usuario usuario = new Classes.Usuario();
                            usuario.Descricao = u.Descricao;
                            usuario.Id = u.Id;
                            usuario.Nome = u.Nome;
                            usuario.Senha = u.Senha;

                            retorno.Add(usuario);
                        }
                    }    
                    else
                        retorno = null;

                }
                catch (Exception ex)
                {
                    retorno = null;
                }

            }

            return retorno;
        }

    }
}
