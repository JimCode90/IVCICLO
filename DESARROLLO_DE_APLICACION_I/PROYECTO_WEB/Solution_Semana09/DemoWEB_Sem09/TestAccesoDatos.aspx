<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestAccesoDatos.aspx.cs" Inherits="DemoWEB_Sem09.TestAccesoDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Demo Acceso a datos
    </p>
    <table style="width: 80%">
        <tr>
            <td class="modal-sm" style="width: 330px">
                <asp:DropDownList ID="cbo1" runat="server" Width="300px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 330px">Valor seleccionado</td>
            <td>
                <asp:Label ID="lblCod1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 330px">
                <asp:DropDownList ID="cbo2" runat="server" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="cbo2_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 330px">Valor seleccionado</td>
            <td>
                <asp:Label ID="lblCod2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 330px">&nbsp;</td>
            <td>
                <asp:HyperLink ID="hypMenu" runat="server" NavigateUrl="~/TestMenu.aspx">Volver al menú</asp:HyperLink>
            </td>
        </tr>
    </table>

    <asp:GridView ID="grvDatos" Width="900px" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>

</asp:Content>
