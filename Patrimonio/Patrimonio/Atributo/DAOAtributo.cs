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
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@nome", atributo.Nome));
                parameters.Add(new SqlParameter("@tipo", atributo.Tipo));
                parameters.Add(new SqlParameter("@desc" , atributo.Descricao));
                parameters.Add(new SqlParameter("@nulo", atributo.Nulo? "s" : "n"));
                
                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_atributo_inserir", parameters);
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
            int linhasafetadas = 0;
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_atributo_remover");
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

        public Atributo alteraAtributo(Atributo atributo)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            int linhasafetadas = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@id", atributo.Id));
                parameters.Add(new SqlParameter("@nome", atributo.Nome));
                parameters.Add(new SqlParameter("@tipo", atributo.Tipo));
                parameters.Add(new SqlParameter("@desc", atributo.Descricao));
                //parameters.Add(new SqlParameter("@tipoPatrimonio", atributo.IdTipoPatrimonio));
                parameters.Add(new SqlParameter("@nulo", atributo.Nulo ? "s" : "n"));

                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_atributo_alterar", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.FechaConexao();
            }
            if (linhasafetadas <= 0)
                throw new Exception("Atributo não atualizado corretamente.");

            return atributo;
        }
        public Atributo consultaAtributo(int atributoId)
        {
            Atributo atributo = null;
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@id", atributoId));

                db.AbreConexao();
                SqlDataReader reader = db.ExecuteProcedureReader("sp_atributo_consultar", parameters);
                if (reader.Read())
                {
                    atributo = new Atributo();
                    atributo.Descricao = (reader["descAtributo"] != DBNull.Value) ? Convert.ToString(reader["descAtributo"]) : String.Empty;
                    atributo.Id = (reader["idAtributo"] != DBNull.Value) ? Convert.ToInt32(reader["idAtributo"]) : -1;
                    atributo.Nome = (reader["nomeAtributo"] != DBNull.Value) ? Convert.ToString(reader["nomeAtributo"]) : String.Empty;
                    atributo.Nulo = (reader["nuloAtributo"] != DBNull.Value) ?
                        (Convert.ToString(reader["nuloAtributo"]) == "s") ? true : false
                        : false;
                    atributo.Tipo = (reader["tipoAtributo"] != DBNull.Value) ? Convert.ToString(reader["tipoAtributo"]) : String.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.FechaConexao();
            }
            return atributo;
        }
        public List<Atributo> buscaAtributos(string atributoNome,string atributoDescricao,string atributoTipo,bool atributoNulo, List<string> listaValores, string valor)
        {
            //retorna atributos com o mesmo nome e/ou descricao e/ou tipo e/ou se é nulo ou nao e também a lista de valores
            return null;
        }

    }
}
