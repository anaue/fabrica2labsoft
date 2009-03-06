using System;
using System.Data;
using System.Collections.Generic;

namespace InterfaceUsuario.WS
{
    public class Atributo
    {
        
        //TODO:  tratar as exceptions

        public int CriaAtributo(Classes.Atributo atributo) {
            int retorno = -1;
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestAtributo request = new InterfaceUsuario.ServicoAtributo.RequestAtributo();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.ATRIBUTO_CRIAR);
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                wsAtributo.Url = _url;

                request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
                request.Atributo.Nome = atributo.Nome;
                request.Atributo.Descricao = atributo.Descricao;
                request.Atributo.Tipo = atributo.Tipo;
                request.Atributo.Nulo = atributo.Nulo;
                request.Atributo.Valor = atributo.Valor;

                string[] valores = new string[atributo.ListaValores.Count];
                int i = 0;
                foreach (string strValor in atributo.ListaValores)
                {
                    valores.SetValue(strValor, i);
                    i++;
                }

                request.Atributo.ListaValores = valores;

               
                try
                {
                    response = wsAtributo.CriarAtributo(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK && response.ListaAtributos != null)
                        retorno = response.ListaAtributos[0].Id;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                    throw ex;
                }
            }

            return retorno;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeletaAtributo(int Id)
        {
            bool retorno = false;
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestAtributo request = new InterfaceUsuario.ServicoAtributo.RequestAtributo();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();
            
            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.ATRIBUTO_DELETAR);
            dir = null;
            #endregion           

            //Properties.Settings.Default.InterfaceUsuario_ServicoAtributo_ServicoAtributo;
           
            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsAtributo.Url = _url; 

