<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" Title="Untitled Page" %>

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
            Criar Atributos</td>
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
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            &nbsp;</td>
        <td style="font-family: Verdana; font-size: small; color: #3F3F3F">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Atributo</td>
        <td>
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </span></span></span></span>
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Descrição</td>
        <td>
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:TextBox ID="TextBox2" runat="server" Width="378px"></asp:TextBox>
            </span></span></span></span>
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Tipo</td>
        <td>
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Texto</asp:ListItem>
                <asp:ListItem>Inteiro</asp:ListItem>
            </asp:DropDownList>
            </span></span></span></span>
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Nulo</td>
        <td style="font-family: Verdana; font-size: small; color: #3F3F3F">
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

