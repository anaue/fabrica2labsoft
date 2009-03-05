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
            string _url = dir.ObtemEnderecoServico("CriarAtributo");
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
            string _url = dir.ObtemEnderecoServico("DeletarAtributo");
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
            string _url = dir.ObtemEnderecoServico("ConsultaAtributo");
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

                        atrib = new Classes.Atributo(response.ListaAtributos[0].Id,response.ListaAtributos[0].Nome,response.ListaAtributos[0].Descricao,response.ListaAtributos[0].Tipo,response.ListaAtributos[0].Nulo);
                        retorno.Add(atrib);
                        
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
            string _url = dir.ObtemEnderecoServico("AlterarAtributo");
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
        public List<Classes.Atributo> BuscaAtributos(string nome, string descricao, string tipo, bool nulo,List<string> listaValores)
        {
            List<Classes.Atributo> retorno = null;
            ServicoAtributo.ServicoAtributo wsAtributo = new InterfaceUsuario.ServicoAtributo.ServicoAtributo();
            ServicoAtributo.RequestAtributo request = new InterfaceUsuario.ServicoAtributo.RequestAtributo();
            ServicoAtributo.ResponseAtributo response = new InterfaceUsuario.ServicoAtributo.ResponseAtributo();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("BuscaAtributos");
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
                request.Atributo.ListaValores = listaValores;
                try
                {
                    response = wsAtributo.BuscaAtributos(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK)
                    {
                        for (int i = 0; i < response.ListaAtributos.Length; i++)
                        {
                            Classes.Atributo atrib = new Classes.Atributo(response.ListaAtributos[i].Id, response.ListaAtributos[i].Nome, response.ListaAtributos[i].Descricao, response.ListaAtributos[i].Tipo, response.ListaAtributos[i].Nulo,response.ListaAtributos[i].ListaValores);
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
