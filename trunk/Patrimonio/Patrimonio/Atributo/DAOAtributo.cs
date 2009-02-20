using System;
using System.Data;
using System.Data.SqlClient;
using Arv.Database;
using System.Collections.Generic;

namespace Patrimonio.Atributo
{
    public class DAOAtributo
    {
       
         public DAOAtributo()
        {
            _connString = Properties.Settings.Default.ConnectionString;
        }
         private string _connString;

        public int InsereAtributo(Atributo atributo)
        {
            int linhasafetadas = 0;
            int idGerado = 0;
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@nome", atributo.Nome));
                parameters.Add(new SqlParameter("@tipo", atributo.Tipo));
                parameters.Add(new SqlParameter("@descricao" , atributo.Descricao));
                parameters.Add(new SqlParameter("@nulo", atributo.Nulo));
                
                db.AbreConexao();
                linhasafetadas = db.ExecuteTextNonQuery(" INSERT INTO tb_Atributo (idAtributo, nomeAtributo, descAtributo, tipoAtributo, nuloAtributo) VALUES( 3, @nome, @descricao, @tipo, @nulo)", parameters);
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
    }
}
