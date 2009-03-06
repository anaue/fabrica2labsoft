using System;
using System.Collections.Generic;
using System.Data;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace InterfaceUsuario.Classes
{
    public class Patrimonio
    {
        public Patrimonio()
        {

        }
        #region Acessors
        private int _idEquipamento;
        public int IdEquipamento
        {
            get { return _idEquipamento; }
            set { _idEquipamento = value; }
        }

        private int _numeroPECE;
        public int NumeroPECE
        {
            get { return _numeroPECE; }
            set { _numeroPECE = value; }
        }
        private DateTime _dtCompra;
        public DateTime DtCompra
        {
            get { return _dtCompra; }
            set { _dtCompra = value; }
        }
        private int _numeroNotaFiscal;
        public int NumeroNotaFiscal
        {
            get { return _numeroNotaFiscal; }
            set { _numeroNotaFiscal = value; }
        }
        private DateTime _dtExpGarantia;
        public DateTime DtExpGarantia
        {
            get { return _dtExpGarantia; }
            set { _dtExpGarantia = value; }
        }
        private List<Atributo> _listAtributos;
        [XmlElement(ElementName = "ListAtributos")]
        public List<Atributo> ListAtributos
        {
            get { return _listAtributos; }
            set { _listAtributos = value; }
        }

        private string _caminhoFotoNotaFiscal;
        public string CaminhoFotoNotaFiscal
        {
            get { return _caminhoFotoNotaFiscal; }
            set { _caminhoFotoNotaFiscal = value; }
        }

        private string _caminhoFotoPatrimonio;
        public string CaminhoFotoPatrimonio
        {
            get { return _caminhoFotoPatrimonio; }
            set { _caminhoFotoPatrimonio = value; }
        }

        private string _localPatrimonio;
        public string LocalPatrimonio
        {
            get { return _localPatrimonio; }
            set { _localPatrimonio = value; }
        }

        private string _numeroPedido;
        public string NumeroPedido
        {
            get { return _numeroPedido; }
            set { _numeroPedido = value; }
        }
        #endregion Acessors


        public int CriaPatrimonio()
        {
            int retorno =0;
            WS.Patrimonio ws = new InterfaceUsuario.WS.Patrimonio();
            //retorno = ws.CriaAtributo(this);

            return retorno;
        }
        /// <summary>
        /// Apaga os atributo do sistema, identificando pelo ID
        /// </summary>
        /// <returns>True ou False se foi bem sucessido</returns>
        public bool DeletaPatrimonio(int id)
        {
            bool retorno = false;
            WS.Patrimonio ws = new InterfaceUsuario.WS.Patrimonio();
           // retorno = ws.DeletaAtributo(id);

            return retorno;
        }
        /// <summary>
        /// Apaga os atributo do sistema, identificando pelo ID
        /// </summary>
        /// <returns>True ou False se foi bem sucessido</returns>
        public bool BaixaPatrimonio(int id)
        {
            bool retorno = false;
            WS.Patrimonio ws = new InterfaceUsuario.WS.Patrimonio();
            // retorno = ws.DeletaAtributo(id);

            return retorno;
        }
        /// <summary>
        /// Atualiza os dados do Atributo em questão
        /// </summary>
        /// <param name="atributo">O objeto precisa ter o ID definido para fazer a busca</param>
        /// <returns>True ou False se foi bem sucessido </returns>
        public bool AlteraPatrimonio(Patrimonio patrimonio)
        {
            bool retorno = false;
            if (patrimonio._idEquipamento > -1)
            {
                WS.Patrimonio ws = new InterfaceUsuario.WS.Patrimonio();
                //retorno = ws.AlteraAtributo(atributo);
            }

            return retorno;
        }
        /// <summary>
        /// Realiza a consulta de atributos.
        /// </summary>
        /// <returns>Retorna lista com um atributo</returns>
        public Patrimonio ConsultaPatrimonio(int id)
        {
            Patrimonio patrimonio = new Patrimonio();
            WS.Patrimonio ws = new InterfaceUsuario.WS.Patrimonio();
            //patrimonio = ws.ConsultaAtributo(id);

            return patrimonio;
        }
        /// <summary>
        /// Registra manutencao.
        /// </summary>
        /// <returns>Retorna o id do patrimonio</returns>
        public int ColocaManutencao(Manutencao manutencao)
        {
            int retorno = 0;
            WS.Patrimonio ws = new InterfaceUsuario.WS.Patrimonio();
            retorno = ws.RegistrarPatrimonio(this, manutencao);
            return retorno;
        }
    }
}
