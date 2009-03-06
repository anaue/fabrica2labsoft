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
    public partial class DarBaixa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNPece.Text = Request.QueryString["NPece"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] != null)
            {
                Classes.Baixa baixa = new Classes.Baixa();
                Classes.Patrimonio patrimonio = new InterfaceUsuario.Classes.Patrimonio();
                patrimonio = patrimonio.ConsultaPatrimonio(Convert.ToInt32(Request.QueryString["IdEquipamento"]));
                baixa.DestinoBaixa = txtDestino.Text;
                baixa.DtBaixa = DateTime.Now;
                baixa.ObservacoesBaixa = txtObservacao.Text;
                baixa.IdUsuario = (int)Session["IdUsuario"];
                patrimonio.BaixaPatrimonio(baixa);
            }
        }
    }
}
