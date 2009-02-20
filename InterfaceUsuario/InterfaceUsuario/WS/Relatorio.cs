﻿using System;
using System.Data;
using System.Collections.Generic

namespace InterfaceUsuario.WS
{
    public class Relatorio
    {
        //TODO:  tratar as exceptions

        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <returns></returns>
        public List<Patrimonio> GerarRelatorio()
        {
            bool retorno = false;
            ServicoRelatorio.ServicoRelatorio wsRelatorio = new InterfaceUsuario.ServicoRelatorio.ServicoRelatorio();
            ServicoRelatorio.RequestRelatorio request = new InterfaceUsuario.ServicoRelatorio.RequestRelatorio();
            ServicoRelatorio.ResponseRelatorio response = new InterfaceUsuario.ServicoRelatorio.ResponseRelatorio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("GerarAtributo");
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsRelatorio.Url = _url;

                try
                {
                    response = wsRelatorio.GerarRelatorio(request);
                    if (response != null && response.StatusCode == 200)
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

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <returns></returns>
        public List<Patrimonio> GerarRelatorio(int _IdTipoAtributo)
        {
            bool retorno = false;
            ServicoRelatorio.ServicoRelatorio wsRelatorio = new InterfaceUsuario.ServicoRelatorio.ServicoRelatorio();
            ServicoRelatorio.RequestRelatorio request = new InterfaceUsuario.ServicoRelatorio.RequestRelatorio();
            ServicoRelatorio.ResponseRelatorio response = new InterfaceUsuario.ServicoRelatorio.ResponseRelatorio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("GerarAtributo");
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsRelatorio.Url = _url;

                try
                {
                    response = wsRelatorio.GerarRelatorio(request);
                    if (response != null && response.StatusCode == 200)
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

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <returns></returns>
        public List<Patrimonio> GerarRelatorio(int _IdTipoAtributo, int _IdAtributo)
        {
            bool retorno = false;
            ServicoRelatorio.ServicoRelatorio wsRelatorio = new InterfaceUsuario.ServicoRelatorio.ServicoRelatorio();
            ServicoRelatorio.RequestRelatorio request = new InterfaceUsuario.ServicoRelatorio.RequestRelatorio();
            ServicoRelatorio.ResponseRelatorio response = new InterfaceUsuario.ServicoRelatorio.ResponseRelatorio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("GerarAtributo");
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsRelatorio.Url = _url;

                try
                {
                    response = wsRelatorio.GerarRelatorio(request);
                    if (response != null && response.StatusCode == 200)
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

            return retorno;
        }
        /// <summary>
        /// Metodo incompleto
        /// </summary>
        /// <returns></returns>
        public List<Patrimonio> GerarRelatorio(DateTime DataInicial, DateTime DataFinal)
        {
            bool retorno = false;
            ServicoRelatorio.ServicoRelatorio wsRelatorio = new InterfaceUsuario.ServicoRelatorio.ServicoRelatorio();
            ServicoRelatorio.RequestRelatorio request = new InterfaceUsuario.ServicoRelatorio.RequestRelatorio();
            ServicoRelatorio.ResponseRelatorio response = new InterfaceUsuario.ServicoRelatorio.ResponseRelatorio();

            Diretorio dir = new Diretorio();
            // A nome do serviço é definido no banco de dados, pelo serviço diretório
            string _url = dir.ObtemEnderecoServico("GerarAtributo");
            dir = null;


            if (_url != string.Empty)
            {
                // atualiza o endereco do WS
                wsRelatorio.Url = _url;

                try
                {
                    response = wsRelatorio.GerarRelatorio(request);
                    if (response != null && response.StatusCode == 200)
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

            return retorno;
        }
    }
}
