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
                throw new ApplicationException("DAOAtributo.insereAtributo(): " + ex, ex);
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
                throw new ApplicationException("DAOAtributo.alteraAtributo(): " + ex, ex);
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
                throw new ApplicationException("DAOAtributo.consultaAtributo(): " + ex, ex);
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

            List<Atributo> listaDeAtributosBuscados;
            SqlDataReader objLeitor;
            List<SqlParameter> parameters = new List<SqlParameter>();
            ArvDatabase db = new ArvDatabase(_connString);
            Atributo objAtributo;

            try
            {
                if (atributoNome != null)
                    parameters.Add(new SqlParameter("@nomeAtributo", atributoNome));
                if (atributoDescricao != null)
                    parameters.Add(new SqlParameter("@descAtributo", atributoDescricao));
                if (atributoTipo != null)
                    parameters.Add(new SqlParameter("@tipoAtributo", atributoTipo));

                parameters.Add(new SqlParameter("@nuloAtributo", atributoNulo));

                parameters[0].Direction = ParameterDirection.Output;

                db.AbreConexao();

                objLeitor = db.ExecuteProcedureReader("sp_atributo_consultar", parameters);

                listaDeAtributosBuscados = new List<Atributo>();
                while (objLeitor.Read())
                {
                    objAtributo = new Atributo();

                    if (objLeitor["nomeAtributo"] != null)
                        objAtributo.Nome = (string)objLeitor["nomeAtributo"];

                    if (objLeitor["descAtributo"] != null)
                        objAtributo.Descricao = (string)objLeitor["descAtributo"];

                    if (objLeitor["tipoAtributo"] != null)
                        objAtributo.Tipo = (string)objLeitor["tipoAtributo"];

                    if (objLeitor["nuloAtributo"] != null)
                        objAtributo.Nulo = (bool)objLeitor["nuloAtributo"];

                    listaDeAtributosBuscados.Add(objAtributo);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOAtributo.buscaAtributos(): " + ex, ex);
            }
            finally
            { 
                db.FechaConexao(); 
            }

            return null;
        }


        public List<Atributo> listaAtributosDisponiveis()
        {
            ArvDatabase db = new ArvDatabase(_connString);
            List<Atributo> listaDeAtributosDisponiveis = new List<Atributo>();

            try
            {
                db.AbreConexao();
                SqlDataReader reader = db.ExecuteProcedureReader("sp_atributo_consultar");

                if (reader.Read())
                {
                    foreach(Atributo atrib in reader)
                    {
                        listaDeAtributosDisponiveis.Add(atrib);
                    }
                }
            
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOAtributo.listaAtributosDisponiveis(): " + ex, ex);
            }
            finally
            { 
                db.FechaConexao(); 
            }

            return listaDeAtributosDisponiveis;

        }

        public List<Atributo> ListarAtributosTipoPatrimonio(int idTipoPratimonio)
        {
            List<Atributo> atributos = new List<Atributo>();
            ArvDatabase db = new ArvDatabase(_connString);
            
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@IdTipoPatrimonio", idTipoPratimonio));

                db.AbreConexao();
                SqlDataReader reader = db.ExecuteProcedureReader("sp_atributo_consultar_by_tipopatrimonio", parameters);
                while (reader.Read())
                {
                    Atributo atributo = new Atributo();
                    atributo.Descricao = (reader["descAtributo"] != DBNull.Value) ? Convert.ToString(reader["descAtributo"]) : String.Empty;
                    atributo.Id = (reader["idAtributo"] != DBNull.Value) ? Convert.ToInt32(reader["idAtributo"]) : -1;
                    atributo.Nome = (reader["nomeAtributo"] != DBNull.Value) ? Convert.ToString(reader["nomeAtributo"]) : String.Empty;
                    atributo.Nulo = (reader["nuloAtributo"] != DBNull.Value) ?
                        (Convert.ToString(reader["nuloAtributo"]) == "s") ? true : false
                        : false;
                    atributo.Tipo = (reader["tipoAtributo"] != DBNull.Value) ? Convert.ToString(reader["tipoAtributo"]) : String.Empty;
                    atributos.Add(atributo);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOAtributo.ListarAtributosTipoPatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
            return atributos;
        }

        public List<Atributo> ListarAtributosPorPatrimonio(int idPratimonio)
        {
            List<Atributo> atributos = new List<Atributo>();
            ArvDatabase db = new ArvDatabase(_connString);
            
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@IdPatrimonio", idPratimonio));

                db.AbreConexao();
                SqlDataReader reader = db.ExecuteProcedureReader("sp_atributo_consultar_by_pratimonio", parameters);
                while (reader.Read())
                {
                    Atributo atributo = new Atributo();
                    atributo.Descricao = (reader["descAtributo"] != DBNull.Value) ? Convert.ToString(reader["descAtributo"]) : String.Empty;
                    atributo.Id = (reader["idAtributo"] != DBNull.Value) ? Convert.ToInt32(reader["idAtributo"]) : -1;
                    atributo.Nome = (reader["nomeAtributo"] != DBNull.Value) ? Convert.ToString(reader["nomeAtributo"]) : String.Empty;
                    atributo.Nulo = (reader["nuloAtributo"] != DBNull.Value) ?
                        (Convert.ToString(reader["nuloAtributo"]) == "s") ? true : false
                        : false;
                    atributo.Tipo = (reader["tipoAtributo"] != DBNull.Value) ? Convert.ToString(reader["tipoAtributo"]) : String.Empty;
                    atributos.Add(atributo);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOAtributo.istarAtributosPorPatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
            return atributos;
        }
    }
}
