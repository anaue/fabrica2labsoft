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
        public List<Classes.Atributo> ConsultaAtributo(int Id)
        {
            List<Classes.Atributo> retorno = null;
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
                Classes.Atributo atrib = null;
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
                            atrib = new Classes.Atributo(response.ListaAtributos[0].Id, response.ListaAtributos[0].Nome, response.ListaAtributos[0].Descricao, response.ListaAtributos[0].Tipo, response.ListaAtributos[0].Nulo, lValores,response.ListaAtributos[0].Valor);
                            retorno.Add(atrib);
                        
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
    }
}
