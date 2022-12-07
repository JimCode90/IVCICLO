<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestMenu.aspx.cs" Inherits="DemoWEB_Sem09.TestMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p class="text-center" style="font-size: x-large">
        <strong>Menu Principal Semana 9
    </strong>
    </p>
    <table style="width: 80%">
        <tr>
            <td style="width: 359px">Ir a Acceso a datos</td>
            <td style="width: 329px">
                <asp:HyperLink ID="Hyp01" runat="server" NavigateUrl="~/TestAccesoDatos.aspx">Ejemplo acceso a datos</asp:HyperLink>
            </td>
            <td rowspan="5">
                <asp:Image ID="imgLogo" runat="server" Height="89px" ImageUrl="~/Imagenes/logo_isil_principal.jpg" Width="333px" />
            </td>
        </tr>
        <tr>
            <td style="width: 359px">Ir a Test Número</td>
            <td style="width: 329px">
                <asp:HyperLink ID="Hyp02" runat="server" NavigateUrl="~/TestClaseNumero.aspx">Ejemplo clase numero</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td style="width: 359px">Ir a Planillas</td>
            <td style="width: 329px">
                <asp:HyperLink ID="Hyp03" runat="server" NavigateUrl="~/TestPlanilla.aspx">Ejemplo planillas</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td style="width: 359px">Vistar ISIL</td>
            <td style="width: 329px">
                <asp:Button ID="btnIrISIL" runat="server" PostBackUrl="https://isilmas.isil.pe/" Text="Visitar ISIL" />
            </td>
        </tr>
        <tr>
            <td style="width: 359px">Visitar Google</td>
            <td style="width: 329px">
                <asp:LinkButton ID="lnkbGoogle" runat="server" PostBackUrl="https://www.google.com/">Visitar Google</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
