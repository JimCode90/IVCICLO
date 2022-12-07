<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="TestFileUpload.aspx.cs" Inherits="DemoWEB_Sem10.DemoFileUpLoad.TestFileUpload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
     <p class="tituloForm">Ejemplos del control FileUpload</p>
    <p class="labelTitulo">Validando la extensión</p>
    <p class="labelTitulo">
        <asp:FileUpload ID="ful1" runat="server" />
&nbsp;
        <asp:Button ID="btnEnviar1" runat="server" CssClass="boton" OnClick="btnEnviar1_Click" Text="Enviar" />
    </p>
    <p class="labelTitulo">
        <asp:Label ID="lblMensaje1" runat="server" CssClass="labelErrores"></asp:Label>
    </p>
    <p class="labelTitulo">Validando la extensión</p>
    <p class="labelTitulo">
        <asp:FileUpload ID="ful2" runat="server" />
&nbsp;
        <asp:Button ID="btnEnviar2" runat="server" CssClass="boton" OnClick="btnEnviar2_Click" Text="Enviar" />
    </p>
    <p class="labelTitulo">
        <asp:Label ID="lblMensaje2" runat="server" CssClass="labelErrores"></asp:Label>
    </p>
    <p class="labelTitulo">Validando la extensión</p>
    <p class="labelTitulo">
        <asp:FileUpload ID="ful3" runat="server" />
&nbsp;
        <asp:Button ID="btnEnviar3" runat="server" CssClass="boton" OnClick="btnEnviar3_Click" Text="Enviar" />
    </p>
    <p class="labelTitulo">
        <asp:Label ID="lblMensaje3" runat="server" CssClass="labelErrores"></asp:Label>
    </p>
</asp:Content>
