using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web; 
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Maestro
{
    /// <summary>
    /// Summary description for Servicos
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]
    public class Servicos : System.Web.Services.WebService
    {
        [WebMethod]
        public string ObtemEnderecoServico(string _NomeServico)
        {
            string _endereco = string.Empty;
            //TODO:
            //FAZER ESSA FUNCAO DIREITO !
            //

            switch (_NomeServico)
            {
                case "CriarAtributo":
                    {
                        _endereco = "http://localhost:1165/Atributo/ServicoAtributo.asmx";
                        break;
                    }
                case "DeletarAtributo":
                    {
                        _endereco = "http://localhost:1165/Atributo/ServicoAtributo.asmx";
                        break;
                    }
                case "AlterarAtributo":
                    {
                        _endereco = "http://localhost:1165/Atributo/ServicoAtributo.asmx";
                        break;
                    }
                case "ConsultarAtributo":
                    {
                        _endereco = "http://localhost:1165/Atributo/ServicoAtributo.asmx";
                        break;
                    }
            }
            return _endereco;


            //Response _response = new Response();
            //try
            //{
            //    if (_request != null)
            //    {//se tudo ocorrer bem executa o serviço

                    //_response.ServiceAddress = servicoDiretorio.ObtemServico(_NomeServico);

            //        _response.StatusCode = 200; //200 significa recebido com sucesso
            //    }
            //    else
            //    {
            //        _response.StatusCode = 204; //204, no content
            //        _response.Message = "Erro no recebimento do request";
            //    }

            //}
            //catch (Exception ex)
            //{
            //    _response.StatusCode = 500;//internal server error
            //    _response.Message = string.Format("Erro no serviço: {0}", ex.Message);
            //}
            //return _response;


        }
    }

}
