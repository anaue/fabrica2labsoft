using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using InterfaceUsuario.Classes;

namespace InterfaceUsuario
{
    public partial class alteraUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario = usuario.ConsultaUsuario(Convert.ToInt32(Request.QueryString["Id"]));

            
            usuario.Nome = "João";
            usuario.Senha = "aaa";
            usuario.Descricao = "bbb";

            TextBoxNome.Text = usuario.Nome;
            TextBoxSenhaConf.Text = usuario.Senha;
            TextBoxDescricao.Text = usuario.Descricao;

        }

        protected void Button_altera(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = TextBoxNome.Text;
            usuario.Senha = TextBoxSenhaConf.Text;
            usuario.Descricao = TextBoxDescricao.Text;

            usuario.AlteraUsuario(usuario);

            Response.Redirect("PaginaDeSucesso.aspx?Acao=Cadastrar Usuário&Msg=Alterado com sucesso");
        }
    }
}
