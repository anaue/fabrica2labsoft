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

            int linhasafetadas = 0;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@nomeServico", _nomeServico));

                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_servico_consultar", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.FechaConexao();
            }

            if (linhasafetadas == 0) { return false; }
            else { return true; }
        }
    }
}
