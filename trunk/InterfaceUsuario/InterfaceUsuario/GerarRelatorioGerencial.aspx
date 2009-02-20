<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master"  CodeBehind="GerarRelatorioGerencial.aspx.cs" Inherits="InterfaceUsuario.CriaRelatorioGerencial" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                 Gerar Relatórios</td>
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
        <table style="width:100%;">
            <tr>
                <td class="style48" style="width: 12px">
                    &nbsp;</td>
                <td style="width: 135px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style48" style="width: 12px">
                    &nbsp;</td>
                                                    <td style="width: 135px">
                                                        Tipo Patrimônio:</td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlTipoPatrimonio" runat="server" AutoPostBack="True" 
                                                            onselectedindexchanged="ddlTipoEquipamento_SelectedIndexChanged" Width="175px">
                                                            <asp:ListItem Value="sem">Sem Filtro por Tipo</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style48" style="width: 12px">
                                                        &nbsp;</td>
                                                    <td style="width: 135px">
                                                        Por Atributo:</td>
                <td>
                    <asp:DropDownList ID="ddlAtributo" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlAtributo_SelectedIndexChanged" Width="175px">
                        <asp:ListItem Value="sem">Sem filtro por Atributo</asp:ListItem>
                        <asp:ListItem>NPece</asp:ListItem>
                        <asp:ListItem>Data de Compra</asp:ListItem>
                        <asp:ListItem>Nota Fiscal</asp:ListItem>
                        <asp:ListItem>Data Expiração Garantia</asp:ListItem>
                        <asp:ListItem>Local</asp:ListItem>
                        <asp:ListItem>Id Solicitacao</asp:ListItem>
                        <asp:ListItem>----------------</asp:ListItem>
                    </asp:DropDownList>
&nbsp;
                    <asp:DropDownList ID="ddlFiltro" runat="server" Width="42px">
                        <asp:ListItem>=</asp:ListItem>
                        <asp:ListItem>!=</asp:ListItem>
                        <asp:ListItem>&lt;</asp:ListItem>
                        <asp:ListItem>&lt;=</asp:ListItem>
                        <asp:ListItem>&gt;</asp:ListItem>
                        <asp:ListItem>&gt;=</asp:ListItem>
                    </asp:DropDownList>
&nbsp;
                    <asp:TextBox ID="txtValor" runat="server" Enabled="False"></asp:TextBox>
                    <asp:DropDownList ID="ddlValor" runat="server" Height="16px" Width="146px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style48" style="width: 12px">
                    &nbsp;</td>
                <td style="width: 135px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style48" style="width: 12px">
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        SkinID="btnPadrao" Text="Gerar" Width="133px" />
                </td>
            </tr>
        </table>
</div>
</asp:Content>
