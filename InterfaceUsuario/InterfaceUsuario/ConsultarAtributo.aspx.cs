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
using InterfaceUsuario.Classes;
using System.Web.UI.MobileControls;
using System.Collections.Generic;

namespace InterfaceUsuario
{
    public partial class ConsultarAtributo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtNomeFiltro.Text != "" || txtNomeFiltro.Text != "" || ddlTipoAtributoFiltro.SelectedIndex != -1)
            {
                Atributo AtributoPesquisar = new Atributo();
                List<Atributo> listAtributo = AtributoPesquisar.BuscaAtributos(txtNomeFiltro.Text, txtNomeFiltro.Text, ddlTipoAtributoFiltro.DataTextField, false, new List<String>(), "");
                ddlNomeResultados.DataSource = listAtributo;
                ddlNomeResultados.DataTextField = "Nome";
                ddlNomeResultados.DataValueField = "Id";
                ddlNomeResultados.DataSource = listAtributo;
                ddlNomeResultados.DataBind();
            }

        }

        protected void ddlNomeResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlNomeResultados.SelectedIndex != -1)
            {
                Atributo atributoPesquisado = new Atributo();
                atributoPesquisado = atributoPesquisado.ConsultaAtributo(Convert.ToInt32(ddlNomeResultados.SelectedValue.ToString()));
                txtDescricao.Text = atributoPesquisado.Descricao;
                ddlTipoAtributo.SelectedValue = atributoPesquisado.Tipo;
                if (atributoPesquisado.Tipo == "Lista")
                {
                    lstValores.DataSource = atributoPesquisado.ListaValores;
                    lstValores.DataBind();
                
                }
             }
        }
        protected void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        protected void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        protected void ddlTipoPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoAtributo.SelectedValue == "Lista")
            {
                panLista.Visible = true;
                Atributo atributoPesquisado = new Atributo();
                atributoPesquisado = atributoPesquisado.ConsultaAtributo(Convert.ToInt32(ddlNomeResultados.SelectedValue.ToString()));
                lstValores.DataSource = atributoPesquisado.ListaValores;
                lstValores.DataBind();
            }
            else
            {
                panLista.Visible = false;
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstValores.Items.Add(txtValorLista.Text);
            txtValorLista.Text = "";
            txtValorLista.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (lstValores.SelectedIndex > -1)
            {
                lstValores.Items.RemoveAt(lstValores.SelectedIndex);
            }
        }

}
}
