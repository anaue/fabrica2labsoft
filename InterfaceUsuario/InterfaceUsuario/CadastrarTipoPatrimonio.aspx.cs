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
using System.Collections.Generic;
using InterfaceUsuario.Classes;

namespace InterfaceUsuario
{
    public partial class CadastrarTipoPatrimonio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstAtributosDisponiveis.DataSource = new InterfaceUsuario.Classes.TipoPatrimonio().ListaAtributosDisponiveis();
                lstAtributosDisponiveis.DataValueField = "Id";
                lstAtributosDisponiveis.DataTextField = "Nome";
                lstAtributosDisponiveis.DataBind();
            
           }
        }

        protected void CadastrarTipoPatrimonio_Click(object sender, EventArgs e)
        {

            Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
            tipoPatrimonio.Nome = txtNome.Text;
            tipoPatrimonio.Descricao = txtDescricao.Text;
            List<Atributo> listaAtributos = new List<Atributo>();

            foreach (ListItem item in lstTipoPatrimonioAtributo.Items)
	        {
		        tipoPatrimonio.ListAtributos.Add(new Atributo(Convert.ToInt32(item.Value)));
	        }
            //Rotina de Efetivacao de dados

            if( tipoPatrimonio.CriaTipoPatrimonio() >0)
                Response.Redirect("PaginaDeSucesso.aspx?Acao=Cadastrar TipoPatrimonio&Msg=TipoPatrimonio" + txtNome.Text);
            else
                Response.Redirect("PaginaDeErro.aspx?Acao=Cadastrar TipoPatrimonio&Msg=Ocorreu um erro na criação do tipo patrimonio");
            

        }

        protected void btnAdicionarAtributo_Click(object sender, EventArgs e)
        {
            if (lstAtributosDisponiveis.SelectedIndex != -1)
            {                
                lstTipoPatrimonioAtributo.Items.Add(new ListItem(lstAtributosDisponiveis.SelectedItem.Text, lstAtributosDisponiveis.SelectedValue));
                lstTipoPatrimonioAtributo.DataValueField = "Id";
                lstTipoPatrimonioAtributo.DataTextField = "Nome";
                lstAtributosDisponiveis.Items.RemoveAt(lstAtributosDisponiveis.SelectedIndex);
                lstAtributosDisponiveis.DataBind();
            }

        }

        protected void btnRemoverAtributos_Click(object sender, EventArgs e)
        {
            if (lstTipoPatrimonioAtributo.SelectedIndex != -1)
            {
                lstAtributosDisponiveis.Items.Add(new ListItem(lstTipoPatrimonioAtributo.SelectedItem.Text, lstTipoPatrimonioAtributo.SelectedValue));
                lstAtributosDisponiveis.DataValueField = "Id";
                lstAtributosDisponiveis.DataTextField = "Nome";
                lstTipoPatrimonioAtributo.Items.RemoveAt(lstTipoPatrimonioAtributo.SelectedIndex);
                lstAtributosDisponiveis.DataBind();
            }

        }

        protected void lstAtributosDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
