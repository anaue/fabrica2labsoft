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
using DAL.ARVDatabase;
using System.Collections.Generic;

namespace Patrimonio.Atributo
{
    public class DAOAtributo
    {
       
         public DAOAtributo()
        {
            
        }
        public int InsereAtributo(Atributo atributo)
        {
            int linhasafetadas = 0;
            int idGerado = 0;
            SqlConnection conn = null;
            try
            {
                ArvDatabase db = new ArvDatabase(new ConectorSQL().StringConexao);
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@nome", atributo.Nome));
                parameters.Add(new SqlParameter("@tipo", atributo.Tipo));
                parameters.Add(new SqlParameter("@descricao" , atributo.Descricao));
                parameters.Add(new SqlParameter("@nulo", atributo.Nulo));
                
                db.AbreConexao();
                linhasafetadas = db.ExecuteTextNonQuery(" INSERT INTO tb_Atributo (nomeAtributo, descAtributo, tipoAtributo, nuloAtributo) VALUES( @nome, @descricao, @tipo, @nulo)", parameters);
                
                idGerado = Int32.Parse(db.ExecuteScalar(" SELECT SCOPE_IDENTITY() AS ID").ToString());

                db.FechaConexao();
            }
            catch (Exception ex)
            {
                throw ex;
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
