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
            int idGerado = 0;
			
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                //parameters.Add(new SqlParameter("@nome", usuario.Nome));
                //parameters.Add(new SqlParameter("@desc", usuario.Senha));
                //parameters.Add(new SqlParameter("@tipo", usuario.Descricao));

                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_usuario_inserir", parameters);
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
            //remover atributo do banco
            return 0;
        }

        public TipoPatrimonio alteraTipoPatrimonio(TipoPatrimonio tipopatrimonio)
        {
            //alterar valor do tipo de atribuyo e retorna o tipo de atributo
            return null;
        }
        public TipoPatrimonio consultaTipoPatrimonio(int tipoPatrimonioId)
        {
            //retorna um atributo com seus valores
            return null;
        }
        public List<TipoPatrimonio> buscaTipoPatrimonio(int tipoPatrimonioId)
        {
            //retorna um atributo com seus valores
            return null;
        }
    }

     

}
