<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="CadastrarPatrimonio.aspx.cs" Inherits="InterfaceUsuario.CadastrarPatrimonio" %>

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
                 Cadastrar Patrimônio</td>
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
                    Selecione o Tipo de patrimônio:</td>
                <td style="width: 12px" class="style48">
                    &nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlTipoPatrimonio" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlTipoPatrimonio_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
        <br />
     <br />
        <asp:Panel ID="panAtributos" runat="server">
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
</div>
</asp:Content>


