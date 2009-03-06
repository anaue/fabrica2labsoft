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
             <td class="texto_titulo">
                 Filtro</td>
             <td>
                 &nbsp;</td>
         </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 87px">
                    Nome:</td>
                <td style="width: 623px">
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:TextBox ID="txtNomeFiltro" runat="server" Width="141px" style="margin-left: 0px"></asp:TextBox>
            </span></span></span></span>
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td style="width: 87px">
                    Descrição:</td>
                                                    <td style="width: 623px">
                                                        <asp:TextBox ID="txtDescricaoFiltro" runat="server" Width="285px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 12px">
                                                        &nbsp;</td>
                                                    <td style="width: 87px">
                                                        Tipo:</td>
                                                    <td style="width: 623px">
                                                        <asp:DropDownList ID="ddlTipoAtributoFiltro" runat="server" Width="125px">
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
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" 
                onclick="btnPesquisar_Click" SkinID="btnPadrao" Width="137px" 
                        ValidationGroup="Atributo" />
                </td>
            </tr>
        </table>
        <hr />
        <table style="width:100%;">
          
         <tr>
             <td style="width: 12px; height: 22px;">
                 </td>
             <td class="texto_titulo" style="height: 22px">
                 Resultado</td>
             <td style="height: 22px">
                 </td>
         </tr>
         
         <tr> 
            <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 Nome:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:DropDownList ID="ddlNomeResultados" runat="server" AutoPostBack="True" 
                     onselectedindexchanged="ddlNomeResultados_SelectedIndexChanged" Width="141px">
                 </asp:DropDownList>
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr> 
            <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 Descrição:&nbsp;&nbsp;&nbsp;
                 <asp:TextBox ID="txtDescricao" runat="server" Width="285px"></asp:TextBox>
             </td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr> 
            <td style="width: 12px">
                 &nbsp;</td>
             <td>
                 Tipo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:DropDownList ID="ddlTipoAtributo" 
                     runat="server" Width="125px" AutoPostBack="True" 
                     onselectedindexchanged="ddlTipoPatrimonio_SelectedIndexChanged">
                                                            <asp:ListItem>Texto</asp:ListItem>
                                                            <asp:ListItem Value="Decimal">Decimal</asp:ListItem>
                                                            <asp:ListItem>Data</asp:ListItem>
                                                            <asp:ListItem>Lista</asp:ListItem>
                                                        </asp:DropDownList>
         <asp:Panel ID="panLista" runat="server" Visible="True">
         <table style="width:100%;">
            <tr>
                                                                    <td class="style49" style="width: 87px" valign="middle">
                                                                        Lista:</td>
                                                                    <td class="style48" valign="middle" style="width: 127px">
                                                                        <asp:TextBox ID="txtValorLista" runat="server" Width="109px"></asp:TextBox>
                                                                    </td>
                                                                    <td style="width: 59px; text-align: center">
                                                                        <asp:Button ID="btnAdicionar" runat="server" Text="&gt;&gt;" 
                                                                            onclick="btnAdicionar_Click" ValidationGroup="Lista" Width="35px" />
                                                                        <br />
                                                                        <asp:Button ID="Button2" runat="server" Text="X" Width="35px" 
                                                                            onclick="Button2_Click" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:ListBox ID="lstValores" runat="server" Width="127px" Height="98px"></asp:ListBox>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
       </table>
       </asp:Panel>
                                                    </td>
             <td>
                 &nbsp;</td>
         </tr>
       </table>
       <table style="width:100%;">
       <tr> 
            <td style="width: 12px">
                 &nbsp;</td>
             <td style="width: 195px">
                 
                 <asp:Button ID="btnAlterar" runat="server" onclick="btnAlterar_Click" 
                     Text="Alterar" />
                 
             </td>
             <td>
                 <asp:Button ID="btnExcluir" runat="server" onclick="btnExcluir_Click" 
                     Text="Excluir" />
            </td>
         </tr>
         <tr> 
            <td style="width: 12px">
                 &nbsp;</td>
             <td style="width: 195px">
                 
             </td>
             <td>
                 &nbsp;</td>
         </tr>
       </table>
     <br />
</div>
</asp:Content>
