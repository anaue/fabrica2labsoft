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
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsTipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_CRIAR);
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                wsTipoPatrimonio.Url = _url;

                request.TipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.TipoPatrimonio();
                request.TipoPatrimonio.Descricao = tipopatrimonio.Descricao;
                request.TipoPatrimonio.Id = tipopatrimonio.Id;
                request.TipoPatrimonio.Nome = tipopatrimonio.Nome;
               
                try
                {
                    response = wsTipoPatrimonio.CriarTipoPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoTipoPatrimonio.ResponseStatus.OK && response.ListaTipoPatrimonio !=null)
                        retorno = response.ListaTipoPatrimonio[0].Id;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

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
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsTipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();
            
            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_DELETAR);
            dir = null;
            #endregion           

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsTipoPatrimonio.Url = _url;

                request.TipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.TipoPatrimonio();
                request.TipoPatrimonio.Id = Id;

                try
                {
                    response = wsTipoPatrimonio.DeletarTipoPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoTipoPatrimonio.ResponseStatus.OK);  
                        retorno = true;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Classes.TipoPatrimonio ConsultaTipoPatrimonio(int Id)
        {
            Classes.TipoPatrimonio _TipoPatrimonio = new Classes.TipoPatrimonio();
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsTipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_CONSULTAR);
            dir = null;

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsTipoPatrimonio.Url = _url;

                request.TipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.TipoPatrimonio();
                request.TipoPatrimonio.Id = Id;


                try
                {
                    response = wsTipoPatrimonio.ConsultarTipoPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoTipoPatrimonio.ResponseStatus.OK && response.ListaTipoPatrimonio != null)
                    {
                        _TipoPatrimonio.Nome =  response.ListaTipoPatrimonio[0].Nome;
                        _TipoPatrimonio.Id = response.ListaTipoPatrimonio[0].Id;
                        _TipoPatrimonio.Descricao = response.ListaTipoPatrimonio[0].Descricao;
                        _TipoPatrimonio.ListAtributos = new List<InterfaceUsuario.Classes.Atributo>();
                        foreach(Classes.Atributo atr in _TipoPatrimonio.ListAtributos)
                        {
                            _TipoPatrimonio.ListAtributos.Add(atr);

                        }

                    }
                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }
                return _TipoPatrimonio;

            }

            return _TipoPatrimonio;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool AlteraTipoPatrimonio(Classes.TipoPatrimonio tipopatrimonio)
        {
            bool retorno = false;
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsTipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_ALTERAR);
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                wsTipoPatrimonio.Url = _url;

                request.TipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.TipoPatrimonio();
                request.TipoPatrimonio.Descricao = tipopatrimonio.Descricao;
                request.TipoPatrimonio.Id = tipopatrimonio.Id;
                request.TipoPatrimonio.Nome = tipopatrimonio.Nome;

                try
                {
                    response = wsTipoPatrimonio.AlterarTipoPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoTipoPatrimonio.ResponseStatus.OK && response.ListaTipoPatrimonio != null)
                        retorno = true ;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }


            return retorno;
        }

        /// <summary>
        /// Metodo imcompleto
        /// </summary>
        /// <returns></returns>
        public List<Classes.TipoPatrimonio> ListaTipoPatrimonio()
        {
            List<Classes.TipoPatrimonio> retorno = new List<Classes.TipoPatrimonio>();
            ServicoTipoPatrimonio.ServicoTipoPatrimonio wsTipoPatrimonio = new InterfaceUsuario.ServicoTipoPatrimonio.ServicoTipoPatrimonio();
            ServicoTipoPatrimonio.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoTipoPatrimonio.RequestTipoPatrimonio();
            ServicoTipoPatrimonio.ResponseTipoPatrimonio response = new InterfaceUsuario.ServicoTipoPatrimonio.ResponseTipoPatrimonio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_LISTAR);
            dir = null;


            if (_url != string.Empty)
            {
                wsTipoPatrimonio.Url = _url;
                try
                {
                    response = wsTipoPatrimonio.ListarTipoPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoTipoPatrimonio.ResponseStatus.OK && response.ListaTipoPatrimonio != null)
                        
                        foreach (ServicoTipoPatrimonio.TipoPatrimonio ltp in response.ListaTipoPatrimonio)
                        {
                            Classes.TipoPatrimonio tp = new InterfaceUsuario.Classes.TipoPatrimonio();
                            tp.Descricao = ltp.Descricao;
                            tp.Id = ltp.Id;
                            tp.Nome = ltp.Nome;
                            foreach(ServicoTipoPatrimonio.Atributo atr in ltp.ListAtributos)
                            {
                                Classes.Atributo _atr = new InterfaceUsuario.Classes.Atributo();
                                _atr.Descricao = atr.Descricao;
                                _atr.Id = atr.Id;
                                _atr.Nome = atr.Nome;
                                _atr.Nulo = atr.Nulo;
                                _atr.Tipo = atr.Tipo;
                                _atr.Valor = atr.Valor;
                                _atr.ListaValores = new List<string>();
                                foreach (string str in atr.ListaValores)
                                {
                                    _atr.ListaValores.Add(str);
                                }


                                tp.ListAtributos.Add(_atr);

                            }

                            retorno.Add(tp);
                        }

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }
            }


            return retorno;
        }
        
    }
}
