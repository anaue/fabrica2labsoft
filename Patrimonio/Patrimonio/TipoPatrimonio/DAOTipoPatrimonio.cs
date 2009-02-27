using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;
using Arv.Database;

namespace Patrimonio.TipoPatrimonio
{
    public class DAOTipoPatrimonio
    {
        public DAOTipoPatrimonio()
        {
            _connString = Properties.Settings.Default.ConnectionString;
        }
        private string _connString;
        public int InsereTipoPatrimonio(TipoPatrimonio tipopatrimonio)
        {
            int linhasafetadas = 0;
            int idGerado = 0;
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.FechaConexao();
            }
            return linhasafetadas;
        }

        public int deletaTipoPatrimonio(int tipoPatrimonioId)
        {
            //remover atributo do banco
            return 0;
        }

        public TipoPatrimonio alteraTipoPatrimonio(TipoPatrimonio tipopatrimonio)
        {
            //alterar valor do tipo de atribuyo e retorna o tipo de atributo
            return null;
        }
        public TipoPatrimonio consultaTipoPatrimonio(int tipoPatrimonioId)
        {
            //retorna um atributo com seus valores
            return null;
        }
        public List<TipoPatrimonio> buscaTipoPatrimonio(int tipoPatrimonioId)
        {
            //retorna um atributo com seus valores
            return null;
        }
    }

     

}
