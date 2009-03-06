<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="DarBaixa.aspx.cs" Inherits="InterfaceUsuario.DarBaixa" %>
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
                 Dar Baixa</td>
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
                    NPece:</td>
                <td style="width: 623px">
                    <asp:Label ID="lblNPece" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 87px">
                    Destino:</td>
                <td style="width: 623px">
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:TextBox ID="txtDestino" runat="server" Width="141px" style="margin-left: 0px"></asp:TextBox>
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
                    Observações:</td>
                                                    <td style="width: 623px">
                                                        <asp:TextBox ID="txtObservacao" runat="server" Width="285px"></asp:TextBox>
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
            <asp:Button ID="btnDarBaixa" runat="server" Text="Dar Baixa" 
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


