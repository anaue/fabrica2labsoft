using System;
using System.Collections.Generic;
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
            //Classes.Atributo atributo = new InterfaceUsuario.Classes.Atributo();
            //atributo.Nome = txtNome.Text;
            //atributo.Descricao = txtDescricao.Text;
            //atributo.Tipo = ddlTipo.SelectedValue.ToString();
            //atributo.Nulo = cbNulo.Checked;

            if (ddlTipo.SelectedValue == "Lista")
            {
                List<string> str = new List<string>(lbValores.Items.Count);

                foreach (ListItem item in lbValores.Items)
                {
                    str.Add(item.Text);
                }
            }
        }

        protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipo.SelectedValue == "Lista")
            {
                panLista.Visible = true;
            }
            else
            {
                panLista.Visible = false;
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            lbValores.Items.Add(txtValorLista.Text);
            txtValorLista.Text = "";
            txtValorLista.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (lbValores.SelectedIndex > -1)
            {
                lbValores.Items.RemoveAt(lbValores.SelectedIndex);
            }
        }
}
}
