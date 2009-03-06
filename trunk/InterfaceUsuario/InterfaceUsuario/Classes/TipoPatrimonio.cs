using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InterfaceUsuario.Classes
{
    public class TipoPatrimonio
    {
        public TipoPatrimonio(int id, string nome, string descricao)
        {
            _id = id;
            _nome = nome;
            _descricao = descricao;
        }
        public TipoPatrimonio()
        {
            _nome = string.Empty;
            _descricao = string.Empty;
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

        private List<Atributo> listAtributos;

        public List<Atributo> ListAtributos
        {
            get { return listAtributos; }
            set { listAtributos = value; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Solicita o serviço de inserção de um Tipos de Patrimonio no sistema
        /// </summary>
        /// <returns>Retorna o ID do Tipos de Patrimonio, vindo do BD</returns>
        public int CriaTipoPatrimonio()
        {
            int retorno = 0;
            WS.TipoPatrimonio ws = new InterfaceUsuario.WS.TipoPatrimonio();
            retorno = ws.CriaTipoPatrimonio(this);
            _id = retorno;

            return retorno;
        }
        /// <summary>
        /// Apaga os atributo do sistema, identificando pelo ID
        /// </summary>
        /// <returns>True ou False se foi bem sucessido</returns>
        public bool DeletaTipoPatrimonio(int id)
        {
            bool retorno = true;
            WS.TipoPatrimonio ws = new InterfaceUsuario.WS.TipoPatrimonio();
            retorno = ws.DeletaTipoPatrimonio(id);
            return retorno;
        }  
       
        /// <summary>
        /// Lista os Tipos de Patrimonio
        /// </summary>
        /// <returns>Retorna lista de atributos do sistema</returns>
        public List<TipoPatrimonio> ListaTipoPatrimonio()
        {
            List<TipoPatrimonio> retorno = new List<TipoPatrimonio>();

            WS.TipoPatrimonio ws = new InterfaceUsuario.WS.TipoPatrimonio();
            retorno = ws.ListaTipoPatrimonio();
            
            return retorno;
        }


            
        public TipoPatrimonio ConsultaTipoPatrimonio(int id)
        {
            TipoPatrimonio tipopatrimonio = new TipoPatrimonio();

            WS.TipoPatrimonio ws = new InterfaceUsuario.WS.TipoPatrimonio();
            tipopatrimonio = ws.ConsultaTipoPatrimonio(id);

            return tipopatrimonio;
        }
       
        /// <summary>
        /// Atualiza os dados do Tipos de Patrimonio em questão
        /// </summary>
        /// <param name="atributo">O objeto precisa ter o ID definido para fazer a busca</param>
        /// <returns>True ou False se foi bem sucessido </returns>
        public bool AlteraTipoPatrimonio(TipoPatrimonio tipopatrimonio)
        {
            bool retorno = true;
            WS.TipoPatrimonio ws = new InterfaceUsuario.WS.TipoPatrimonio();
            if (tipopatrimonio.Id > -1)
            {
                retorno = ws.AlteraTipoPatrimonio(tipopatrimonio);
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        #endregion
    }
}
