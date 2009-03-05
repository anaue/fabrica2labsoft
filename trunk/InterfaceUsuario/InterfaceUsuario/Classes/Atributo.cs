using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections;

namespace InterfaceUsuario.Classes
{
    public class Atributo
    {
        public Atributo(int id, string nome, string descricao, string tipo, bool nulo, List<string> listaValores, string valor)
        {
            _id = id;
            _nome = nome;
            _descricao = descricao;
            _tipo = tipo;
            _nulo = nulo;
            _listaValores = listaValores;
            _valor = valor;
            
        }
        public Atributo()
        {
            _nome = string.Empty;
            _descricao = string.Empty;
            _tipo = string.Empty;
            _nulo = false;
            _listaValores = null;
            _valor = string.Empty;
        }

        #region Accessors
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private bool _nulo;

        public bool Nulo
        {
            get { return _nulo; }
            set { _nulo = value; }
        }
        private List<string> _listaValores;

        public List<string> ListaValores
        {
            get { return _listaValores; }
            set { _listaValores = value; }
        }

        private string _valor;

        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Solicita o serviço de inserção de um atributo no sistema
        /// </summary>
        /// <returns>Retorna o ID do atributo, vindo do BD</returns>
        public int CriaAtributo()
        {
            int retorno;
            WS.Atributo ws = new InterfaceUsuario.WS.Atributo();
            retorno = ws.CriaAtributo(this);
            _id = retorno;

            return retorno;
        }
        /// <summary>
        /// Apaga os atributo do sistema, identificando pelo ID
        /// </summary>
        /// <returns>True ou False se foi bem sucessido</returns>
        public bool DeletaAtributo(int id)
        {


            bool retorno = false;
            WS.Atributo ws = new InterfaceUsuario.WS.Atributo();
            retorno = ws.DeletaAtributo(id);
            
            return retorno;
        }
        /// <summary>
        /// Atualiza os dados do Atributo em questão
        /// </summary>
        /// <param name="atributo">O objeto precisa ter o ID definido para fazer a busca</param>
        /// <returns>True ou False se foi bem sucessido </returns>
        public bool AlteraAtributo(Atributo atributo)
        {
            bool retorno = false;
            if (atributo.Id > -1)
            {
                WS.Atributo ws = new InterfaceUsuario.WS.Atributo();
                retorno = ws.AlteraAtributo(atributo);
            }
         
            return retorno;
        }
        /// <summary>
        /// Realiza a consulta de atributos.
        /// </summary>
        /// <returns>Retorna lista com um atributo</returns>
        public Atributo ConsultaAtributo(int id)
        {
            Atributo atributo = new Atributo();
            WS.Atributo ws = new InterfaceUsuario.WS.Atributo();
            atributo = ws.ConsultaAtributo(id);

            return atributo;
        }

        /// <summary>
        /// Realiza a consulta de atributos.
        /// </summary>
        /// <returns>Retorna lista com atributos</returns>
        public List<Atributo> BuscaAtributos(string nome, string descricao, string tipo, bool nulo,List<string> listaValores, string valor)
        {
            List<Atributo> atributos = new List<Atributo>();
            WS.Atributo ws = new InterfaceUsuario.WS.Atributo();
            atributos = ws.BuscaAtributos(nome,descricao,tipo,nulo,listaValores, valor);

            return atributos;
        }

        #endregion



    }
}
