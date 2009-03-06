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
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.PATRIMONIO_CONSULTAR);
            dir = null;
            

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsPatrimonio.Url = _url;

                try
                {
                    response = wsPatrimonio.ConsultarPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoPatrimonio.ResponseStatus.OK)
                    {
                        // falta implementar a função aqui     
                        //*************************************************
                        //
                        //
                        //
                        //
                        //*************************************************
                        // retorno = false; //true;
                    }

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

            return _listaPatrimonio;
        }

        public int RegistrarPatrimonio(Classes.Patrimonio patrimonio, Classes.Manutencao manutencao)
        {
            int retorno = -1;
            ServicoPatrimonio.ServicoPatrimonio wsPatrimonio = new InterfaceUsuario.ServicoPatrimonio.ServicoPatrimonio();
            ServicoPatrimonio.RequestPatrimonio request = new InterfaceUsuario.ServicoPatrimonio.RequestPatrimonio();
            ServicoPatrimonio.ResponsePatrimonio response = new InterfaceUsuario.ServicoPatrimonio.ResponsePatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.PATRIMONIO_REGISTRAR_MANUTENCAO);
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                wsPatrimonio.Url = _url;
                request.Patrimonio.IdEquipamento = patrimonio.IdEquipamento;
                request.Patrimonio.LocalPatrimonio= patrimonio.LocalPatrimonio;
                request.Patrimonio.NumeroNotaFiscal = patrimonio.NumeroNotaFiscal;
                request.Patrimonio.NumeroPECE = patrimonio.NumeroPECE;
                request.Patrimonio.NumeroPedido = patrimonio.NumeroPedido;
                request.Patrimonio.CaminhoFotoNotaFiscal = patrimonio.CaminhoFotoNotaFiscal;
                request.Patrimonio.CaminhoFotoPatrimonio= patrimonio.CaminhoFotoPatrimonio;
                request.Patrimonio.DataCompra = patrimonio.DtCompra;
                request.Patrimonio.DataExpGarantia = patrimonio.DtExpGarantia;

                request.Patrimonio.ListAtributos = new InterfaceUsuario.ServicoPatrimonio.Atributo[patrimonio.ListAtributos.Count];

                for (int i = 0; i < patrimonio.ListAtributos.Count; i++)
                {
                    request.Patrimonio.ListAtributos[i] = new InterfaceUsuario.ServicoPatrimonio.Atributo();
                    request.Patrimonio.ListAtributos[i].Descricao = patrimonio.ListAtributos[i].Descricao;
                    request.Patrimonio.ListAtributos[i].Id = patrimonio.ListAtributos[i].Id;
                    patrimonio.ListAtributos[i].ListaValores.CopyTo(request.Patrimonio.ListAtributos[i].ListaValores);
                    request.Patrimonio.ListAtributos[i].Nome = patrimonio.ListAtributos[i].Nome;
                    request.Patrimonio.ListAtributos[i].Nulo = patrimonio.ListAtributos[i].Nulo;
                    request.Patrimonio.ListAtributos[i].Tipo = patrimonio.ListAtributos[i].Tipo;
                    request.Patrimonio.ListAtributos[i].Valor = patrimonio.ListAtributos[i].Valor;

                }

                request.Manutencao = new ServicoPatrimonio.Manutencao();
                request.Manutencao.IdManutencao = manutencao.IdManutencao;
                request.Manutencao.IdUsuario= manutencao.IdUsuario;
                request.Manutencao.Motivo= manutencao.Motivo;
                request.Manutencao.Observacao = manutencao.Observacao;

                try
                {
                    response = wsPatrimonio.RegistrarManutencao(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoPatrimonio.ResponseStatus.OK && response.Manutencao != null)
                        retorno = response.Manutencao.IdManutencao ;

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
