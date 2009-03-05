<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="consultaUsuario.aspx.cs" Inherits="InterfaceUsuario.consultaUsuario" Title="Untitled Page" %>
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
                Consulta de Usuários</td>
        </tr>
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <hr />
    
    
    
    
    <table border="0px" style="width:100%; font-size: small; color: #3F3F3F;font-family: Verdana;">
        
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
            <td style="width: 180px; font-size: small; color: #3F3F3F;font-family: Verdana;">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="font-size: small; color: #3F3F3F;">
                <asp:Button ID="ButtonFiltra" onclick="Button_filtra" runat="server" Text="Filtrar" />
            </td>
        </tr>
        
        
        <tr>
            <td style="width: 12px">
            &nbsp;
            </td>
             </tr>
        <tr >
            <td style="width: 12px">
                &nbsp;</td>
            <td style="width: 180px; " >
                Nome:
            </td>
            <td >
                Descrição:
            </td>
        </tr>
        
         <tr style="background-color: #DDDDDD; line-height:20px;">
            <td style="width: 12px">
                &nbsp;</td>
            <td style="width: 180px;" >
                Marcelão
            </td>
            <td >
                Descrição do Marcelão
            </td>
            <td align="right">
                <asp:Button ID="Button1" runat="server" Text="Consultar" />
                <asp:Button ID="Button2" runat="server" Text="Remover"  />
            </td>
        </tr>

        <tr style=" line-height:20px;">
            <td style="width: 12px">
                &nbsp;</td>
            <td style="width: 180px;" >
                Arbore
            </td>
            <td >
                Descrição do Arbore
            </td>
            <td style="text-align:right;">
                <asp:Button ID="Button3" runat="server" Text="Consultar" />
                <asp:Button ID="Button4" runat="server" Text="Remover"  />
            </td>
        </tr>

    </table>








</asp:Content>
