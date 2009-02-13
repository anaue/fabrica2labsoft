<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master"  CodeFile="Default.aspx.cs" Inherits="_Default" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="formulario">

    Texto padrão do Formulário<br />
    <hr />
    <br />
    <b>CSS<br />
    <br />
    </b>
    <table>
        <tr>
            <td class="texto_titulo" style="height: 116px">
                texto_titulo</td>
            <td class="texto_padrao" style="height: 116px">
                texto_padrao</td>
            <td class="header_titulo_fundo" style="height: 116px">
                header_titulo_fundo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="principal_fundo" style="width: 212px; height: 116px">
                principal_fundo</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    SKIN FILES (Os controles com SkinId nao ficam com as caracteristicas do skinfile em 
        design mode, só em run-mode. Isso acontece pois esta página está dentro de um 
        div com uma css class. Rode o programa para visualizar)<br />
    <br />
    <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" SkinID="lblTitulo" Text="lblTitulo"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="lblPadraoPequeno" 
                    SkinID="lblPadraoPequeno"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="lblPadraoMedio" 
                    SkinID="lblPadraoMedio"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="lblPadraoGrande" 
                    SkinID="lblPadraoGrande"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton7" runat="server" SkinID="lnkPadrao">lnkPadrao</asp:LinkButton>
            </td>
            <td>
                                <asp:LinkButton ID="LinkButton6" runat="server" SkinID="lnkMenu">lnkMenu</asp:LinkButton>
                                </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="btnPadrao" 
                    Width="99px" SkinID="btnPadrao" />
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" SkinID="ddlPadrao" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" SkinID="cbPadrao" />
            </td>
            <td>
                                <asp:RadioButton ID="RadioButton1" runat="server" SkinID="rbPadrao" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
        <br />
        
        <asp:GridView ID="GridView1" runat="server" SkinID="grvPadrao">
        </asp:GridView>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" 
            SkinID="dtvPadrao" Width="125px">
        </asp:DetailsView>
        
    <br />

</div>
</asp:Content>