                request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
                request.Atributo.Id = Id;
                try
                {
                    response = wsAtributo.DeletarAtributo(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK)
                      
                        retorno = true;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                    throw ex;
                }

            }
            return retorno;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Classes.Atributo ConsultaAtributo(int Id)
        {
            Classes.Atributo retorno = null;
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestAtributo request = new InterfaceUsuario.ServicoAtributo.RequestAtributo();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.ATRIBUTO_CONSULTAR);
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsAtributo.Url = _url;

                request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
                request.Atributo.Id = Id;
                try
                {
                    response = wsAtributo.ConsultarAtributo(request);

                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK)
                    {
                            List<string> lValores = new List<string>();
                            foreach (string valor in response.ListaAtributos[0].ListaValores)
                            {
                                lValores.Add(valor);
                            }
                            WS.Atributo att = new Atributo();
                            retorno = new Classes.Atributo(response.ListaAtributos[0].Id, response.ListaAtributos[0].Nome, response.ListaAtributos[0].Descricao, response.ListaAtributos[0].Tipo, response.ListaAtributos[0].Nulo, lValores,response.ListaAtributos[0].Valor);
                    }
                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                    throw ex;
                }

            }

            return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool AlteraAtributo(Classes.Atributo atributo)
        {
            bool retorno = false;
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestAtributo request = new InterfaceUsuario.ServicoAtributo.RequestAtributo();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.ATRIBUTO_ALTERAR);
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsAtributo.Url = _url;

                request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
                request.Atributo.Id = atributo.Id;
                request.Atributo.Nome = atributo.Nome;
                request.Atributo.Descricao = atributo.Descricao;
                request.Atributo.Nulo = atributo.Nulo;
                request.Atributo.Tipo = atributo.Tipo;
                string[] valores = new string[atributo.ListaValores.Count];
                int i = 0;
                foreach (string strValor in atributo.ListaValores)
                {
                    valores.SetValue(strValor, i);
                    i++;
                }
                request.Atributo.ListaValores = valores;
                request.Atributo.Valor = atributo.Valor;
               
          

                
                try
                {
                    response = wsAtributo.AlterarAtributo(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK)
                       
                        retorno = true; 

                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }

            }

            return retorno;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Classes.Atributo> BuscaAtributos(string nome, string descricao, string tipo, bool nulo, List<string> listaValores, string valor)
        {
            List<Classes.Atributo> retorno = null;
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestAtributo request = new InterfaceUsuario.ServicoAtributo.RequestAtributo();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.ATRIBUTO_BUSCAR);
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsAtributo.Url = _url;

                request.Atributo = new InterfaceUsuario.ServicoAtributo.Atributo();
                request.Atributo.Nome = nome;
                request.Atributo.Descricao = descricao;
                request.Atributo.Tipo = tipo;
                request.Atributo.Nulo = nulo;
                string[] valores = new string[listaValores.Count];
                int i = 0;
                foreach (string strValor in listaValores)
                {
                    valores.SetValue(strValor, i);
                    i++;
                }
                request.Atributo.ListaValores = valores;
                request.Atributo.Valor = valor;
                
                try
                {
                    response = wsAtributo.BuscarAtributos(request);
                    
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK)
                    {
                        for (int j = 0; j < response.ListaAtributos.Length; j++)
                        {
                            List<string> lValores = new List<string>();
                            foreach (string stValor in response.ListaAtributos[j].ListaValores)
                            {
                                lValores.Add(stValor);  
                            }
                            Classes.Atributo atrib = new Classes.Atributo(response.ListaAtributos[j].Id, response.ListaAtributos[j].Nome, response.ListaAtributos[j].Descricao, response.ListaAtributos[j].Tipo, response.ListaAtributos[j].Nulo,lValores,response.ListaAtributos[j].Valor);
                            retorno.Add(atrib);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                    throw ex;
                }

            }

            return retorno;
        }

        public List<Classes.Atributo> ListaAtributosTipoPatrimonio(int IdPatrimonio)
        {
            List<Classes.Atributo> retorno = new List<Classes.Atributo>();
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestTipoPatrimonio request = new InterfaceUsuario.ServicoAtributo.RequestTipoPatrimonio();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.ATRIBUTOS_LISTAR_TIPO_PATRIMONIO);
            dir = null;

            if (_url != string.Empty)
            {
                wsAtributo.Url = _url;

                try
                {
                    ServicoAtributo.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.ServicoAtributo.TipoPatrimonio();
                    request.TipoPatrimonio = tipoPatrimonio;

                    response = wsAtributo.ListarAtributosTipoPatrimonio(request);
                    
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK && response.ListaAtributos != null)
                        foreach (ServicoAtributo.Atributo _atr in response.ListaAtributos)
                        {
                            Classes.Atributo atr = new InterfaceUsuario.Classes.Atributo();
                            atr.Descricao = _atr.Descricao;
                            atr.Id = _atr.Id;
                            
                            _atr.ListaValores = new string [atr.ListaValores.Count];
                            for (int i = 0; i< atr.ListaValores.Count ; i++)
                            {
                                atr.ListaValores[i] = _atr.ListaValores[i];
                            }
                            atr.Nome = _atr.Nome;
                            atr.Nulo = _atr.Nulo;
                            atr.Tipo = _atr.Tipo;
                            atr.Valor = _atr.Valor;

                            retorno.Add(atr);
                        }

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }
            }
            return retorno;
        }

        public List<Classes.Atributo> ListaAtributosDisponiveis()
        {
            List<Classes.Atributo> retorno = new List<Classes.Atributo>();
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestAtributo request = new InterfaceUsuario.ServicoAtributo.RequestAtributo();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.TIPO_PATRIMONIO_LISTAR_ATRIBUTOS_DISPONIVEIS);
            dir = null;

            if (_url != string.Empty)
            {
                wsAtributo.Url = _url;

                try
                {                  
                    response = wsAtributo.ListarAtributosDisponiveis(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK && response.ListaAtributos != null)
                        foreach (ServicoAtributo.Atributo atr in response.ListaAtributos)
                        {
                            Classes.Atributo _atr = new InterfaceUsuario.Classes.Atributo();
                            _atr.Descricao = atr.Descricao;
                            _atr.Id = atr.Id;
                            _atr.Nome = atr.Nome;
                            retorno.Add(_atr);
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
