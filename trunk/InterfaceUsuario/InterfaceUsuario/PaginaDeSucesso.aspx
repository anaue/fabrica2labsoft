<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="PaginaDeSucesso.aspx.cs" Inherits="InterfaceUsuario.PaginaDeSucesso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="formulario">
    
    <div style="text-align: left" class="formulario">
        <span><strong><span style="font-size: 12pt">&nbsp; Confirmação</span></strong><br />
            <hr/>
            <br />
            &nbsp; &nbsp;&nbsp;
        A ação
        </span>
        <asp:Label ID="lblAcao" runat="server" Font-Bold="True"></asp:Label>
        <span>&nbsp;foi realizada com sucesso!<br />
        </span>
        <br />
        &nbsp; &nbsp;&nbsp;
        <asp:Label ID="lblMsg" runat="server" ForeColor="#5D7B9D" SkinID="lblGreen" 
            Font-Bold="True"></asp:Label><br />
        <br /><hr/>
        &nbsp;</div>
    
    </div>
</asp:Content>

