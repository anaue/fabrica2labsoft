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
    public partial class DarManutencao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNPece.Text = Request.QueryString["NPece"];
        }

        protected void btnManutencao_Click(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] != null)
            {
                Classes.Manutencao manutencao = new Classes.Manutencao();
                Classes.Patrimonio patrimonio = new InterfaceUsuario.Classes.Patrimonio();

                patrimonio = patrimonio.ConsultaPatrimonio(Convert.ToInt32(Request.QueryString["IdEquipamento"]));
                manutencao.DtManutencao = DateTime.Now;
                manutencao.IdPatrimonio = Convert.ToInt32(Request.QueryString["IdEquipamento"]);
                manutencao.IdUsuario = (int)Session["IdUsuario"];
                manutencao.Motivo = txtMotivo.Text;
                manutencao.Observacao = txtObservacao.Text;

                patrimonio.ColocaManutencao(manutencao);
            }
        }
    }
}
