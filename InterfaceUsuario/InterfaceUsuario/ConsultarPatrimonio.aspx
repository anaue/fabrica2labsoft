<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="ConsultarPatrimonio.aspx.cs" Inherits="InterfaceUsuario.ConsultarPatrimonio" %>

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
                 Consultar Patrimônio</td>
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
                <td>
                    NPece:</td>
                <td style="width: 12px" class="style48">
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtValor0" runat="server" Width="74px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td>
                    Tipo de Patrimônio:    <td style="width: 12px" class="style48">
                    &nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlTipoPatrimonio" runat="server" 
                        onselectedindexchanged="ddlTipoPatrimonio_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td>
                    Nota Fiscal:</td>
                <td style="width: 12px" class="style48">
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtValor1" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 12px">
                    &nbsp;</td>
                <td>
                    Id Solicitação</td>
                <td style="width: 12px" class="style48">
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="txtValor2" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            </table>
        <br />
        <asp:Panel ID="panAtributos" runat="server" Visible="False">
            <table>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 12px;">
                    </td>
                    <td>
                        <asp:GridView ID="grvAtributos" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="Id" ondatabound="grvAtributos_DataBound" ShowHeader="False" 
                            SkinID="grvPadrao">
                            <Columns>
                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Nome") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <table style="width: 100%; height: 100%; background-color: #ECF1F4;">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label2" runat="server" SkinID="lblPadraoMedio" 
                                                        Text='<%# Bind("Nome") %>'></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                    <ItemStyle Width="125px" />
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:TextBox ID="txtValor" runat="server" Width="200px"></asp:TextBox>
                                        <asp:DropDownList ID="ddlValor" runat="server" 
                                            DataSource='<%# Bind("Lista") %>' Width="200px">
                                        </asp:DropDownList>
                                        <asp:PlaceHolder ID="phValidators" runat="server"></asp:PlaceHolder>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Descricao") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" SkinID="lblPadraoPequeno" 
                                            Text='<%# Bind("Descricao") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnCadastrar" runat="server" onclick="btnCadastrar_Click" 
                            SkinID="btnPadrao" Text="Cadastrar" ValidationGroup="Patrimonio" 
                            Width="137px" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                            ValidationGroup="Patrimonio" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
     <br />
</div>
</asp:Content>


