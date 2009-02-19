using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Patrimonio.Relatorio
{
    /// <summary>
    /// Summary description for ServicoRelatorio
    /// </summary>
    [WebService(Namespace = "http://www.pece.org.br/")]

    public class ServicoRelatorio : System.Web.Services.WebService
    {

        [WebMethod(MessageName = "GeraRelatorio")]
        public ResponseRelatorio GerarRelatorio(RequestRelatorio _request)
        {
            ResponseRelatorio _response = new ResponseRelatorio();
            try
            {
                if (_request != null)
                {
                    _response.StatusCode = 200;



                    // _request.Atributo.Id = 1;
                    //_response.ListaAtributos.Add(_request.Atributo);
                }
            }
            catch (Exception ex)
            {
                _response.StatusCode = 500;
                _response.Message = string.Format("Erro na geração do relatorio: {0}", ex.Message);
            }
            return _response;
        }
    }
}
