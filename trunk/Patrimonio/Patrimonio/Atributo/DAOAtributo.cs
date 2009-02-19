using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Patrimonio.Atributo
{
    public class DAOAtributo
    {
        private SqlConnection conn;
         public DAOAtributo()
        {
            
        }
        public int InsereAtributo(Atributo atributo)
        {
            int linhasafetadas;
            int idGerado;
            try
            {
                conn.ConnectionString = new ConectorSQL().StringConexao;
                SqlCommand cmd = new SqlCommand(
                  " INSERT INTO tb_Atributo (nomeAtributo, descAtributo, tipoAtributo, nuloAtributo) "
                  + " VALUES     ( "
                  + " ' " + atributo.Nome + " ',"
                  + " ' " + atributo.Descricao + " ',"
                  + " ' " + atributo.Tipo + " ',"
                  + " ' " + atributo.Nulo + " '"
                  , conn);
                linhasafetadas = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(" SELECT     @@IDENTITY AS IDGerado"
                  , conn);
                idGerado =(Int32) cmd2.ExecuteScalar();
            }
            finally
            {
                conn.Close();
            }
            if (linhasafetadas > 0) { return linhasafetadas; }
            else {return idGerado;}
        }
    }
}
