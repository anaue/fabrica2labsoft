using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InterfaceUsuario
{
    public partial class CriarAtributo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Classes.Atributo atributo = new InterfaceUsuario.Classes.Atributo();
            atributo.Nome = txtNome.Text;
            atributo.Descricao = txtDescricao.Text;
            atributo.Tipo = ddlTipo.SelectedValue.ToString();
            atributo.Nulo = cbNulo.Checked;
            if (atributo.CriaAtributo() < 0)
                lblError.Visible = true;
            else
                lblError.Visible = false; ;
            
                

            

        }


    }
}
