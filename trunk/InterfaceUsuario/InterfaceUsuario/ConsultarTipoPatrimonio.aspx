<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="ConsultarTipoPatrimonio.aspx.cs" Inherits="InterfaceUsuario.ConsultarTipoPatrimonio" %>
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
                 Consultar Tipo Patrimonio</td>
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
             <td style="width: 12px">
                 &nbsp;</td>
             <td class="texto_titulo">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 Filtro </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 nome&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:DropDownList ID="cboNomeTipoPatrimonio" runat="server" Width="200px" 
                     onselectedindexchanged="cboNomeTipoPatrimonio_SelectedIndexChanged">
                 </asp:DropDownList>
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         
    </table>
<hr />
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
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 Resultado Pesquisa</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 nome&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="txtNome" runat="server" Width="141px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                     ErrorMessage="Nome é necessário" ValidationGroup="Atributo">*</asp:RequiredFieldValidator>
                                                    </td>
             <td>
                 &nbsp;</td>
         </tr>
          <tr>
             <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 descrição&nbsp;&nbsp;&nbsp;&nbsp;                  <asp:TextBox ID="txtDescricao" runat="server" Width="285px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                     ErrorMessage="Descrição é Necessária." ValidationGroup="Atributo">*</asp:RequiredFieldValidator>
              </td>
             <td>
                 &nbsp;</td>
         </tr>
         </table>
         <table style="height: 19px; width: 828px;">
     <tr>
                    <td style="text-align: left; font-size: small; color: #3F3F3F; height: 155px; width: 117px;">
                        <span style="font-family: Verdana; font-size: small; color: #3F3F3F">
                        Atributos do Tipo</span><br 
                            style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:ListBox ID="lstAtributosDoTipo" runat="server" Height="135px" 
                            Width="233px" 
                            onselectedindexchanged="lstAtributosDisponiveis_SelectedIndexChanged">
                        </asp:ListBox>
                        </span></span></span></span>
                    </td>
                    <td style="width: 208px; text-align: center; height: 155px;">
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:Button ID="btnAdicionarAtributos" runat="server" Text="<<" 
                            onclick="btnAdicionarAtributos_Click" />
                        </span></span></span></span>
                        <br style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:Button ID="btnRemoverAtributos" runat="server" Text=">>" 
                            onclick="btnRemoverAtributos_Click" />
                        </span></span></span></span>
                    </td>
                    <td valign="top" style="height: 155px">
                        <span style="font-family: Verdana; font-size: small; color: #3F3F3F">Atributos 
                        Disponiveis</span><br 
                            style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                        <span style="font-family: Verdana"><span style="font-size: x-small">
                        <span style="font-size: small"><span style="color: #3F3F3F">
                        <asp:ListBox ID="lstAtributosDisponiveis" runat="server" Height="135px" 
                            Width="233px" style="margin-left: 0px">
                        </asp:ListBox>
                        </span></span></span></span></td>
                </tr>
     <tr>
         <td style="width: 117px">
                 <asp:Button ID="btnAlterar" runat="server" onclick="btnAlterar_Click" 
                     Text="Alterar" Width="230px" />
         </td>
         <td style="width: 208px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         </td>
         <td>
                 <asp:Button ID="btnDeletar" runat="server" onclick="btnDeletar_Click" 
                     Text="Deletar" Width="231px" style="margin-left: 0px" />
         </td>
     </tr>
    </table>
         <table style="width:100%;">
            
         </table>
         
 </div>
</asp:Content>
