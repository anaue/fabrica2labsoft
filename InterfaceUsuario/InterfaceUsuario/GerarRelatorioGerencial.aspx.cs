using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class CriaRelatorioGerencial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Classes.TipoPatrimonio> lstTipoPatrimonio;
                Classes.TipoPatrimonio objTipoPatrimonio = new Classes.TipoPatrimonio();

                lstTipoPatrimonio = objTipoPatrimonio.ListaTipoPatrimonio();

                foreach (Classes.TipoPatrimonio tipoPatrimonio in lstTipoPatrimonio)
                {
                    ddlTipoPatrimonio.Items.Add(new ListItem(tipoPatrimonio.Nome, tipoPatrimonio.Id.ToString()));
                }

                txtValor.Visible = false;
                ddlFiltro.Visible = false;
                ddlValor.Visible = false;
            }
        }

        protected void ddlTipoEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoPatrimonio.SelectedValue == "sem")
            {
                //PREENCHO OS CAMPOS COMUNS
            }
            else
            {
                // PREENCHO OS CAMPOS COMUNS + CAMPOS DO TIPO
                List<Classes.Atributo> lstAtributos;
                Classes.TipoPatrimonio objTipoPatrimonio = new Classes.TipoPatrimonio();

                lstAtributos = objTipoPatrimonio.ListaAtributos(Convert.ToInt32(ddlTipoPatrimonio.SelectedValue));

                ddlAtributo.Items.Clear();
                ddlAtributo.Items.Add(new ListItem("Sem filtro por Atributo", "sem"));
                ddlAtributo.Items.Add(new ListItem("NPece", "numeroPece"));
                ddlAtributo.Items.Add(new ListItem("Data de Compra", "DtCompra"));
                ddlAtributo.Items.Add(new ListItem("Nota Fiscal", "numeroNotaFiscal"));
                ddlAtributo.Items.Add(new ListItem("Data Expiração Garantia", "dtExpGarantia "));
                ddlAtributo.Items.Add(new ListItem("Local", "Local"));
                ddlAtributo.Items.Add(new ListItem("Id Solicitacao", "IdSolicitacao"));
                ddlAtributo.Items.Add(new ListItem("----------------", ""));

                foreach (Classes.Atributo atributo in lstAtributos)
                {
                    ddlAtributo.Items.Add(new ListItem(atributo.Nome,atributo.Id.ToString()));
                }
            }
        }

        protected void ddlAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAtributo.SelectedValue == "sem")
            {
                txtValor.Visible = false;
                ddlFiltro.Visible = false;
            }
            else
            {
                ddlFiltro.Visible = true;
                //if ddlTipoEquipamento.SelectedValue  NAO É LISTA
                txtValor.Visible = true;
                ddlValor.Visible = false;
                //else
                //txtValor.Visible = false;
                //ddlFiltro.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }


    }
}
