<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="SitioVentasWEB_GUI.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 14px;
        }
        .auto-style3 {
            font-size: x-large;
            color: #FF5050;
        }
        .auto-style4 {
            height: 96px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" Runat="Server">
    <p class="auto-style3">
        <strong>MENU PRINCIPAL - SISTEMA DE GESTIÓN DE DOCUMENTOS PNP</strong></p>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" rowspan="3">
                <asp:Image ID="Image1" runat="server" Height="284px" ImageUrl="~/Images/documentos.PNG" Width="311px" />
            </td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Mantenimientos/Mantenimientos.aspx">Mantenimientos</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Consultas</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

