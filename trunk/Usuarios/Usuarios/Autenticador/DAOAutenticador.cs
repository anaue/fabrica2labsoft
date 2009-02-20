using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Usuarios.Autenticador
{
    public class DAOAutenticador
    {
        public DAOAutenticador()
        {            
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
            
        }
    }    
}
