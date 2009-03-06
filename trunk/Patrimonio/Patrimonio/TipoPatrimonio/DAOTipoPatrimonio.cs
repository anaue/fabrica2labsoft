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
            int idGerado = 0;
			
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
            if (idGerado != 0)
                return idGerado;
            else
                return -1;
        }

        public int deletaTipoPatrimonio(int tipoPatrimonioId)
        {
            int idGerado = 0;

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

            if (idGerado == 0) { return true; }
            else { return false; }
        }

        public TipoPatrimonio alteraTipoPatrimonio(TipoPatrimonio tipopatrimonio)
        {
            int idGerado = 0;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@id", tipopatrimonio.Id));
                parameters.Add(new SqlParameter("@nome", tipopatrimonio.Nome));
                parameters.Add(new SqlParameter("@desc", tipopatrimonio.Descricao));
                // parameters.Add(new SqlParameter("@tipo", tipopatrimonio.Tipo));
                
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

            if (idGerado == 0) { return true; }
            else { return false; }
        }
        public TipoPatrimonio consultaTipoPatrimonio(int tipoPatrimonioId)
        {
            TipoPatrimonio tipopatrimonio = new TipoPatrimonio;
            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@id", tipoPatrimonioId));
                parameters.Add(new SqlParameter("@nome", NULL));
                parameters.Add(new SqlParameter("@desc", NULL));
                parameters.Add(new SqlParameter("@tipo", NULL));

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_tipopatrimonio_consultar");

                while (rd.Read())
                {
                    TipoPatrimonio tipopa = new TipoPatrimonio();
                    tipopa.Id = Convert.ToInt32(rd["idTipoPatrimonio"].ToString());
                    tipopa.Nome = rd["nomeTipoPatrimonio"].ToString();
                    tipopa.Descricao = rd["descTipoPatrimonio"].ToString();

                    tipopatrimonio.Add(tipopa);
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

            return tipopatrimonio;
        }
        public List<TipoPatrimonio> buscaTipoPatrimonio(int tipoPatrimonioId)
        {
            List<TipoPatrimonio> tipopatrimonio = new List<TipoPatrimonio>();
            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@id", tipoPatrimonioId));
                parameters.Add(new SqlParameter("@nome", NULL));
                parameters.Add(new SqlParameter("@desc", NULL));
                parameters.Add(new SqlParameter("@tipo", NULL));

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_tipopatrimonio_consultar");

                while (rd.Read())
                {
                    TipoPatrimonio tipopa = new TipoPatrimonio();
                    tipopa.Id = Convert.ToInt32(rd["idTipoPatrimonio"].ToString());
                    tipopa.Nome = rd["nomeTipoPatrimonio"].ToString();
                    tipopa.Descricao = rd["descTipoPatrimonio"].ToString();

                    tipopatrimonio.Add(tipopa);
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

            return tipopatrimonio;
        }
    }

     

}
