﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="alteraUsuario.aspx.cs" Inherits="InterfaceUsuario.alteraUsuario" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



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
            color: #4D7F9A;">
                Alterar Usuários</td>
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
            <td style="width: 200px; font-size: small; color: #3F3F3F;font-family: Verdana;">
                Nome
            </td>
            <td style="font-size: small; color: #3F3F3F;">
                <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td style="width: 200px; font-size: small; color: #3F3F3F;font-family: Verdana;">
                Senha
            </td>
            <td>
                <asp:TextBox ID="TextBoxSenha" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td style="width: 200px; font-size: small; color: #3F3F3F;font-family: Verdana;">
                Confirme a senha
            </td>
            <td>
                <asp:TextBox ID="TextBoxSenhaConf" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1"  ControlToCompare="TextBoxSenha" ControlToValidate="TextBoxSenhaConf" type="String" Operator="Equal" runat="server" ErrorMessage="Senhas diferentes!"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td style="width: 200px; font-size: small; color: #3F3F3F;font-family: Verdana;">
                Descrição
            </td>
            <td>
                <asp:TextBox ID="TextBoxDescricao" runat="server"></asp:TextBox>
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
                <asp:Button ID="Button1" runat="server" Text="Alterar" onclick="Button_altera" /></td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Limpar" onclick="Button_limpa" /></td>
        </tr>

    </table>


















</asp:Content>
