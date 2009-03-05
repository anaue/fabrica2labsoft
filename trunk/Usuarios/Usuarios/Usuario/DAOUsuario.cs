using System;
using System.Data;
using System.Data.SqlClient;
using Arv.Database;
using System.Collections.Generic;


namespace Usuarios.Usuario
{
    public class DAOUsuario
    {
        private string _connString;

        public DAOUsuario()
        {
            _connString = Properties.Settings.Default.ConnectionString;
        }


        internal int CriarUsuario(Usuario usuario)
        {
            //Recebe: objeto Usuario
            //Devolve: id do usuario inserido

            int idUsuario = 0;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@nomeUsuario", usuario.Nome));
                parameters.Add(new SqlParameter("@senhaUsuario", usuario.Senha));
                parameters.Add(new SqlParameter("@descUsuario", usuario.Descricao));
                parameters.Add(new SqlParameter("@idTipoAcesso", usuario.TipoAcesso.Id));

                db.AbreConexao();
                idUsuario = db.ExecuteProcedureNonQuery("sp_usuario_inserir", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.FechaConexao();
            }


            if (idUsuario != 0)
                return idUsuario;
            else
                return -1;
        }

        internal bool AlterarUsuario(Usuario usuario)
        {
            //Recebe: objeto Usuario
            //Devolve: bool dizendo se alteração ocorreu com sucesso (true) ou não (false)

            int linhasafetadas = 0;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@idUsuario", usuario.Id));
                parameters.Add(new SqlParameter("@nomeUsuario", usuario.Nome));
                parameters.Add(new SqlParameter("@senhaUsuario", usuario.Senha));
                parameters.Add(new SqlParameter("@descUsuario", usuario.Descricao));
                parameters.Add(new SqlParameter("@idTipoAcesso", usuario.TipoAcesso.Id));

                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_usuario_alterar", parameters);
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

        internal bool DeletarUsuario(int idUsuario)
        {
            //Recebe: identificao do usuario
            //Devolve: bool dizendo se remoção ocorreu com sucesso (true) ou não (false)

            int linhasafetadas = 0;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@idUsuario", idUsuario));

                db.AbreConexao();
                linhasafetadas = db.ExecuteProcedureNonQuery("sp_usuario_remover", parameters);
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

        internal Usuario ConsultarUsuario(int idUsuario)
        {
            //Recebe: identificao do usuario
            //Devolve: objeto populado com os dados do usuario

            Usuario usuario = new Usuario();
            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@idUsuario", idUsuario));

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_usuario_consultar", parameters);

                if (rd.Read())
                {
                    usuario.Id = idUsuario;
                    usuario.Nome = rd["nomeUsuario"].ToString();
                    usuario.Senha = rd["senhaUsuario"].ToString();
                    usuario.Descricao = rd["descUsuario"].ToString();
                    usuario.TipoAcesso.Id = Convert.ToInt32(rd["idTipoAcesso"]);
                    usuario.TipoAcesso.Nome = rd["nomeTipoAcesso"].ToString();
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

            return usuario;
        }

        internal List<Usuario> BuscaUsuarios(string nome, string descricao)
        {
            //Recebe: nome e descricao do usuario
            //Devolve: devolve uma lista de usuarios que tenham nome e/ou descricao iguais as passadas

            List<Usuario> usuarios = new List<Usuario>();
            SqlDataReader rd;

            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                db.AbreConexao();
                rd = db.ExecuteProcedureReader("sp_usuario_consultar");

                while (rd.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(rd["idUsuario"].ToString());
                    usuario.Nome = rd["nomeUsuario"].ToString();
                    usuario.Senha = rd["senhaUsuario"].ToString();
                    usuario.Descricao = rd["descUsuario"].ToString();
                    usuario.TipoAcesso.Id = Convert.ToInt32(rd["idTipoAcesso"]);
                    usuario.TipoAcesso.Nome = rd["nomeTipoAcesso"].ToString();

                    usuarios.Add(usuario);
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

            return usuarios;
        }
    }
}
