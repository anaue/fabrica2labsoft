using System;
using System.Data;
using System.Data.SqlClient;
using Arv.Database;
using System.Collections.Generic;

namespace Usuarios.Autenticador
{
    public class DAOAutenticador
    {

        private string _connString;

        public DAOAutenticador()
        {
            _connString = Properties.Settings.Default.ConnectionString;
        }

        /// <summary>
        /// Recebe um identificador de Usuario e um identificador de Tela, e devolve um objeto Autenticador 
        /// com as permissoes inserir, excluir, consultar e editar daquele Usuario para aquela Tela
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idTela"></param>
        /// <returns></returns>
        public Autenticador VerificaPermissoes(int idUsuario, int idTela)
        {
            Autenticador autenticador = new Autenticador();

            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                parameters.Add(new SqlParameter("@idTela", idTela));

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_permissoes_consultar", parameters);

                if (rd.Read())
                {
                    autenticador.IdUsuario = idUsuario;
                    autenticador.IdTela = idTela;
                    autenticador.PermissaoConsultar = Convert.ToBoolean(rd["consultar"]);
                    autenticador.PermissaoEditar = Convert.ToBoolean(rd["editar"]);
                    autenticador.PermissaoExcluir = Convert.ToBoolean(rd["excluir"]);
                    autenticador.PermissaoIncluir = Convert.ToBoolean(rd["incluir"]);
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

            return autenticador;
        }
    }
}
