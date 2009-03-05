using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InterfaceUsuario.WS
{
    public class TipoPatrimonio
    {

         
        //TODO:  tratar as exceptions

        public int CriaTipoPatrimonio(Classes.TipoPatrimonio tipopatrimonio)
        {
            int retorno = -1;
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsAtributo = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_CRIAR);
            dir = null;

            #endregion Acesso WS Diretorio

            //if (_url != string.Empty)
            //{
            //    wsAtributo.Url = _url;

                //request.Atributo = new InterfaceUsuario.ServicoTipoPatrimonio.TipoPatrimonio()
                //request.Atributo.Nome = atributo.Nome;
                //request.Atributo.Descricao = atributo.Descricao;
                //request.Atributo.Tipo = atributo.Tipo;
                //request.Atributo.Nulo = atributo.Nulo;
               
                //try
                //{
                //    response = wsAtributo.CriarAtributo(request);
                //    if (response != null && response.StatusCode == 200 && response.ListaAtributos !=null)
                //        retorno = response.ListaAtributos[0].Id;

                //}
                //catch (Exception ex)
                //{
                //    //necessario mostrar uma mensagem ao usuario
                //}

            //}

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeletaTipoPatrimonio(int Id)
        {
            bool retorno = false;
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsAtributo = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();
            
            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_DELETAR);
            dir = null;
            #endregion           

            //Properties.Settings.Default.InterfaceUsuario_ServicoAtributo_ServicoAtributo;
           


            //if (_url != string.Empty)
            //{
            //    // atualiza o endereco do WS
            //    wsAtributo.Url = _url; 

            //    request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
            //    request.Atributo.Id = Id;
            //    try
            //    {
            //        response = wsAtributo.DeletarAtributo(request);
            //        if (response != null && response.StatusCode == 200)
            //            // falta implementar a função aqui     
                        
            //            retorno = false; //true;

            //    }
            //    catch (Exception ex)
            //    {
            //        //necessario mostrar uma mensagem ao usuario
            //    }

            //}

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool ConsultaTipoPatrimonio(int Id)
        {
            bool retorno = false;
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsAtributo = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_CONSULTAR);
            dir = null;


            //if (_url != string.Empty)
            //{
            //    // atualiza o endereco do WS
            //    wsAtributo.Url = _url;

            //    request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
            //    request.Atributo.Id = Id;
            //    try
            //    {
            //        response = wsAtributo.ConsultarAtributo(request);
            //        if (response != null && response.StatusCode == 200)
            //            // falta implementar a função aqui     

            //            retorno = false; //true;

            //    }
            //    catch (Exception ex)
            //    {
            //        //necessario mostrar uma mensagem ao usuario
            //    }

            //}

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool AlteraTipoPatrimonio(Classes.TipoPatrimonio tipopatrimonio)
        {
            bool retorno = false;
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsAtributo = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_ALTERAR);
            dir = null;


            //if (_url != string.Empty)
            //{
            //    // atualiza o endereco do WS
            //    wsAtributo.Url = _url;

            //    request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
            //    request.Atributo.Id = atributo.Id;
            //    request.Atributo.Nome = atributo.Nome;
            //    request.Atributo.Descricao = atributo.Descricao;
            //    request.Atributo.Nulo = atributo.Nulo;
            //    request.Atributo.Tipo = atributo.Tipo;

                
            //    try
            //    {
            //        response = wsAtributo.AlterarAtributo(request);
            //        if (response != null && response.StatusCode == 200)
            //            // falta implementar a função aqui     

            //            retorno = false; //true;

            //    }
            //    catch (Exception ex)
            //    {
            //        //necessario mostrar uma mensagem ao usuario
            //    }

            //}

            return retorno;
        }

        /// <summary>
        /// Metodo imcompleto
        /// </summary>
        /// <returns></returns>
        public List<Classes.TipoPatrimonio> ListaTipoPatrimonio()
        {
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsAtributo = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_LISTAR);
            dir = null;

            return new List<InterfaceUsuario.Classes.TipoPatrimonio>();
        }
        //esse cara esta no lugar certo???? nao deveria ser da Atributos mesmo??
        public List<Classes.Atributo> ListaAtributos(int IdPatrimonio)
        {
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsAtributo = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.ATRIBUTO_CONSULTAR);
            dir = null;

            return new List<InterfaceUsuario.Classes.Atributo>();
        }
    }
}
