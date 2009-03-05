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
    public partial class ConsultarPatrimonio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();

                ddlTipoPatrimonio.DataTextField = "Nome";
                ddlTipoPatrimonio.DataValueField = "Id";

                ddlTipoPatrimonio.DataSource = tipoPatrimonio.ListaTipoPatrimonio();
                ddlTipoPatrimonio.DataBind();

                ddlAtributos.Items.Add(new ListItem("NPece", "numeroPece"));
                ddlAtributos.Items.Add(new ListItem("Data de Compra", "dtCompra"));
                ddlAtributos.Items.Add(new ListItem("Nota Fiscal", "numeroNotaFiscal"));
                ddlAtributos.Items.Add(new ListItem("Data Exp. Garantia", "dtExpGarantia"));
                ddlAtributos.Items.Add(new ListItem("Local", "local"));
                ddlAtributos.Items.Add(new ListItem("Id Solicitacao", "numeroPedido"));

                txtA.Visible = false;
                txtDe.Visible = false;
                lblA.Visible = false;
                ddlValores.Visible = false;
            }
        }

        protected void ddlTipoPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
            List<Classes.Atributo> lstAtributos = tipoPatrimonio.ListaAtributos(Convert.ToInt32(ddlTipoPatrimonio.SelectedValue));

            ddlAtributos.Items.Clear();
            ddlAtributos.Items.Add(new ListItem("NPece", "numeroPece"));
            ddlAtributos.Items.Add(new ListItem("Data de Compra", "dtCompra"));
            ddlAtributos.Items.Add(new ListItem("Nota Fiscal", "numeroNotaFiscal"));
            ddlAtributos.Items.Add(new ListItem("Data Exp. Garantia", "dtExpGarantia"));
            ddlAtributos.Items.Add(new ListItem("Local", "local"));
            ddlAtributos.Items.Add(new ListItem("Id Solicitacao", "numeroPedido"));
            ddlAtributos.Items.Add(new ListItem("", ""));

            foreach (Classes.Atributo atributo in lstAtributos)
            {
                ddlAtributos.Items.Add(new ListItem(atributo.Nome, atributo.Id.ToString()));
            }
        }

        protected void ddlAtributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlAtributos.SelectedValue.ToString())
            {
                case "numeroPece":
                    txtA.Visible = true;
                    txtDe.Visible = false;
                    lblA.Visible = false;
                    ddlValores.Visible = false;
                    break;
                case "dtCompra":
                    txtA.Visible = true;
                    txtDe.Visible = true;
                    lblA.Visible = true;
                    ddlValores.Visible = false;
                    break;
                case "numeroNotaFiscal":
                    txtA.Visible = true;
                    txtDe.Visible = false;
                    lblA.Visible = false;
                    ddlValores.Visible = false;
                    break;
                case "dtExpGarantia":
                    txtA.Visible = true;
                    txtDe.Visible = true;
                    lblA.Visible = true;
                    ddlValores.Visible = false;
                    break;
                case "local":
                    txtA.Visible = true;
                    txtDe.Visible = false;
                    lblA.Visible = false;
                    ddlValores.Visible = false;
                    break;
                case "numeroPedido":
                    txtA.Visible = true;
                    txtDe.Visible = false;
                    lblA.Visible = false;
                    ddlValores.Visible = false;
                    break;
                default:
                    Classes.Atributo atributo = new Classes.Atributo();
                    atributo = atributo.ConsultaAtributo(Convert.ToInt32(ddlAtributos.SelectedValue))[0];
                    if (atributo.Tipo == "Lista")
                    {
                        txtA.Visible = false;
                        txtDe.Visible = false;
                        lblA.Visible = false;
                        ddlValores.Visible = true;
                    }
                    else
                    {
                        txtA.Visible = true;
                        txtDe.Visible = false;
                        lblA.Visible = false;
                        ddlValores.Visible = false;
                        ddlValores.DataSource = atributo.ListaValores;
                        ddlValores.DataBind();
                    }
                    break;
            }
        }
        void preencheGridViewSomenteAtributosComuns(List<Classes.Patrimonio> lstPatrimonio)
        {
            DataTable objDTResultado = new DataTable();

            //cria colunas de Atributos Comuns
            objDTResultado.Columns.Add(new DataColumn("NPECE", typeof(int)));
            objDTResultado.Columns.Add(new DataColumn("Data de Compra", typeof(DateTime)));
            objDTResultado.Columns.Add(new DataColumn("Nota Fiscal", typeof(int)));
            objDTResultado.Columns.Add(new DataColumn("Data Exp. de Garantia", typeof(DateTime)));
            objDTResultado.Columns.Add(new DataColumn("Foto Nota Fiscal", typeof(string)));
            objDTResultado.Columns.Add(new DataColumn("Foto Patrimonio", typeof(string)));
            objDTResultado.Columns.Add(new DataColumn("Local", typeof(string)));
            objDTResultado.Columns.Add(new DataColumn("Id Solicitação", typeof(int)));

            //preenche a data table com os patrimonios
            foreach (Classes.Patrimonio patrimonio in lstPatrimonio)
            {
                DataRow objDR = objDTResultado.NewRow();
                objDR["NPECE"] = patrimonio.NumeroPECE;
                objDR["Data de Compra"] = patrimonio.DtCompra;
                objDR["Nota Fiscal"] = patrimonio.NumeroNotaFiscal;
                objDR["Data Exp. de Garantia"] = patrimonio.DtExpGarantia;
                objDR["Foto Nota Fiscal"] = patrimonio.CaminhoFotoNotaFiscal;
                objDR["Foto Patrimonio"] = patrimonio.CaminhoFotoPatrimonio;
                objDR["Local"] = patrimonio.LocalPatrimonio;
                objDR["Id Solicitação"] = patrimonio.NumeroPedido;
                objDTResultado.Rows.Add(objDR);
            }
            ArrayList key = new ArrayList();
            key.Add("NPECE");
            //grvResultados.DataKeys = new DataKeyArray(key);
            grvResultados.DataSource = objDTResultado;
            grvResultados.DataBind();
        }
        void preencheGridViewAtributosComunsEspeciais(List<Classes.Patrimonio> lstPatrimonio)
        {
            DataTable objDTResultado = new DataTable();

            //cria colunas de Atributos Comuns
            objDTResultado.Columns.Add(new DataColumn("NPECE", typeof(int)));
            objDTResultado.Columns.Add(new DataColumn("Data de Compra", typeof(DateTime)));
            objDTResultado.Columns.Add(new DataColumn("Nota Fiscal", typeof(int)));
            objDTResultado.Columns.Add(new DataColumn("Data Exp. de Garantia", typeof(DateTime)));
            objDTResultado.Columns.Add(new DataColumn("Foto Nota Fiscal", typeof(string)));
            objDTResultado.Columns.Add(new DataColumn("Foto Patrimonio", typeof(string)));
            objDTResultado.Columns.Add(new DataColumn("Local", typeof(string)));
            objDTResultado.Columns.Add(new DataColumn("Id Solicitação", typeof(int)));

            //cria colunas de atributos Especiais 
            foreach (Classes.Atributo atributo in lstPatrimonio[0].ListAtributos)
            {
                objDTResultado.Columns.Add(new DataColumn(atributo.Nome, typeof(string)));
            }

            //preenche a data table com os patrimonios
            foreach (Classes.Patrimonio patrimonio in lstPatrimonio)
            {
                DataRow objDR = objDTResultado.NewRow();
                objDR["NPECE"] = patrimonio.NumeroPECE;
                objDR["Data de Compra"] = patrimonio.DtCompra;
                objDR["Nota Fiscal"] = patrimonio.NumeroNotaFiscal;
                objDR["Data Exp. de Garantia"] = patrimonio.DtExpGarantia;
                objDR["Foto Nota Fiscal"] = patrimonio.CaminhoFotoNotaFiscal;
                objDR["Foto Patrimonio"] = patrimonio.CaminhoFotoPatrimonio;
                objDR["Local"] = patrimonio.LocalPatrimonio;
                objDR["Id Solicitação"] = patrimonio.NumeroPedido;

                foreach (Classes.Atributo atributo in patrimonio.ListAtributos)
                {
                    objDR[atributo.Nome] = atributo.Valor;
                }
                objDTResultado.Rows.Add(objDR);
            }
            ArrayList key = new ArrayList();
            key.Add("NPECE");
            //grvResultados.DataKeys = new DataKeyArray(key);
            grvResultados.DataSource = objDTResultado;
            grvResultados.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = new InterfaceUsuario.Classes.Patrimonio();
            List<Classes.Patrimonio> lstPatrimonio = new List<InterfaceUsuario.Classes.Patrimonio>();

            switch (ddlAtributos.SelectedValue.ToString())
            {
                case "numeroPece":

                    break;
                case "dtCompra":

                    break;
                case "numeroNotaFiscal":

                    break;
                case "dtExpGarantia":

                    break;
                case "local":

                    break;
                case "numeroPedido":

                    break;
                default:
                    Classes.Atributo atributo = new Classes.Atributo();
                    atributo = atributo.ConsultaAtributo(Convert.ToInt32(ddlAtributos.SelectedValue))[0];

                    break;
            }

            panFiltros.Visible = false;
            panResultados.Visible = true;

            // FAZ A BUSCA
        }

        protected void grvResultados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Classes.Patrimonio patrimonio = new InterfaceUsuario.Classes.Patrimonio();
            Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
            object obj = grvResultados.Rows[e.NewEditIndex].DataItem;

            //patrimonio = patrimonio.buscaPatrimonio(obj)

            List<Classes.Atributo> lstAtributos = tipoPatrimonio.ListaAtributos(Convert.ToInt32(ddlTipoPatrimonio.SelectedValue));

            Session["lstAtributos"] = lstAtributos;

            lstAtributos.Add(new Classes.Atributo(-1, "NPECE", "", "Decimal", false, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-2, "Data de Compra", "", "Data", false, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-3, "Nota Fiscal", "", "Texto", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-4, "Exp. Garantia", "", "Data", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-5, "Foto Nota Fiscal", "", "Texto", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-6, "Foto Patrimonio", "", "Texto", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-7, "Local", "", "Texto", false, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-8, "Id Solicitacao", "", "Decimal", true, new List<string>(), ""));

            //grvAtributos.DataSource = lstAtributos;
            //grvAtributos.DataBind();
            panAtributos.Visible = true;
        }
    }
}
