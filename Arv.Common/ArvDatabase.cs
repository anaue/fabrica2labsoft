using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Arv.Database
{
    public class ArvDatabase
    {
        SqlConnection conn = null;

        public ArvDatabase(string stringConexao)
        {
            try
            {
                conn = new SqlConnection(stringConexao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AbreConexao()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FechaConexao()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Executa Procedure sem retorno de registros, retorna o numero de linhas afetadas pelo procedimento
        /// </summary>
        /// <param name="nomeProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int ExecuteProcedureNonQuery(string nomeProcedure, List<SqlParameter> parameters)
        {
            int linhasafetadas = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(nomeProcedure, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (SqlParameter parameter in parameters)
                    cmd.Parameters.Add(parameter);

                linhasafetadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return linhasafetadas;
        }

        public int ExecuteProcedureNonQuery(string nomeProcedure)
        {
            int linhasafetadas = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(nomeProcedure, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                linhasafetadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return linhasafetadas;
        }

        public SqlDataReader ExecuteProcedureReader(string nomeProcedure, List<SqlParameter> parameters)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand(nomeProcedure, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (SqlParameter parameter in parameters)
                    cmd.Parameters.Add(parameter);

                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }

        public SqlDataReader ExecuteProcedureReader(string nomeProcedure)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand(nomeProcedure, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }

        public SqlDataReader ExecuteTextReader(string comando, List<SqlParameter> parameters)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                foreach (SqlParameter parameter in parameters)
                    cmd.Parameters.Add(parameter);

                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }

        public int ExecuteTextNonQuery(string comando, List<SqlParameter> parameters)
        {
            int linhasafetadas = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                foreach (SqlParameter parameter in parameters)
                    cmd.Parameters.Add(parameter);

                linhasafetadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return linhasafetadas;
        }

        public int ExecuteTextNonQuery(string comando)
        {
            int linhasafetadas = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                linhasafetadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return linhasafetadas;
        }

        public object ExecuteScalar(string comando, List<SqlParameter> parameters)
        {
            object result;
            try
            {
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                foreach (SqlParameter parameter in parameters)
                    cmd.Parameters.Add(parameter);

                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public object ExecuteScalar(string comando)
        {
            object result;
            try
            {
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
