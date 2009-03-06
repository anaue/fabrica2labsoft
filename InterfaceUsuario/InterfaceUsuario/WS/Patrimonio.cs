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
        public Classes.Patrimonio ConsultarPatrimonio( int _idEquipamento)
        {
             Classes.Patrimonio _Patrimonio = new Classes.Patrimonio();
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

                request.Patrimonio.IdEquipamento = _idEquipamento;
                try
                {
                    response = wsPatrimonio.ConsultarPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoPatrimonio.ResponseStatus.OK && response.ListaPatrimonio!= null)
                    {
                        
                        _Patrimonio.CaminhoFotoNotaFiscal =  response.ListaPatrimonio[0].CaminhoFotoNotaFiscal;
                        _Patrimonio.CaminhoFotoPatrimonio = response.ListaPatrimonio[0].CaminhoFotoPatrimonio;
                        _Patrimonio.DtCompra= response.ListaPatrimonio[0].DataCompra;
                        _Patrimonio.DtExpGarantia= response.ListaPatrimonio[0].DataExpGarantia;
                        _Patrimonio.IdEquipamento = response.ListaPatrimonio[0].IdEquipamento;
                        foreach (ServicoPatrimonio.Atributo ptr in response.ListaPatrimonio[0].ListAtributos)
                        {
                            Classes.Atributo _ptr = new InterfaceUsuario.Classes.Atributo();
                            _ptr.Descricao = ptr.Descricao;
                            _ptr.Id = ptr.Id;
                            _ptr.ListaValores = new List<string>();
                            foreach (string str in ptr.ListaValores)
                            {
                                _ptr.ListaValores.Add(str);
                            }
                            _ptr.Nome = ptr.Nome;
                            _ptr.Nulo= ptr.Nulo;
                            _ptr.Tipo = ptr.Tipo;
                            _ptr.Valor = ptr.Valor;

                            _Patrimonio.ListAtributos.Add(_ptr);
                        }
                        _Patrimonio.LocalPatrimonio= response.ListaPatrimonio[0].LocalPatrimonio;
                        _Patrimonio.NumeroNotaFiscal = response.ListaPatrimonio[0].NumeroNotaFiscal;
                        _Patrimonio.NumeroPECE = response.ListaPatrimonio[0].NumeroPECE;
                        _Patrimonio.NumeroPedido= response.ListaPatrimonio[0].NumeroPedido;

                    }

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                }

            }

            return _Patrimonio;
        }

        public int RegistrarManutencao(Classes.Manutencao manutencao)
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
                
                request.Manutencao = new ServicoPatrimonio.Manutencao();
                request.Manutencao.IdManutencao = manutencao.IdManutencao;
                request.Manutencao.IdUsuario= manutencao.IdUsuario;
                request.Manutencao.Motivo= manutencao.Motivo;
                request.Manutencao.Observacao = manutencao.Observacao;
                request.Manutencao.IdPatrimonio = manutencao.IdPatrimonio;

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

        public int CriaPatrimonio(Classes.Patrimonio patrimonio)
        {
            int retorno = -1;
            ServicoPatrimonio.ServicoPatrimonio wsPatrimonio = new InterfaceUsuario.ServicoPatrimonio.ServicoPatrimonio();
            ServicoPatrimonio.RequestPatrimonio request = new InterfaceUsuario.ServicoPatrimonio.RequestPatrimonio();
            ServicoPatrimonio.ResponsePatrimonio response = new InterfaceUsuario.ServicoPatrimonio.ResponsePatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.PATRIMONIO_CRIAR);
            dir = null;

            #endregion Acesso WS Diretorio

            if (_url != string.Empty)
            {
                wsPatrimonio.Url = _url;
                request.Patrimonio.IdEquipamento = patrimonio.IdEquipamento;
                request.Patrimonio.LocalPatrimonio = patrimonio.LocalPatrimonio;
                request.Patrimonio.NumeroNotaFiscal = patrimonio.NumeroNotaFiscal;
                request.Patrimonio.NumeroPECE = patrimonio.NumeroPECE;
                request.Patrimonio.NumeroPedido = patrimonio.NumeroPedido;
                request.Patrimonio.CaminhoFotoNotaFiscal = patrimonio.CaminhoFotoNotaFiscal;
                request.Patrimonio.CaminhoFotoPatrimonio = patrimonio.CaminhoFotoPatrimonio;
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

                try
                {
                    response = wsPatrimonio.CriarPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoPatrimonio.ResponseStatus.OK && response.ListaPatrimonio != null)
                        retorno = response.ListaPatrimonio[0].IdEquipamento;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                    throw ex;
                }
            }

            return retorno;
        }

        public bool DeletaPatrimonio(int id)
        {
            bool retorno = false;
            ServicoPatrimonio.ServicoPatrimonio wsPatrimonio = new InterfaceUsuario.ServicoPatrimonio.ServicoPatrimonio();
            ServicoPatrimonio.RequestPatrimonio request = new InterfaceUsuario.ServicoPatrimonio.RequestPatrimonio();
            ServicoPatrimonio.ResponsePatrimonio response = new InterfaceUsuario.ServicoPatrimonio.ResponsePatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.PATRIMONIO_DELETAR);
            dir = null;
            #endregion

            //Properties.Settings.Default.InterfaceUsuario_ServicoAtributo_ServicoAtributo;

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsPatrimonio.Url = _url;

                request.Patrimonio = new InterfaceUsuario.ServicoPatrimonio.Patrimonio();
                request.Patrimonio.IdEquipamento = id;
                try
                {
                    response = wsPatrimonio.DeletarPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoPatrimonio.ResponseStatus.OK)
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

        public int AlteraPatrimonio(Classes.Patrimonio patrimonio)
        {
            int retorno = -1;
            ServicoPatrimonio.ServicoPatrimonio wsPatrimonio = new InterfaceUsuario.ServicoPatrimonio.ServicoPatrimonio();
            ServicoPatrimonio.RequestPatrimonio request = new InterfaceUsuario.ServicoPatrimonio.RequestPatrimonio();
            ServicoPatrimonio.ResponsePatrimonio response = new InterfaceUsuario.ServicoPatrimonio.ResponsePatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.PATRIMONIO_ALTERAR);
            dir = null;
            #endregion

            //Properties.Settings.Default.InterfaceUsuario_ServicoAtributo_ServicoAtributo;

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsPatrimonio.Url = _url;
                request.Patrimonio.IdEquipamento = patrimonio.IdEquipamento;
                request.Patrimonio.LocalPatrimonio = patrimonio.LocalPatrimonio;
                request.Patrimonio.NumeroNotaFiscal = patrimonio.NumeroNotaFiscal;
                request.Patrimonio.NumeroPECE = patrimonio.NumeroPECE;
                request.Patrimonio.NumeroPedido = patrimonio.NumeroPedido;
                request.Patrimonio.CaminhoFotoNotaFiscal = patrimonio.CaminhoFotoNotaFiscal;
                request.Patrimonio.CaminhoFotoPatrimonio = patrimonio.CaminhoFotoPatrimonio;
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

                try
                {
                    response = wsPatrimonio.AlterarPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoPatrimonio.ResponseStatus.OK && response.ListaPatrimonio != null)
                        retorno = response.ListaPatrimonio[0].IdEquipamento;

                }
                catch (Exception ex)
                {
                    //necessario mostrar uma mensagem ao usuario
                    throw ex;
                }

            }

            return retorno;
        }

        public int BaixaPatrimonio(Classes.Baixa baixa)
        {
            int retorno = -1;
            ServicoPatrimonio.ServicoPatrimonio wsPatrimonio = new InterfaceUsuario.ServicoPatrimonio.ServicoPatrimonio();
            ServicoPatrimonio.RequestPatrimonio request = new InterfaceUsuario.ServicoPatrimonio.RequestPatrimonio();
            ServicoPatrimonio.ResponsePatrimonio response = new InterfaceUsuario.ServicoPatrimonio.ResponsePatrimonio();

            #region Acesso WS Diretorio
            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico(Arv.Common.WSServicesNames.PATRIMONIO_ALTERAR);
            dir = null;
            #endregion

            //Properties.Settings.Default.InterfaceUsuario_ServicoAtributo_ServicoAtributo;

            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                //wsPatrimonio.Url = _url;
                //request.Patrimonio.IdEquipamento = patrimonio.IdEquipamento;
                //request.Patrimonio.LocalPatrimonio = patrimonio.LocalPatrimonio;
                //request.Patrimonio.NumeroNotaFiscal = patrimonio.NumeroNotaFiscal;
                //request.Patrimonio.NumeroPECE = patrimonio.NumeroPECE;
                //request.Patrimonio.NumeroPedido = patrimonio.NumeroPedido;
                //request.Patrimonio.CaminhoFotoNotaFiscal = patrimonio.CaminhoFotoNotaFiscal;
                //request.Patrimonio.CaminhoFotoPatrimonio = patrimonio.CaminhoFotoPatrimonio;
                //request.Patrimonio.DataCompra = patrimonio.DtCompra;
                //request.Patrimonio.DataExpGarantia = patrimonio.DtExpGarantia;

                //request.Patrimonio.ListAtributos = new InterfaceUsuario.ServicoPatrimonio.Atributo[patrimonio.ListAtributos.Count];

                //for (int i = 0; i < patrimonio.ListAtributos.Count; i++)
                //{
                //    request.Patrimonio.ListAtributos[i] = new InterfaceUsuario.ServicoPatrimonio.Atributo();
                //    request.Patrimonio.ListAtributos[i].Descricao = patrimonio.ListAtributos[i].Descricao;
                //    request.Patrimonio.ListAtributos[i].Id = patrimonio.ListAtributos[i].Id;
                //    patrimonio.ListAtributos[i].ListaValores.CopyTo(request.Patrimonio.ListAtributos[i].ListaValores);
                //    request.Patrimonio.ListAtributos[i].Nome = patrimonio.ListAtributos[i].Nome;
                //    request.Patrimonio.ListAtributos[i].Nulo = patrimonio.ListAtributos[i].Nulo;
                //    request.Patrimonio.ListAtributos[i].Tipo = patrimonio.ListAtributos[i].Tipo;
                //    request.Patrimonio.ListAtributos[i].Valor = patrimonio.ListAtributos[i].Valor;
                //}

                try
                {
                    response = wsPatrimonio.AlterarPatrimonio(request);
                    if (response != null && response.StatusCode == InterfaceUsuario.ServicoPatrimonio.ResponseStatus.OK && response.ListaPatrimonio != null)
                        retorno = response.ListaPatrimonio[0].IdEquipamento;

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
