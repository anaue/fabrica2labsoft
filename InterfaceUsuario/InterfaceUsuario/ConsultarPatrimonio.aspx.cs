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

                ddlTipoPatrimonio.DataSource = new Classes.TipoPatrimonio().ListaTipoPatrimonio();
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

            grvAtributos.DataSource = patrimonio;
            grvAtributos.DataBind();
            panAtributos.Visible = true;
            panResultados.Visible = false;

            VisualizarParaConsulta(patrimonio);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = (Classes.Patrimonio)Session["patrimonio"];
            VisualizarParaEditar(patrimonio);
        }

        protected void btnBaixa_Click(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = (Classes.Patrimonio)Session["patrimonio"];
            Response.Redirect("DarBaixa.aspx?IdEquipamento=" + patrimonio.IdEquipamento + "&NPece=" + patrimonio.NumeroPECE);
        }

        protected void btnManutencao_Click(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = (Classes.Patrimonio)Session["patrimonio"];
            Classes.Manutencao m;
            Response.Redirect("DarManutencao.aspx?IdEquipamento=" + patrimonio.IdEquipamento + "&NPece=" + patrimonio.NumeroPECE);
        }

        void VisualizarParaConsulta(Classes.Patrimonio patrimonio)
        {
            for (int i = 0; i < patrimonio.ListAtributos.Count; i++)
            {
                Label lblValor = (Label)grvAtributos.Rows[i].FindControl("txtValor");
                DropDownList ddlValor = (DropDownList)grvAtributos.Rows[i].FindControl("ddlValor");
                TextBox txtValor = (TextBox)grvAtributos.Rows[i].FindControl("txtValor");
                txtValor.Visible = false;
                ddlValor.Visible = false;
                lblValor.Visible = true;
                lblValor.Text = patrimonio.ListAtributos[i].Valor;
            }
        }

        void VisualizarParaEditar(Classes.Patrimonio patrimonio)
        {
            for (int i = 0; i < patrimonio.ListAtributos.Count; i++)
            {
                Label lblValor = (Label)grvAtributos.Rows[i].FindControl("txtValor");
                TextBox txtValor = (TextBox)grvAtributos.Rows[i].FindControl("txtValor");
                DropDownList ddlValor = (DropDownList)grvAtributos.Rows[i].FindControl("ddlValor");
                PlaceHolder phValidators = (PlaceHolder)grvAtributos.Rows[i].FindControl("phValidators");
                RequiredFieldValidator rfv = new RequiredFieldValidator();
                RegularExpressionValidator rev = new RegularExpressionValidator();
                lblValor.Visible = false;
                switch (patrimonio.ListAtributos[i].Tipo)
                {
                    case "Texto":
                        if (!patrimonio.ListAtributos[i].Nulo)
                        {
                            rfv.ControlToValidate = "txtValor";
                            rfv.ErrorMessage = patrimonio.ListAtributos[i].Nome + " é necessário.";
                            rfv.Text = "*";
                            rfv.ValidationGroup = "Patrimonio";
                            phValidators.Controls.Add(rfv);
                        }
                        txtValor.Text = patrimonio.ListAtributos[i].Valor;
                        txtValor.Visible = true;
                        ddlValor.Visible = false;
                        break;
                    case "Decimal":
                        if (!patrimonio.ListAtributos[i].Nulo)
                        {
                            rfv.ControlToValidate = "txtValor";
                            rfv.ErrorMessage = patrimonio.ListAtributos[i].Nome + " é necessário.";
                            rfv.Text = "*";
                            rfv.ValidationGroup = "Patrimonio";
                            phValidators.Controls.Add(rfv);
                        }
                        rev.ValidationExpression = "^[-+]?\\d+(\\,\\d+)?$";
                        rev.ControlToValidate = "txtValor";
                        rev.ErrorMessage = "Formato Inválido, utilize 9999,99 para " + patrimonio.ListAtributos[i].Nome;
                        rev.Text = "*";
                        rev.ValidationGroup = "Patrimonio";
                        phValidators.Controls.Add(rev);
                        txtValor.Text = patrimonio.ListAtributos[i].Valor;
                        txtValor.Visible = true;
                        ddlValor.Visible = false;
                        break;
                    case "Data":
                        if (!patrimonio.ListAtributos[i].Nulo)
                        {
                            rfv.ControlToValidate = "txtValor";
                            rfv.ErrorMessage = patrimonio.ListAtributos[i].Nome + " é necessário.";
                            rfv.Text = "*";
                            rfv.ValidationGroup = "Patrimonio";
                            phValidators.Controls.Add(rfv);
                        }
                        rev.ValidationExpression = "(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)\\d\\d";
                        rev.ControlToValidate = "txtValor";
                        rev.ErrorMessage = "Formato Inválido, utilize dd/MM/aaaa para " + patrimonio.ListAtributos[i].Nome;
                        rev.Text = "*";
                        rev.ValidationGroup = "Patrimonio";
                        phValidators.Controls.Add(rev);
                        txtValor.Text = patrimonio.ListAtributos[i].Valor;
                        txtValor.Visible = true;
                        ddlValor.Visible = false;
                        break;
                    case "Lista":
                        ddlValor.SelectedItem.Text = patrimonio.ListAtributos[i].Valor;
                        txtValor.Visible = false;
                        ddlValor.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = (Classes.Patrimonio)Session["patrimonio"];

            for (int i = 0; i < patrimonio.ListAtributos.Count; i++)
            {
                Classes.Atributo inserindoAtributo = new Classes.Atributo();
                TextBox txtValor = (TextBox)grvAtributos.Rows[i].FindControl("txtValor");
                DropDownList ddlValor = (DropDownList)grvAtributos.Rows[i].FindControl("ddlValor");

                switch (patrimonio.ListAtributos[i].Tipo)
                {
                    case "Texto":
                        if ((patrimonio.ListAtributos[i].Nulo) && (txtValor.Text == ""))
                            patrimonio.ListAtributos[i].Valor = "";
                        else
                            patrimonio.ListAtributos[i].Valor = txtValor.Text;
                        break;
                    case "Decimal":
                        if ((patrimonio.ListAtributos[i].Nulo) && (txtValor.Text == ""))
                            patrimonio.ListAtributos[i].Valor = (0).ToString();
                        else
                            patrimonio.ListAtributos[i].Valor = (Convert.ToDecimal(txtValor.Text.Replace(',', '.'))).ToString();
                        break;
                    case "Data":
                        if ((!patrimonio.ListAtributos[i].Nulo) && (txtValor.Text == ""))
                            patrimonio.ListAtributos[i].Valor = (new DateTime()).ToString();
                        else
                            patrimonio.ListAtributos[i].Valor = (new DateTime(Convert.ToInt32(txtValor.Text.Split('/')[2]), Convert.ToInt32(txtValor.Text.Split('/')[1]), Convert.ToInt32(txtValor.Text.Split('/')[0]))).ToString();
                        break;
                    case "Lista":
                        patrimonio.ListAtributos[i].Valor = ddlValor.SelectedItem.Text;
                        break;
                    default:
                        break;
                }
            }

            //for (int i = patrimonio.ListAtributos.Count; i > (patrimonio.ListAtributos.Count - 7); i--)
            //{
            //    // adiciono nos atributos comuns do patrimonio
            //    switch (patrimonio.ListAtributos[i].Nome)
            //    {
            //        case "NPECE":
            //            patrimonio.NumeroPECE = Convert.ToInt32(patrimonio.ListAtributos[i].Valor);
            //            break;
            //        case "Data de Compra":
            //            patrimonio.DtCompra = Convert.ToDateTime(patrimonio.ListAtributos[i].Valor);
            //            break;
            //        case "Nota Fiscal":
            //            patrimonio.NumeroNotaFiscal = Convert.ToInt32(patrimonio.ListAtributos[i].Valor);
            //            break;
            //        case "Exp. Garantia":
            //            patrimonio.DtExpGarantia = Convert.ToDateTime(patrimonio.ListAtributos[i].Valor);
            //            break;
            //        case "Foto Nota Fiscal":
            //            patrimonio.CaminhoFotoNotaFiscal = patrimonio.ListAtributos[i].Valor;
            //            break;
            //        case "Foto Patrimonio":
            //            patrimonio.CaminhoFotoPatrimonio = patrimonio.ListAtributos[i].Valor;
            //            break;
            //        case "Local":
            //            patrimonio.LocalPatrimonio = patrimonio.ListAtributos[i].Valor;
            //            break;
            //        case "Id Solicitacao":
            //            patrimonio.NumeroPedido = patrimonio.ListAtributos[i].Valor;
            //            break;
            //        default:
            //            break;
            //    }
            //    patrimonio.ListAtributos.RemoveAt(i);
            //}
            patrimonio.ListAtributos = patrimonio.ListAtributos;
            try
            {
                patrimonio.AlteraPatrimonio(patrimonio);
            }
            catch (Exception ex)
            {
                Response.Redirect("PaginaDeErro.aspx?Acao=Alterar Patrimonio&Msg=" + ex.Message);
            }
            Response.Redirect("PaginaDeSucesso.aspx?Acao=Alterar Patrimonio&Msg=Patrimônio Nº" + patrimonio.NumeroPECE);
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = (Classes.Patrimonio)Session["patrimonio"];
            patrimonio.DeletaPatrimonio(patrimonio.IdEquipamento);
        }

        protected void grvAtributos_DataBound(object sender, EventArgs e)
        {

        }
    }
}
