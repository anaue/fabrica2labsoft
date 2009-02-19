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

namespace InterfaceUsuario.Classes
{
    public class Atributo
    {
        public Atributo(int id, string nome, string descricao,string tipo,bool nulo)
        {
            _id = id;
            _nome = nome;
            _descricao = descricao;
            _tipo = tipo;
            _nulo = nulo;
        }
        public Atributo()
        {
            _nome = string.Empty;
            _descricao = string.Empty;
            _tipo = string.Empty;
            _nulo = false;
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
        #endregion

        #region Methods
        /// <summary>
        /// Solicita o serviço de inserção de um atributo no sistema
        /// </summary>
        /// <returns>Retorna o ID do atributo, vindo do BD</returns>
        public int CriaAtributo()
        {
            int retorno;
            retorno = WS.Atributo.CriaAtributo(this);
            _id = retorno;

            return retorno;
        }
        /// <summary>
        /// Apaga os atributo do sistema, identificando pelo ID
        /// </summary>
        /// <returns>True ou False se foi bem sucessido</returns>
        public bool DeletaAtributo(int id)
        {
            bool retorno = true;

            return retorno;
        }
        /// <summary>
        /// Atualiza os dados do Atributo em questão
        /// </summary>
        /// <param name="atributo">O objeto precisa ter o ID definido para fazer a busca</param>
        /// <returns>True ou False se foi bem sucessido </returns>
        public bool AlteraAtributo(Atributo atributo)
        {
            bool retorno = true;
            if (atributo.Id > -1)
            {

            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        /// <summary>
        /// Realiza a consulta de atributos.
        /// </summary>
        /// <returns>Retorna lista de atributos do sistema</returns>
        public List<Atributo> ConsultaAtributo()
        {
            List<Atributo> atributos = new List<Atributo>();


            return atributos;
        }
        #endregion



    }
}
