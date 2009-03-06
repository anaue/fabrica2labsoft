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
using System.Collections.Generic;

namespace InterfaceUsuario
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            List<Classes.Usuario> users = usuario.BuscaUsuarios(usuario.Nome, "");
            if (!this.IsPostBack)
            {
                atualizaGrid(users);
            }
        }

        private void atualizaGrid(List<Classes.Usuario> users)
        {
            gvUsuarios.Columns.Clear();
            gvUsuarios.DataSource = users;

            gvUsuarios.AutoGenerateColumns = true;

            BoundField bEditarNome = new BoundField();
            bEditarNome.DataField = "Id";
            bEditarNome.DataFormatString = "<a href=\"alteraUsuario.aspx?id={0}\">Editar</a> " ;
            gvUsuarios.Columns.Add(bEditarNome);

            gvUsuarios.DataBind();
        }
        protected void Button_filtra(object sender, EventArgs e)
        {
            
            Usuario usuario = new Usuario();
            usuario.Nome = TextBox1.Text;
            usuario.Id = 34;
            
            List<Classes.Usuario> users = usuario.BuscaUsuarios(usuario.Nome, "");

            users.Add(usuario);

            atualizaGrid(users);

        }
    }
}
