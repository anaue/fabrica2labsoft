<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="PaginaDeErro.aspx.cs" Inherits="InterfaceUsuario.PaginaDeErro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="formulario">
    
    <div style="text-align: left" class="formulario">
        <span><strong><span style="font-size: 12pt">&nbsp; Erro</span></strong>
            <hr/>
            <br />
            &nbsp; &nbsp;&nbsp;&nbsp; Erro na ação
        </span>
        <asp:Label ID="lblAcao" runat="server" Font-Bold="True"></asp:Label>. A ação
        foi cancelada.<br />
        <br />
        &nbsp; &nbsp;&nbsp;
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" SkinID="lblGreen" 
            Font-Bold="True"></asp:Label><br />
        <br /><hr/>
        &nbsp;</div>
    
    </div>
</asp:Content>
