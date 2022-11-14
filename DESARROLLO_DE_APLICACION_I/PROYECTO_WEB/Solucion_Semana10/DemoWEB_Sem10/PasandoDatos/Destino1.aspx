<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Destino1.aspx.cs" Inherits="DemoWEB_Sem10.PasandoDatos.Destino1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
       <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">Recepcionando datos desde la URL</p>
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Nombre obtenido:</td>
            <td class="auto-style2">
                <asp:Label ID="lblNombre" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Apellido obtenido:</td>
            <td>
                <asp:Label ID="lblApellido" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="hypRetornar" runat="server" NavigateUrl="~/PasandoDatos/Origen.aspx">Retornar</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
