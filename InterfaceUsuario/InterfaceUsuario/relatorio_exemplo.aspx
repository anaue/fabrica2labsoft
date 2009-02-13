<%@ Page Language="C#" MasterPageFile="~/relatorio.master" AutoEventWireup="true" CodeFile="relatorio_exemplo.aspx.cs" Inherits="relatorio_exemplo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="panRelatorio" runat="server" Width="700px"><hr />
           <center><table>
                <tr>
                    <td align="center">
                        <strong><span style="font-size: 16pt">Formulário de Cotação</span></strong></td>
                </tr>
            </table></center>
            <hr />
            <br />
            <table>
                <tr>
                    <td valign="top" style="width: 769px">
                        <asp:Panel ID="panDadosGerais" runat="server" Width="700px">
                            <table>
                                <tr>
                                    <td colspan="5" style="border-top-color: black; border-right-color: black; border-left: black thin solid; border-bottom: black thin solid;">
                                        &nbsp;<strong><span style="border-left-color: black; border-bottom-color: black; border-top-color: black; border-right-color: black;">SOLICITAÇÃO
                                            Nº</span></strong><asp:Label ID="lblID"
                                            runat="server" Font-Bold="True"></asp:Label></td>
                                </tr>
                            </table>
                            <br /><table style="width: 700px">
                                <tr>
                                    <td style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid">
                                        <strong>U.N. :</strong></td>
                                    <td style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid">
                                        <asp:Label ID="lblUnidadeNegocio" runat="server"></asp:Label></td>
                                    <td style="border-right: black thin solid; border-top: black thin solid; border-left: black thin solid; border-bottom: black thin solid" colspan="2">
                                        <strong>Tipo de Solicitação:<br />
                                        </strong>
                                            <asp:RadioButton ID="rbdMateriais" runat="server" Font-Bold="False" Text="Materiais" />&nbsp;&nbsp;
                                        <asp:RadioButton ID="rbdServicos" runat="server" Font-Bold="False" Text="Serviços" />&nbsp;&nbsp;
                                            <asp:RadioButton ID="rbdOutros" runat="server" Font-Bold="False" Text="Outros" /></td>
                                </tr>
                            </table>
                            <hr style="font-size: 12pt" />
            <table>
                <tr>
                    <td colspan="5" style="border-top-color: black; border-right-color: black; border-left: black thin solid; border-bottom: black thin solid;">
                        <strong>&nbsp;Itens</strong></td>
                </tr>
            </table>
                            <asp:GridView ID="grvItens" runat="server" AutoGenerateColumns="False" SkinID="relatorioSemEspaco">
                            <Columns>
                                <asp:BoundField DataField="id_item" HeaderText="ID" >
                                    <ItemStyle Width="10px" BorderStyle="Solid" BorderWidth="1px" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="Item N.&#186;">
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="id_projeto" HeaderText="Projeto">
                                    <ItemStyle HorizontalAlign="Center" Width="100px" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="curso" HeaderText="Curso">
                                    <ItemStyle HorizontalAlign="Left" Width="170px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="quantidade" HeaderText="Qtde">
                                    <ItemStyle HorizontalAlign="Center" Width="50px" />
                                    <HeaderStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="descricao" HeaderText="Descri&#231;&#227;o">
                                    <ItemStyle HorizontalAlign="Left" Width="250px" />
                                </asp:BoundField>
                            </Columns>
                        </asp:GridView><hr style="font-size: 12pt" />
                            
                            <br />
                            &nbsp;</asp:Panel>
                        &nbsp;</td>
                </tr>
            </table>
            <span style="font-size: 10pt">
                <br />
                <table style="font-weight: bold; text-align: left">
                    <tr>
                        <td colspan="5" style="border-top-color: black; border-right-color: black; border-left-width: thin; border-left-color: black; border-bottom-width: thin; border-bottom-color: black; width: 300px;">
                            &nbsp;<span style="border-left-color: black; border-bottom-color: black; border-top-color: black; border-right-color: black;"></span></td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; width: 190px;
                            border-top-color: black; border-bottom: black 1px solid; border-right-color: black">
                                        <asp:Label ID="lblSolicitante" runat="server"></asp:Label></td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: 1px;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                                        <asp:Label ID="lblDataSolicitacao" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="5" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 300px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 190px; border-top-color: black; border-right-color: black">
                            Solicitante</td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 300px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 190px; border-top-color: black; border-right-color: black">
                            <br />
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 300px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; width: 190px;
                            border-top-color: black; border-bottom: black 1px solid; border-right-color: black">
                                        <asp:Label ID="lblCompras" runat="server"></asp:Label></td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                                        <asp:Label ID="lblDataCotacao" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="5" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 300px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 190px; border-top-color: black; border-right-color: black">
                            Área Técnica</td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 300px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 190px; border-top-color: black; border-right-color: black">
                            <br />
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="5" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 300px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; width: 190px;
                            border-top-color: black; border-bottom: black 1px solid; border-right-color: black">
                                        <asp:Label ID="lblAprovacao" runat="server"></asp:Label></td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                                        <asp:Label ID="lblDataAprovacao" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="5" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 300px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 190px; border-top-color: black; border-right-color: black">
                            Aprovação</td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 18px; border-top-color: black; border-right-color: black">
                        </td>
                        <td colspan="1" style="border-left-width: thin; border-left-color: black; border-bottom-width: thin;
                            border-bottom-color: black; width: 180px; border-top-color: black; border-right-color: black">
                        </td>
                    </tr>
                </table>
                <br />
            </span>
            <br />
            <hr />
            <center><table>
                <tr>
                    <td align="center">
            São Paulo,
            <asp:Label ID="lblData" runat="server"></asp:Label></td>
                </tr>
            </table></center> 
            <hr />
            </asp:Panel>
</asp:Content>

