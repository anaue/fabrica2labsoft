<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CriarAtributo.aspx.cs" Inherits="InterfaceUsuario.CriarAtributo" Title="Untitled Page" %>
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
            Criar Atributo</td>
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
        <td style="font-family: Verdana; font-size: small; color: #3F3F3F" colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Nome</td>
        <td colspan="3">
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:TextBox ID="textBox_nome" runat="server" Width="244px"></asp:TextBox>
            <asp:Label ID="lb_nome" runat="server" ForeColor="#CC3300" 
                Text="* campo obrigatório" Visible="False"></asp:Label>
            </span></span></span></span>
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Tipo</td>
        <td style="width: 241px">
            <span style="font-family: Verdana"><span style="font-size: x-small">
            <span style="font-size: small"><span style="color: #3F3F3F">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                >
                <asp:ListItem>Texto</asp:ListItem>
                <asp:ListItem>Inteiro</asp:ListItem>
                <asp:ListItem>Lista</asp:ListItem>
            </asp:DropDownList>
            </span></span></span></span>
        </td>
        <td style="width: 78px">
            <asp:Label ID="Label2" runat="server" Text="ID-Lista" Visible="False"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" Visible="False">
             <asp:ListItem Selected="True">NONONO1</asp:ListItem>
             <asp:ListItem>NONONO2</asp:ListItem>
            </asp:DropDownList>
                                                </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            Nulo</td>
        <td style="font-family: Verdana; font-size: small; color: #3F3F3F" colspan="3">
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            &nbsp;</td>
        <td style="font-family: Verdana; font-size: small; color: #3F3F3F" colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
        <td style="width: 130px; font-family: Verdana; font-size: small; color: #3F3F3F;">
            &nbsp;</td>
        <td style="font-family: Verdana; font-size: small; color: #3F3F3F" colspan="3">
            <asp:Button ID="Button1" runat="server" Text="Cadastrar" 
                onclick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td style="width: 12px">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>


