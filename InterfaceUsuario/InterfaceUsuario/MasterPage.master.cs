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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["IdUsuario"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void LinkLogOff_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
    protected void lnkConsultaPatrimonio_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConsultarPatrimonio.aspx");
    }
    protected void lnkCadastroPatrimonio_Click(object sender, EventArgs e)
    {
        Response.Redirect("CadastrarPatrimonio.aspx");
    }
    protected void lnkConsultaTipo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConsultarTipoPatrimonio.aspx");
    }
    protected void lnkCadastraTipo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CadastrarTipoPatrimonio.aspx");
    }
    protected void lnkConsultaAtributo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ConsultarAtributo.aspx");
    }
    protected void lnkCadastraAtributo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CriarAtributo.aspx");
    }
    protected void lnkConsultaUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("consultarUsuario.aspx");
    }
    protected void lnkCadastraUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("cadastraUsuario.aspx");
    }
}
