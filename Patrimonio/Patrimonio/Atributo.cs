using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Patrimonio
{
    public class Atributo
    {
        DAOAtributo daoatributo = new DAOAtributo();
        public void criarAtributo(int id, String nome, String descricao,String tipo, Boolean nulo)
        {
            daoatributo.persisteNoBanco(id, nome, descricao, tipo, nulo);   
        }


    }
}
