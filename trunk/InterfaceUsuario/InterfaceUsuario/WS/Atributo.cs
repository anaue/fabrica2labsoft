using System;
using System.Data;

namespace InterfaceUsuario.WS
{
    public class Atributo
    {
        
        //TODO:  tratar as exceptions

        public int CriaAtributo(Classes.Atributo atributo)
        {
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
                }

            }

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
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
                        // falta implementar a função aqui     
                        
                        retorno = false; //true;

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
        public bool ConsultaAtributo(int Id)
        {
            bool retorno = false;
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
                try
                {
                    response = wsAtributo.ConsultarAtributo(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoAtributo.ResponseStatus.OK)
                        // falta implementar a função aqui     

                        retorno = false; //true;

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
                        // falta implementar a função aqui     

                        retorno = false; //true;

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
