using System;
using System.Data;


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
            ServicoDiretorio.Request request = new InterfaceUsuario.ServicoDiretorio.Request();
            ServicoDiretorio.Response response = new InterfaceUsuario.ServicoDiretorio.Response();

            request.ServiceName = nomeServico;
            request.ServiceVersion = 1;

            string endereco = string.Empty;
            try
            {
                response = wsServico.ObtemEnderecoServico(request);
                endereco = response.ListaServicos[0].EnderecoServico;
            }
            catch (Exception ex)
            {
                //endereco = "Erro ao tentar obter localização do Serviço";
            }
            return endereco;
        }
    }
}
