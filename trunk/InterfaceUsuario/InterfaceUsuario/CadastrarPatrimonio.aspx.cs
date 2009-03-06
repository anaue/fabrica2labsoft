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
    
    public partial class CadastrarPatrimonio : System.Web.UI.Page
    {
        public List<Classes.Atributo> lstAtributos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlTipoPatrimonio.DataTextField = "Nome";
                ddlTipoPatrimonio.DataValueField = "Id";

                ddlTipoPatrimonio.DataSource = Classes.TipoPatrimonio.ListaTipoPatrimonio();
                ddlTipoPatrimonio.DataBind();
            }
        }

        protected void ddlTipoPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.TipoPatrimonio tipoPatrimonio = new InterfaceUsuario.Classes.TipoPatrimonio();
            lstAtributos = tipoPatrimonio.ListaAtributos(Convert.ToInt32(ddlTipoPatrimonio.SelectedValue));

            Session["lstAtributos"] = lstAtributos;

            lstAtributos.Add(new Classes.Atributo(-1, "NPECE", "", "Decimal", false, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-2, "Data de Compra", "", "Data", false, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-3, "Nota Fiscal", "", "Texto", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-4, "Exp. Garantia", "", "Data", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-5, "Foto Nota Fiscal", "", "Texto", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-6, "Foto Patrimonio", "", "Texto", true, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-7, "Local", "", "Texto", false, new List<string>(), ""));
            lstAtributos.Add(new Classes.Atributo(-8, "Id Solicitacao", "", "Decimal", true, new List<string>(), ""));

            grvAtributos.DataSource = lstAtributos;
            grvAtributos.DataBind();
            panAtributos.Visible = true;
        }

        protected void grvAtributos_DataBound(object sender, EventArgs e)
        {
            Classes.Patrimonio patrimonio = new InterfaceUsuario.Classes.Patrimonio();

            lstAtributos = (List<Classes.Atributo>)Session["lstAtributos"];

            for (int i = 0; i < lstAtributos.Count; i++)
            {
                TextBox txtValor = (TextBox)grvAtributos.Rows[i].FindControl("txtValor");
                DropDownList ddlValor = (DropDownList)grvAtributos.Rows[i].FindControl("ddlValor");
                PlaceHolder phValidators = (PlaceHolder)grvAtributos.Rows[i].FindControl("phValidators");
                RequiredFieldValidator rfv = new RequiredFieldValidator();
                RegularExpressionValidator rev = new RegularExpressionValidator();

                switch (lstAtributos[i].Tipo)
                {
                    case "Texto":
                        if (!lstAtributos[i].Nulo)
                        {
                            rfv.ControlToValidate = "txtValor";
                            rfv.ErrorMessage = lstAtributos[i].Nome + " é necessário.";
                            rfv.Text = "*";
                            rfv.ValidationGroup = "Patrimonio";
                            phValidators.Controls.Add(rfv);
                        }

                        txtValor.Visible = true;
                        ddlValor.Visible = false;
                        break;
                    case "Decimal":
                        if (!lstAtributos[i].Nulo)
                        {
                            rfv.ControlToValidate = "txtValor";
                            rfv.ErrorMessage = lstAtributos[i].Nome + " é necessário.";
                            rfv.Text = "*";
                            rfv.ValidationGroup = "Patrimonio";
                            phValidators.Controls.Add(rfv);
                        }
                        rev.ValidationExpression = "^[-+]?\\d+(\\,\\d+)?$";
                        rev.ControlToValidate = "txtValor";
                        rev.ErrorMessage = "Formato Inválido, utilize 9999,99 para " + lstAtributos[i].Nome;
                        rev.Text = "*";
                        rev.ValidationGroup = "Patrimonio";
                        phValidators.Controls.Add(rev);

                        txtValor.Visible = true;
                        ddlValor.Visible = false;
                        break;
                    case "Data":
                        if (!lstAtributos[i].Nulo)
                        {
                            rfv.ControlToValidate = "txtValor";
                            rfv.ErrorMessage = lstAtributos[i].Nome + " é necessário.";
                            rfv.Text = "*";
                            rfv.ValidationGroup = "Patrimonio";
                            phValidators.Controls.Add(rfv);
                        }
                        rev.ValidationExpression = "(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)\\d\\d";
                        rev.ControlToValidate = "txtValor";
                        rev.ErrorMessage = "Formato Inválido, utilize dd/MM/aaaa para " + lstAtributos[i].Nome;
                        rev.Text = "*";
                        rev.ValidationGroup = "Patrimonio";
                        phValidators.Controls.Add(rev);

                        txtValor.Visible = true;
                        ddlValor.Visible = false;
                        break;
                    case "Lista":
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
            Classes.Patrimonio patrimonio = new Classes.Patrimonio();
            lstAtributos = (List<Classes.Atributo>)Session["lstAtributos"];

            for (int i = 0; i < lstAtributos.Count; i++)
            {
                Classes.Atributo inserindoAtributo = new Classes.Atributo();
                TextBox txtValor = (TextBox)grvAtributos.Rows[i].FindControl("txtValor");
                DropDownList ddlValor = (DropDownList)grvAtributos.Rows[i].FindControl("ddlValor");

                switch (lstAtributos[i].Tipo)
                {
                    case "Texto":
                        if ((lstAtributos[i].Nulo) && (txtValor.Text == ""))
                        {
                            lstAtributos[i].Valor = "";
                        }
                        else
                        {
                            lstAtributos[i].Valor = txtValor.Text;
                        }
                        break;
                    case "Decimal":
                        if ((lstAtributos[i].Nulo) && (txtValor.Text == ""))
                        {
                            lstAtributos[i].Valor = (0).ToString();
                        }
                        else
                        {
                            lstAtributos[i].Valor = (Convert.ToDecimal(txtValor.Text.Replace(',', '.'))).ToString();
                        }
                        break;
                    case "Data":
                        if ((!lstAtributos[i].Nulo) && (txtValor.Text == ""))
                        {
                            lstAtributos[i].Valor = (new DateTime()).ToString();
                        }
                        else
                        {
                            lstAtributos[i].Valor = (new DateTime(Convert.ToInt32(txtValor.Text.Split('/')[2]), Convert.ToInt32(txtValor.Text.Split('/')[1]), Convert.ToInt32(txtValor.Text.Split('/')[0]))).ToString();
                        }
                        break;
                    case "Lista":
                        lstAtributos[i].Valor = ddlValor.SelectedItem.Text;
                        break;
                    default:
                        break;
                }
            }

            for (int i = lstAtributos.Count; i > (lstAtributos.Count - 7); i--)
            {
                // adiciono nos atributos comuns do patrimonio
                switch (lstAtributos[i].Nome)
                {
                    case "NPECE": 
                        patrimonio.NumeroPECE = Convert.ToInt32(lstAtributos[i].Valor);
                        break;
                    case "Data de Compra": 
                        patrimonio.DtCompra = Convert.ToDateTime(lstAtributos[i].Valor);
                        break;
                    case "Nota Fiscal": 
                        patrimonio.NumeroNotaFiscal = Convert.ToInt32(lstAtributos[i].Valor);
                        break;
                    case "Exp. Garantia":
                        patrimonio.DtExpGarantia = Convert.ToDateTime(lstAtributos[i].Valor);
                        break;
                    case "Foto Nota Fiscal":
                        patrimonio.CaminhoFotoNotaFiscal = lstAtributos[i].Valor;
                        break;
                    case "Foto Patrimonio":
                        patrimonio.CaminhoFotoPatrimonio = lstAtributos[i].Valor;
                        break;
                    case "Local": 
                        patrimonio.LocalPatrimonio = lstAtributos[i].Valor;
                        break;
                    case "Id Solicitacao":
                        patrimonio.NumeroPedido = lstAtributos[i].Valor;
                        break;
                    default:
                        break;
                }
                lstAtributos.RemoveAt(i);
            }
            patrimonio.ListAtributos = lstAtributos;
            try
            {
                patrimonio.CriaPatrimonio();
            }
            catch (Exception ex)
            {
                Response.Redirect("PaginaDeErro.aspx?Acao=Cadastrar Patrimonio&Msg=" + ex.Message);
            }
            Response.Redirect("PaginaDeSucesso.aspx?Acao=Cadastrar Patrimonio&Msg=Patrimônio Nº" + patrimonio.NumeroPECE);
        }
    }
}
