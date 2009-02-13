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
        <table style="width: 100%;">
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 82px">
                    Nome:</td>
                <td>
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:TextBox ID="txtNome" runat="server" Width="141px" style="margin-left: 0px"></asp:TextBox>
            </span></span></span></span>
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 82px">
                    Descrição:</td>
                                                    <td>
                                                        <asp:TextBox ID="txtDescricao" runat="server" Width="285px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 12px">
                                                        &nbsp;</td>
                                                    <td style="width: 82px">
                                                        Tipo:</td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlTipo" runat="server" Width="125px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 12px">
                                                        &nbsp;</td>
                                                    <td style="width: 82px">
                                                        Lista:</td>
                                                    <td>
                                                        <asp:ListBox ID="ListBox1" runat="server" Width="127px"></asp:ListBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 12px">
                                                        &nbsp;</td>
                                                    <td style="width: 82px">
                                                        Nulo:</td>
                <td>
            <asp:CheckBox ID="cbNulo" runat="server" SkinID="cbPadrao" />
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 82px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="Cadastrar" 
                onclick="Button1_Click" SkinID="btnPadrao" Width="137px" />
                </td>
            </tr>
        </table>
     <br />
</div>
</asp:Content>


