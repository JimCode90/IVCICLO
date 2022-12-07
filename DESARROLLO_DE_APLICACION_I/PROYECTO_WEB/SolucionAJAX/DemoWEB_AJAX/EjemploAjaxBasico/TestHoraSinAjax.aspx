<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="TestHoraSinAjax.aspx.cs" Inherits="DemoWEB_AJAX.EjemploAjaxBasico.TestHoraSinAjax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">Ejemplo de carga con AJAX</p>
    <p class="tituloForm">
        <asp:TextBox ID="TextBox1" runat="server" Width="352px"></asp:TextBox>
    </p>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:TextBox ID="TextBox2" runat="server" Width="354px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnMostrar" runat="server" Text="Button" CssClass="boton-new" OnClick="btnMostrar_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
