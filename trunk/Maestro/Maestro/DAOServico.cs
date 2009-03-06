using System;
using System.Data;
using System.Data.SqlClient;
using Arv.Database;
using System.Collections.Generic;

namespace Maestro
{
    public class DAOServico
    {
        private string _connString;

        public DAOServico()
        {
            _connString = Properties.Settings.Default.ConnectionString;
        }


        internal string ConsultarEndereco(string _nomeServico)
        {
            //Recebe: objeto nomeServico
            //Devolve: 

            string _endereco = string.Empty;
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@nomeServico", _nomeServico));

                db.AbreConexao();
                SqlDataReader reader = db.ExecuteProcedureReader("sp_servico_consultar", parameters);
                if (reader.Read())
                    _endereco = reader["EnderecoServico"] != DBNull.Value ? Convert.ToString(reader["EnderecoServico"]) : String.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.FechaConexao();
            }

            return _endereco;
        }
        internal List<Servico> ConsultarServicos()
        {
            //Recebe: objeto lista de nomeServico
            //Devolve: 
            List<Servico> listaServico = new List<Servico>();
            ArvDatabase db = new ArvDatabase(_connString);
            SqlDataReader reader;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                db.AbreConexao();
                reader =db.ExecuteProcedureReader("sp_servico_consultar_todos", parameters);

                while (reader.Read())
                {
                    Servico _srv = new Servico();
                    _srv.IdServico = reader.GetInt32(reader.GetOrdinal("id"));
                    _srv.NomeServico = reader["nome"].ToString();
                    _srv.EnderecoServico = reader["endereco"].ToString();
                    listaServico.Add(_srv);
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

            return listaServico;
        }
    }
}
