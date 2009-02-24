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
                linhasafetadas = db.ExecuteTextNonQuery("sp_insere_atributo", parameters);
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

        public int deletaAtributo(int atributoId)
        { 
         //remover atributo do banco
            return 0;
        }

        public Atributo alteraAtributo(Atributo atributo)
        {
            //alterar valor do atributo e retorna o atributo
            return null;
        }
        public Atributo consultaAtributo(int atributoId)
        { 
           //retorna um atributo com seus valores
            return null;
        }
        public List<Atributo> buscaAtributos(int atributoId)
        {
            //retorna um atributo com seus valores
            return null;
        }

    }
}
