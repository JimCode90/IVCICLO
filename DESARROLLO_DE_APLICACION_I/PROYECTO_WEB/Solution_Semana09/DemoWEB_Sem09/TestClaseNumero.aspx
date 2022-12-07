<%@ Page Title="Clase numero" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestClaseNumero.aspx.cs" Inherits="DemoWEB_Sem09.TestClaseNumero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <p>
        <strong>
        <br style="font-size: larger" />
        <span style="font-size: larger">Demo Clase Número</span></strong></p>
    <table style="width: 70%">
        <tr>
            <td class="modal-sm" style="width: 203px">Ingrese número:</td>
            <td>
                <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 203px">Su factorial es:</td>
            <td>
                <asp:Label ID="lblFactorial" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 203px">Es primo?</td>
            <td>
                <asp:Label ID="lblPrimo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 203px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 203px">&nbsp;</td>
            <td>
                <asp:HyperLink ID="hypMenu" runat="server" NavigateUrl="~/TestMenu.aspx">Volver al memú</asp:HyperLink>
            </td>
        </tr>
    </table>



</asp:Content>
