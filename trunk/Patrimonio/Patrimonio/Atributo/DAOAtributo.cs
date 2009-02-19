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
       
         public DAOAtributo()
        {
            
        }
        public int InsereAtributo(Atributo atributo)
        {
            int linhasafetadas;
            int idGerado;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(new ConectorSQL().StringConexao);
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                  " INSERT INTO tb_Atributo (nomeAtributo, descAtributo, tipoAtributo, nuloAtributo) "
                  + " VALUES     ( "
                  + " ' " + atributo.Nome + " ',"
                  + " ' " + atributo.Descricao + " ',"
                  + " ' " + atributo.Tipo + " ',"
                  + " ' " + atributo.Nulo + " ')"
                  , conn);
                linhasafetadas = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(" SELECT     SCOPE_IDENTITY() AS ID", conn);
                idGerado =Int32.Parse(cmd2.ExecuteScalar().ToString());
                
            }
          
            finally
            {
                conn.Close();
            }
            if (linhasafetadas == 0) { return linhasafetadas; }
            else {return idGerado;}
        }
    }
}
