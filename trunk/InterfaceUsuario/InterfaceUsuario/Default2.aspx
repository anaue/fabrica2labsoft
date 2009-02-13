<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td style="font-family: Verdana; font-size: 11pt;
            font-weight: bold;
            color: #4D7F9A;>
                Cadastro de Equipamento</td>
        </tr>
        <tr>
            <td style="width: 12px">
                Cadastro de Equipamentos</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td style="font-family: Verdana; font-size: 11pt;
            font-weight: bold;
            color: #4D7F9A;>
                Cadastro de Equipamento</td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <hr />
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
                <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="243px" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Computador</asp:ListItem>
                    <asp:ListItem>Telefone</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
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
            <td colspan="2">
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table style="width:100%;">
                        <tr>
                            <td style="font-family: Verdana; font-size: small; color: #3F3F3F; width: 109px">
                                NPece</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="138px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-family: Verdana; font-size: small; color: #3F3F3F; width: 109px">
                                Marca</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="138px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-family: Verdana; font-size: small; color: #3F3F3F; width: 109px">
                                Processador</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="138px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-family: Verdana; font-size: small; color: #3F3F3F; width: 109px">
                                Memoria</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" Width="138px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-family: Verdana; font-size: small; color: #3F3F3F; width: 109px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="font-family: Verdana; font-size: small; color: #3F3F3F">
                                <asp:Button ID="Button1" runat="server" Text="Salvar" Width="137px" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
    </table>
    
</asp:Content>

