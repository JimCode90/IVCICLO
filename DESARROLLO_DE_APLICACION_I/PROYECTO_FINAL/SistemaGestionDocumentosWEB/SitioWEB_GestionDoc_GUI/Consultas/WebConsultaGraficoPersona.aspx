<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebConsultaGraficoPersona.aspx.cs" Inherits="SitioWEB_GestionDoc_GUI.Consultas.WebConsultaGraficoPersona" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
            margin-right: 0px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm" align="center">Gráfico de Consultas de personas registradas por año</p>
    <p class="tituloForm">
        <asp:Label ID="lblMensajes" runat="server" CssClass="labelErrores"></asp:Label>
    </p>
    <p class="tituloForm">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
    </p>
<table class="auto-style1">
    <tr>
        <td align="center">
            <asp:GridView ID="grvPersonas" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" AutoGenerateColumns="False" CssClass="GriedView">
                <Columns>
                    <asp:BoundField DataField="Año" HeaderText="Año">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CantPersonas" HeaderText="Total">
                    <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                </Columns>
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
        </td>
    </tr>
    <tr  align="center">
        <td>
            <asp:Chart ID="grafCantidades" runat="server">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
                <Titles>
                    <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 14pt, style=Bold" Name="Title1" Text="Total de Personas por año">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </td>
    </tr>
</table>
</asp:Content>
