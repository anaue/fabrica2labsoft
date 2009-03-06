<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="CadastrarTipoPatrimonio.aspx.cs" Inherits="InterfaceUsuario.CadastrarTipoPatrimonio" %>
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
                 Cadastrar Tipo Patrimonio</td>
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

     <table style="height: 19px; width: 828px;">
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 Nome&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="txtNome" runat="server" 
                     Width="141px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                     ErrorMessage="Nome é Necessário." ValidationGroup="Atributo" 
                     ControlToValidate="txtNome">*</asp:RequiredFieldValidator>
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 Descrição&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="txtDescricao" runat="server" Width="285px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                     ErrorMessage="Descrição é necessária" ValidationGroup="Atributo" 
                     ControlToValidate="txtDescricao">*</asp:RequiredFieldValidator>
             </td>
             <td>
                 &nbsp;</td>
         </tr>
    </table>
     <table style="height: 19px; width: 828px;">
     <tr>
                    <td style="text-align: left; font-size: small; color: #3F3F3F; width: 233px;">
                        <span style="font-family: Verdana; font-size: small; color: #3F3F3F">
                        Atributos Disponíveis</span><br 
                            style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:ListBox ID="lstAtributosDisponiveis" runat="server" Height="135px" 
                            Width="233px" 
                            onselectedindexchanged="lstAtributosDisponiveis_SelectedIndexChanged">
                        </asp:ListBox>
                        </span></span></span></span>
                    </td>
                    <td style="width: 125px; text-align: center">
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:Button ID="btnRemoverAtributos" runat="server" Text="<<" 
                            onclick="btnRemoverAtributos_Click" />
                        </span></span></span></span>
                        <br style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:Button ID="btnAdicionarAtributo" runat="server" Text=">>" 
                            onclick="btnAdicionarAtributo_Click" />
                        </span></span></span></span>
                    </td>
                    <td valign="top">
                        <span style="font-family: Verdana; font-size: small; color: #3F3F3F">Atributos 
                        Adicionados</span><br 
                            style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:ListBox ID="lstTipoPatrimonioAtributo" runat="server" Height="135px" 
                            Width="233px">
                        </asp:ListBox>
                        </span></span></span></span></td>
                </tr>
     <tr>
         <td style="width: 233px">
             &nbsp;</td>
         <td>
             <asp:Button ID="btnCadastrarTipoPatrimonio" runat="server" 
                 onclick="CadastrarTipoPatrimonio_Click" Text="Cadastrar" />
         </td>
         <td>
             &nbsp;</td>
     </tr>
     </table>
     <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
         ValidationGroup="Atributo" />
 </div>
</asp:Content>
