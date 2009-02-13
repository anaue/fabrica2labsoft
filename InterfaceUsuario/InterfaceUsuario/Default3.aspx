<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" Title="Untitled Page" %>

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
            Consulta de Equipamentos</td>
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
            <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="243px">
                <asp:ListItem>Computador</asp:ListItem>
                <asp:ListItem>Telefone</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
                &nbsp;</td>
        <td style="width: 233px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Selecione um Filtro por Atributo</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Height="21px" Width="243px">
                <asp:ListItem>Marca</asp:ListItem>
                <asp:ListItem>Processador</asp:ListItem>
                <asp:ListItem>Cor</asp:ListItem>
            </asp:DropDownList>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
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
            <asp:Button ID="Button1" runat="server" Text="Buscar" Width="140px" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

