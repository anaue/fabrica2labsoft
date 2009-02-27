<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InterfaceUsuario.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            height: 108px;
        }
        .style2
        {
            height: 237px;
        }
        .style4
        {
            height: 237px;
            width: 289px;
            text-align: center;
        }
        .style5
        {
            height: 108px;
            width: 289px;
        }
        .style6
        {
            width: 289px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1">
                </td>
                <td class="style5">
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td class="style2">
                </td>
                <td class="style4">
                    <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
                        BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                        Font-Size="0.8em" ForeColor="#333333" Width="236px">
                        <TextBoxStyle Font-Size="0.8em" />
                        <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                            BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                        <LayoutTemplate>
                            <table border="0" cellpadding="4" cellspacing="0" 
                                style="border-collapse:collapse;">
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" style="width:277px; height: 128px;">
                                            <tr>
                                                <td align="center" colspan="2" 
                                                    style="color:White;background-color:#5D7B9D;font-size:0.9em;font-weight:bold;">
                                                    Sistema de Patrimônio do PECE</td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" 
                                                        SkinID="lblPadraoPequeno">Usuário:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em" Width="95px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                        ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                                        ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" 
                                                        SkinID="lblPadraoPequeno">Senha:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password" 
                                                        Width="95px"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                        ControlToValidate="Password" ErrorMessage="Password is required." 
                                                        ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2" style="color:Red;">
                                                    <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" colspan="2">
                                                    <asp:Button ID="LoginButton" runat="server" BackColor="#FFFBFF" 
                                                        BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" 
                                                        Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" SkinID="btnPadrao" 
                                                        Text="Log In" ValidationGroup="Login1" Width="60px" 
                                                        onclick="LoginButton_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                        <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
                            ForeColor="White" />
                    </asp:Login>
                </td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
