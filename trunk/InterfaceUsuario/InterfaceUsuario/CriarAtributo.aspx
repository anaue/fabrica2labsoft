<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CriarAtributo.aspx.cs" Inherits="InterfaceUsuario.CriarAtributo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="formulario">
     <table style="width:100%;">
         <tr>
             <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td style="width: 12px">
                 &nbsp;</td>
             <td class="texto_titulo">
                 Criar Atributos</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
     </table>
<hr />
        <br />
        <table>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 87px">
                    Nome:</td>
                <td style="width: 623px">
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:TextBox ID="txtNome" runat="server" Width="141px" style="margin-left: 0px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtNome" ErrorMessage="Nome é Necessário." 
                        ValidationGroup="Atributo">*</asp:RequiredFieldValidator>
            </span></span></span></span>
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 87px">
                    Descrição:</td>
                                                    <td style="width: 623px">
                                                        <asp:TextBox ID="txtDescricao" runat="server" Width="285px"></asp:TextBox>
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                            ControlToValidate="txtDescricao" ErrorMessage="Descrição é Necessária." 
                                                            ValidationGroup="Atributo">*</asp:RequiredFieldValidator>
            </span></span></span></span>
                                                    </td>
                                                </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 87px">
                                                        Nulo:</td>
                                                    <td style="width: 623px">
            <asp:CheckBox ID="cbNulo" runat="server" SkinID="cbPadrao" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 12px">
                                                        &nbsp;</td>
                                                    <td style="width: 87px">
                                                        Tipo:</td>
                                                    <td style="width: 623px">
                                                        <asp:DropDownList ID="ddlTipo" runat="server" Width="125px" AutoPostBack="True" 
                                                            onselectedindexchanged="ddlTipo_SelectedIndexChanged">
                                                            <asp:ListItem>Texto</asp:ListItem>
                                                            <asp:ListItem Value="Decimal">Decimal</asp:ListItem>
                                                            <asp:ListItem>Data</asp:ListItem>
                                                            <asp:ListItem>Lista</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 12px">
                                                        &nbsp;</td>
                                                    <td colspan="2" valign="middle">
                                                        <asp:Panel ID="panLista" runat="server" Visible="False">
                                                            <table>
                                                                <tr>
                                                                    <td class="style49" style="width: 87px" valign="middle">
                                                                        Lista:</td>
                                                                    <td class="style48" valign="middle" style="width: 127px">
                                                                        <asp:TextBox ID="txtValorLista" runat="server" Width="109px"></asp:TextBox>
                                                                        <span style="font-family: Verdana"><span style="font-size: x-small">
                                                                        <span style="font-size: small"><span style="color: #3F3F3F">
                                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                            ControlToValidate="txtValorLista" ErrorMessage="Valor Vazio." 
                                                                            ValidationGroup="Lista">*</asp:RequiredFieldValidator>
                                                                        </span></span></span></span>
                                                                    </td>
                                                                    <td style="width: 59px; text-align: center">
                                                                        <asp:Button ID="btnAdicionar" runat="server" Text="&gt;&gt;" 
                                                                            onclick="btnAdicionar_Click" ValidationGroup="Lista" Width="35px" />
                                                                        <br />
                                                                        <asp:Button ID="Button2" runat="server" Text="X" Width="35px" 
                                                                            onclick="Button2_Click" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ListBox ID="lbValores" runat="server" Width="127px" Height="98px"></asp:ListBox>
                                                                    </td>
                                                                    <td>
                                                                        <span style="font-family: Verdana"><span style="font-size: x-small">
                                                                        <span style="font-size: small"><span style="color: #3F3F3F">
                                                                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                                                                            ValidationGroup="Lista" />
                                                                        </span></span></span></span>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </td>
                                                </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 87px">
                    &nbsp;</td>
                <td style="width: 623px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="Cadastrar" 
                onclick="Button1_Click" SkinID="btnPadrao" Width="137px" 
                        ValidationGroup="Atributo" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ValidationGroup="Atributo" />
                </td>
            </tr>
        </table>
     <br />
</div>
</asp:Content>


