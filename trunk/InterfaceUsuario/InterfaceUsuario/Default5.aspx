<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                Cadastro de Tipo de Equipamento</td>
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
            <td style="font-size: small; color: #3F3F3F;">
                <span style="font-family: Verdana"><span style="font-size: small">
                <span style="color: #3F3F3F">Nome&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </span></span></span></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td style="font-size: small; color: #3F3F3F;">
                <span style="font-family: Verdana"><span style="font-size: small">
                <span style="color: #3F3F3F">Descrição&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </span></span></span></td>
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
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td colspan="2">
                <table style="width:100%;">
                    <tr>
                        <td style="text-align: center; font-family: Verdana; font-size: small; color: #3F3F3F;" 
                            colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 31px; text-align: left; font-size: small; color: #3F3F3F;">
                            <span style="font-family: Verdana; font-size: small; color: #3F3F3F">
                            AtributosAdicionados</span><br 
                                style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                            <span style="font-family: Verdana"><span style="font-size: x-small">
                            <span style="font-size: small"><span style="color: #3F3F3F">
                            <asp:ListBox ID="ListBox1" runat="server" Height="135px" Width="233px">
                            </asp:ListBox>
                            </span></span></span></span>
                        </td>
                        <td style="width: 125px; text-align: center">
                            <span style="font-family: Verdana"><span style="font-size: x-small">
                            <span style="font-size: small"><span style="color: #3F3F3F">
                            <asp:Button ID="Button1" runat="server" Text="<<" onclick="Button1_Click" />
                            </span></span></span></span>
                            <br style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                            <span style="font-family: Verdana"><span style="font-size: x-small">
                            <span style="font-size: small"><span style="color: #3F3F3F">
                            <asp:Button ID="Button2" runat="server" Text=">>" />
                            </span></span></span></span>
                        </td>
                        <td valign="top">
                            <span style="font-family: Verdana; font-size: small; color: #3F3F3F">Atributos 
                            Disponiveis</span><br 
                                style="font-family: Verdana; font-size: small; color: #3F3F3F" />
                            <span style="font-family: Verdana"><span style="font-size: x-small">
                            <span style="font-size: small"><span style="color: #3F3F3F">
                            <asp:ListBox ID="ListBox2" runat="server" Height="135px" Width="233px">
                                <asp:ListItem>Marca</asp:ListItem>
                                <asp:ListItem>Modelo</asp:ListItem>
                                <asp:ListItem>Processador</asp:ListItem>
                                <asp:ListItem>Memoria</asp:ListItem>
                                <asp:ListItem>Cor</asp:ListItem>
                                <asp:ListItem>Tamanho</asp:ListItem>
                            </asp:ListBox>
                            </span></span></span></span></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

