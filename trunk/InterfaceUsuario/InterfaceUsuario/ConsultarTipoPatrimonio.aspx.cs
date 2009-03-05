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
    public partial class ConsultarTipoPatrimonio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cboNomeTipoPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNomeTipoPatrimonio.SelectedIndex != 0)
            {
                try
                {
                    Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
                    tipoPatrimonio = tipoPatrimonio.ConsultaTiposPatrimonio(cboNomeTipoPatrimonio.SelectedIndex);
                    txtNome.Text = tipoPatrimonio.Nome;
                    txtDescricao.Text = tipoPatrimonio.Descricao;
                }
                catch (Exception ex)
                {
 
                }
 
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
            tipoPatrimonio.Nome = txtNome.Text;
            tipoPatrimonio.Descricao = txtDescricao.Text;
            tipoPatrimonio.Id = cboNomeTipoPatrimonio.SelectedIndex;
            tipoPatrimonio.AlteraTipoPatrimonio(tipoPatrimonio);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {

        }

 
    }
}
