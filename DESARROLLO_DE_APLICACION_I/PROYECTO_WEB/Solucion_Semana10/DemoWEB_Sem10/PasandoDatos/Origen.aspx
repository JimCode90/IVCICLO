<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Origen.aspx.cs" Inherits="DemoWEB_Sem10.PasandoDatos.Origen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
        <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
            .auto-style2 {
                height: 30px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">


    <p class="tituloForm">Ejemplo de pase de datos entre formularios</p>
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Ingrese nombre:</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="TextBox"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Ingrese apellido:</td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="TextBox"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2">
                <asp:Button ID="btnEnviar1" runat="server" CssClass="boton2" OnClick="btnEnviar1_Click" Text="Con QueryString" />
            </td>
            <td class="auto-style2">
                <asp:Button ID="btnEnviar2" runat="server" CssClass="boton2" OnClick="btnEnviar2_Click" Text="Con variables de sesión" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
        </tr>
    </table>


</asp:Content>
