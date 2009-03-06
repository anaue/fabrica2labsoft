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
    public partial class cadastraUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_cadastra(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = TextBoxNome.Text;
            usuario.Senha = TextBoxSenhaConf.Text;
            usuario.Descricao = TextBoxDescricao.Text;
            if(CheckBox1.Checked) usuario.TipoUsuario = 1;

            if (usuario.CriaUsuario(usuario) > 0)
            Response.Redirect("PaginaDeSucesso.aspx?Acao=Cadastrar Usuário&Msg=Cadastrado com sucesso");
            else
                Response.Redirect("PaginaDeErro.aspx?Acao=Cadastrar Usuário&Msg=Ocorreu um erro no cadastramento do usuário");

        }

    }

}
