<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ConsultarAtributo.aspx.cs" Inherits="InterfaceUsuario.ConsultarAtributo" Title="Untitled Page" %>
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
                 Consultar Atributos</td>
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
                <td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="Pesquisar" 
                onclick="Button1_Click" SkinID="btnPadrao" Width="137px" 
                        ValidationGroup="Atributo" />
                </td>
            </tr>
        </table>
     <br />
</div>
</asp:Content>
