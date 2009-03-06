<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="consultarUsuario.aspx.cs" Inherits="InterfaceUsuario.WebForm1" Title="Untitled Page" %>
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
            <td style="width: 171px; font-size: small; color: #3F3F3F;font-family: Verdana;">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="font-size: small; color: #3F3F3F;">
                <asp:Button ID="ButtonFiltra" onclick="Button_filtra" runat="server" Text="Filtrar" />
            </td>
        </tr>
        
        
        <tr>
            <td style="width: 12px">
                &nbsp;</td>
             </tr>
        </table>
     <table border="0px" style="width:100%; font-size: small; color: #3F3F3F;font-family: Verdana;">
        <tr>
       
            <td style="width: 171px">
                <asp:GridView ID="gvUsuarios" runat="server" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" Width="806px" Height="141px">
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#E3EAEB" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#4D7F9A" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
             </tr>
             
             </table>
        
           
   


</asp:Content>
