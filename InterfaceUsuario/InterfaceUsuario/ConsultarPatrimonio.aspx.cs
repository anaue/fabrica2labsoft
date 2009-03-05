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
                ddlTipoPatrimonio.DataTextField = "Nome";
                ddlTipoPatrimonio.DataValueField = "Id";

                ddlTipoPatrimonio.DataSource = Classes.TipoPatrimonio.ListaTipoPatrimonio();
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
                    atributo = atributo.ConsultaAtributo(Convert.ToInt32(ddlAtributos.SelectedValue));
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
            objDTResultado.Columns.Add(new DataColumn("NPece", typeof(int)));
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
                objDR["NPece"] = patrimonio.NumeroPECE;
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
                    atributo = atributo.ConsultaAtributo(Convert.ToInt32(ddlAtributos.SelectedValue));

                    break;
            }

            panFiltros.Visible = false;
            panResultados.Visible = true;

            // FAZ A BUSCA
        }

        protected void grvResultados_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Classes.Patrimonio patrimonio = new InterfaceUsuario.Classes.Patrimonio();
                       object obj = grvResultados.Rows[e.NewEditIndex].DataItem;

            //patrimonio = patrimonio.buscaPatrimonio(obj)

            Session["patrimonio"] = patrimonio;

            VisualizarParaConsulta(patrimonio);

            grvAtributos.DataSource = patrimonio;
            grvAtributos.DataBind();
            panAtributos.Visible = true;
            panResultados.Visible = false;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = (Classes.Patrimonio)Session["patrimonio"];
            VisualizarParaConsulta(patrimonio);
        }

        protected void btnBaixa_Click(object sender, EventArgs e)
        {

        }

        protected void btnManutencao_Click(object sender, EventArgs e)
        {

        }

        void VisualizarParaConsulta(Classes.Patrimonio patrimonio)
        {
            //for (int i = 0; i < lstAtributos.Count; i++)
            //{
            //    Label lblValor = (Label)grvAtributos.Rows[i].FindControl("txtValor");
            //    DropDownList ddlValor = (DropDownList)grvAtributos.Rows[i].FindControl("ddlValor");
            //    TextBox txtValor = (TextBox)grvAtributos.Rows[i].FindControl("txtValor");
            //    txtValor.Visible = false;
            //    ddlValor.Visible = false;
            //    lblValor.Visible = true;

            //}
        }

        void VisualizarParaEditar(Classes.Patrimonio patrimonio)
        {
            //for (int i = 0; i < lstAtributos.Count; i++)
            //{
            //    TextBox txtValor = (TextBox)grvAtributos.Rows[i].FindControl("txtValor");
            //    DropDownList ddlValor = (DropDownList)grvAtributos.Rows[i].FindControl("ddlValor");
            //    PlaceHolder phValidators = (PlaceHolder)grvAtributos.Rows[i].FindControl("phValidators");
            //    RequiredFieldValidator rfv = new RequiredFieldValidator();
            //    RegularExpressionValidator rev = new RegularExpressionValidator();

            //    switch (lstAtributos[i].Tipo)
            //    {
            //        case "Texto":
            //            if (!lstAtributos[i].Nulo)
            //            {
            //                rfv.ControlToValidate = "txtValor";
            //                rfv.ErrorMessage = lstAtributos[i].Nome + " é necessário.";
            //                rfv.Text = "*";
            //                rfv.ValidationGroup = "Patrimonio";
            //                phValidators.Controls.Add(rfv);
            //            }

            //            txtValor.Visible = true;
            //            ddlValor.Visible = false;
            //            break;
            //        case "Decimal":
            //            if (!lstAtributos[i].Nulo)
            //            {
            //                rfv.ControlToValidate = "txtValor";
            //                rfv.ErrorMessage = lstAtributos[i].Nome + " é necessário.";
            //                rfv.Text = "*";
            //                rfv.ValidationGroup = "Patrimonio";
            //                phValidators.Controls.Add(rfv);
            //            }
            //            rev.ValidationExpression = "^[-+]?\\d+(\\,\\d+)?$";
            //            rev.ControlToValidate = "txtValor";
            //            rev.ErrorMessage = "Formato Inválido, utilize 9999,99 para " + lstAtributos[i].Nome;
            //            rev.Text = "*";
            //            rev.ValidationGroup = "Patrimonio";
            //            phValidators.Controls.Add(rev);

            //            txtValor.Visible = true;
            //            ddlValor.Visible = false;
            //            break;
            //        case "Data":
            //            if (!lstAtributos[i].Nulo)
            //            {
            //                rfv.ControlToValidate = "txtValor";
            //                rfv.ErrorMessage = lstAtributos[i].Nome + " é necessário.";
            //                rfv.Text = "*";
            //                rfv.ValidationGroup = "Patrimonio";
            //                phValidators.Controls.Add(rfv);
            //            }
            //            rev.ValidationExpression = "(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)\\d\\d";
            //            rev.ControlToValidate = "txtValor";
            //            rev.ErrorMessage = "Formato Inválido, utilize dd/MM/aaaa para " + lstAtributos[i].Nome;
            //            rev.Text = "*";
            //            rev.ValidationGroup = "Patrimonio";
            //            phValidators.Controls.Add(rev);

            //            txtValor.Visible = true;
            //            ddlValor.Visible = false;
            //            break;
            //        case "Lista":
            //            txtValor.Visible = false;
            //            ddlValor.Visible = true;
            //            break;
            //        default:
            //            break;
            //    }
            //}
        }
    }
}
