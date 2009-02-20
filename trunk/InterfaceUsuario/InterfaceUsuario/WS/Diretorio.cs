using System;
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
    public class Diretorio
    {
        /// <summary>
        /// Utiliza o serviço diretório de WSs, que basicamente retorna o endereço de localizado do serviço pedido
        /// </summary>
        /// <param name="nomeServico">O nome do serviço está definido no BD</param>
        /// <returns></returns>
        public string ObtemEnderecoServico(string nomeServico)
        {
            ServicoDiretorio.Servicos wsServico = new InterfaceUsuario.ServicoDiretorio.Servicos();
            string endereco = string.Empty;
            try
            {
                endereco = wsServico.ObtemEnderecoServico(nomeServico);
            }
            catch (Exception ex)
            {
                //endereco = "Erro ao tentar obter localização do Serviço";
            }
            return endereco;
        }
    }
}
