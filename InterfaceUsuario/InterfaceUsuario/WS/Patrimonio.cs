using System;
using System.Data;
using System.Collections.Generic;

namespace InterfaceUsuario.WS
{
    public class Patrimonio
    {
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <returns></returns>
        public List<Patrimonio> ConsultarPatrimonio()
        {
            List<Patrimonio> _listaPatrimonio = new List<Patrimonio>();
            ServicoPatrimonio.ServicoPatrimonio wsPatrimonio = new InterfaceUsuario.ServicoPatrimonio.ServicoPatrimonio();
            ServicoPatrimonio.RequestPatrimonio request = new InterfaceUsuario.ServicoPatrimonio.RequestPatrimonio();
            ServicoPatrimonio.ResponsePatrimonio response = new InterfaceUsuario.ServicoPatrimonio.ResponsePatrimonio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("ConsultarPatrimonio");
            dir = null;
            

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsPatrimonio.Url = _url;

                try
                {
                    response = wsPatrimonio.ConsultarPatrimonio(request);
                    if (response != null && response.StatusCode ==(int)Arv.Common.BaseResponse.ResponseStatus.OK)
                    {
                        // falta implementar a função aqui     
                        //*************************************************
                        //
                        //
                        //
                        //
                        //*************************************************
                        retorno = false; //true;
                    }

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

            return _listaPatrimonio;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <returns></returns>
        //public List<Patrimonio> ConsultarPatrimonio(int _IdTipoAtributo)
        
        //public List<Patrimonio> ConsultarPatrimonio(int _IdTipoAtributo, int _IdAtributo)
        
        //public List<Patrimonio> ConsultarPatrimonio(DateTime DataInicial, DateTime DataFinal)
        
 
    }
}
