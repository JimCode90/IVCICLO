<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="TestDescargar.aspx.cs" Inherits="DemoWEB_Sem10.DemoFileUpLoad.TestDescargar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class ="tituloForm">
        Descargar archivos posteados</p>
    <p class ="tituloForm">
        <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
    </p>
    <p class ="tituloForm">
        <asp:GridView ID="grvArchivos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnRowCommand="grvArchivos_RowCommand" Width="609px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="NombreArchivo" HeaderText="Archivos" />
                <asp:ButtonField CommandName="Descargar" Text="Descargar" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </p>
    <p class ="tituloForm">
        &nbsp;</p>


</asp:Content>
