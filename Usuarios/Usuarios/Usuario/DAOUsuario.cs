using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Usuarios.Usuario
{
    public class DAOUsuario
    {

        internal bool CriarUsuario(Usuario usuario)
        {
            //Recebe: objeto Usuario
            //Devolve: bool dizendo se cadastro ocorreu com sucesso (true) ou não (false)
            
            throw new NotImplementedException();
        }

        internal bool AlterarUsuario(Usuario usuario)
        {
            //Recebe: objeto Usuario
            //Devolve: bool dizendo se alteração ocorreu com sucesso (true) ou não (false)
            
            throw new NotImplementedException();
        }

        internal bool DeletarUsuario(int idUsuario)
        {
            //Recebe: identificao do usuario
            //Devolve: bool dizendo se remoção ocorreu com sucesso (true) ou não (false)

            throw new NotImplementedException();
        }

        internal Usuario ConsultarUsuario(int idUsuario)
        {
            //Recebe: identificao do usuario
            //Devolve: objeto populado com os dados do usuario
            
            throw new NotImplementedException();
        }

        internal System.Collections.Generic.List<Usuario> BuscaUsuarios(string nome, string descricao)
        {
            //Recebe: nome e descricao do usuario
            //Devolve: devolve uma lista de usuarios que tenham nome e/ou descricao iguais as passadas
            
            throw new NotImplementedException();
        }
    }
}
