using System;
using System.Data;
using System.Data.SqlClient;
using Arv.Database;
using System.Collections.Generic;

namespace Patrimonio.TipoPatrimonio
{
    public class DAOTipoPatrimonio
    {
        private string _connString;
		
		public DAOTipoPatrimonio()
        {
            _connString = Properties.Settings.Default.ConnectionString;
        }

		internal int InsereTipoPatrimonio(TipoPatrimonio tipopatrimonio)
        {
            int linhasafetadas = 0;
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@nome", tipopatrimonio.Nome));
                parameters.Add(new SqlParameter("@desc", tipopatrimonio.Descricao));
                //parameters.Add(new SqlParameter("@tipo", tipopatrimonio.Descricao));

                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_tipopatrimonio_inserir", parameters);
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
            int linhasafetadas = 0;
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@id", tipoPatrimonioId));

                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_tipopatrimonio_remover", parameters);
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

        public TipoPatrimonio alteraTipoPatrimonio(TipoPatrimonio tipopatrimonio)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            int linhasafetadas = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@id", tipopatrimonio.Id));
                parameters.Add(new SqlParameter("@nome", tipopatrimonio.Nome));
                parameters.Add(new SqlParameter("@desc", tipopatrimonio.Descricao));
                
                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_tipopatrimonio_alterar", parameters);
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
                throw new Exception("Tipo de Patrimônio não atualizado corretamente.");

            return tipopatrimonio;
        }
        public TipoPatrimonio consultaTipoPatrimonio(int tipoPatrimonioId)
        {
            TipoPatrimonio tipoPatrimonio = null;
            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@id", tipoPatrimonioId));

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_tipopatrimonio_consultar");

                if (rd.Read())
                {
                    tipoPatrimonio = new TipoPatrimonio();
                    tipoPatrimonio.Id = Convert.ToInt32(rd["idTipoPatrimonio"].ToString());
                    tipoPatrimonio.Nome = rd["nomeTipoPatrimonio"].ToString();
                    tipoPatrimonio.Descricao = rd["descTipoPatrimonio"].ToString();
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

            return tipoPatrimonio;
        }
        public List<TipoPatrimonio> ListaTipoPatrimonio(TipoPatrimonio tipoPatrimonio)
        {
            List<TipoPatrimonio> _listaTipoPatrimonio = new List<TipoPatrimonio>();
            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@id", tipoPatrimonioId));

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_tipopatrimonio_consultar");

                if (rd.Read())
                {
                    TipoPatrimonio tipoPatrimonio = new TipoPatrimonio();
                    tipoPatrimonio.Id = Convert.ToInt32(rd["idTipoPatrimonio"].ToString());
                    tipoPatrimonio.Nome = rd["nomeTipoPatrimonio"].ToString();
                    tipoPatrimonio.Descricao = rd["descTipoPatrimonio"].ToString();
                    _listaTipoPatrimonio.Add(tipoPatrimonio);
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

            return tipoPatrimonio;
        }

        public List<TipoPatrimonio> buscaTipoPatrimonio(TipoPatrimonio tipoPatrimonio)
        {
            List<TipoPatrimonio> listTipoPatrimonio = new List<TipoPatrimonio>();
            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@id", tipoPatrimonio.Id));
                parameters.Add(new SqlParameter("@nome", tipoPatrimonio.Nome));
                parameters.Add(new SqlParameter("@desc", tipoPatrimonio.Descricao));

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_tipopatrimonio_consultar");

                while (rd.Read())
                {
                    TipoPatrimonio tipopa = new TipoPatrimonio();
                    tipopa.Id = Convert.ToInt32(rd["idTipoPatrimonio"].ToString());
                    tipopa.Nome = rd["nomeTipoPatrimonio"].ToString();
                    tipopa.Descricao = rd["descTipoPatrimonio"].ToString();

                    listTipoPatrimonio.Add(tipopa);
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

            return listTipoPatrimonio;
        }
    }

     

}
