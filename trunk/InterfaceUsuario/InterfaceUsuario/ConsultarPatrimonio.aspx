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
        <asp:Panel ID="panFiltros" runat="server">
            <table style="width:100%;">
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td style="width: 233px">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td style="width: 233px; font-family: Verdana; font-size: small; color: #3F3F3F">
                        Selecione o Tipo de Equipamento</td>
                    <td>
                        <asp:DropDownList ID="ddlTipoPatrimonio" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlTipoPatrimonio_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td style="width: 233px; font-family: Verdana; font-size: small; color: #3F3F3F;">
                        Selecione um Filtro por Atributo</td>
                    <td>
                        <asp:DropDownList ID="ddlAtributos" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddlAtributos_SelectedIndexChanged">
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;
                        <asp:DropDownList ID="ddlValores" runat="server">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtDe" runat="server" Width="96px"></asp:TextBox>
                        &nbsp;<asp:Label ID="lblA" runat="server" Text="a"></asp:Label>
                        &nbsp;<asp:TextBox ID="txtA" runat="server" Width="96px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td style="width: 233px; font-family: Verdana; font-size: small; color: #3F3F3F;">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td style="width: 233px; font-family: Verdana; font-size: small; color: #3F3F3F;">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
                     Width="140px" onclick="btnBuscar_Click" SkinID="btnPadrao" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="panResultados" runat="server" Visible="False">
            <table>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td>
                        <asp:GridView ID="grvResultados" runat="server" 
                            onrowediting="grvResultados_RowEditing" DataKeyNames="NPece" 
                            SkinID="grvPadrao">
                            <Columns>
                                <asp:CommandField EditText="Visualizar" ShowEditButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="panAtributos" runat="server" Visible="False">
            <table>
                <tr>
                    <td style="width: 12px">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnEditar" runat="server" onclick="btnEditar_Click" 
                            SkinID="btnPadrao" Text="Editar" Width="83px" />
                        &nbsp;<asp:Button ID="btnDeletar" runat="server" onclick="btnDeletar_Click" 
                            SkinID="btnPadrao" Text="Deletar" Width="83px" />
                        &nbsp;<asp:Button ID="btnBaixa" runat="server" onclick="btnBaixa_Click" 
                            SkinID="btnPadrao" Text="Baixa" Width="83px" />
                        &nbsp;<asp:Button ID="btnManutencao" runat="server" onclick="btnManutencao_Click" 
                            SkinID="btnPadrao" Text="Manutenção" Width="83px" />
                    </td>
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
                                        <asp:Label ID="lblValor" runat="server"></asp:Label>
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
                            SkinID="btnPadrao" Text="Salvar Edição" ValidationGroup="Patrimonio" 
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


