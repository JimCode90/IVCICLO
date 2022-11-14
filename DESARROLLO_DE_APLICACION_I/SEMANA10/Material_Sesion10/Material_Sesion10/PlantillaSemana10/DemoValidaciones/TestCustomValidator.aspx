<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="TestCustomValidator.aspx.cs" Inherits="DemoWEB_Sem10.DemoValidaciones.TestCustomValidator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 92%;
        }
        .auto-style2 {
            width: 253px;
        }
        .auto-style3 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 22px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style5 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        <br />
        Ejemplo de CustomValidator</p>
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Ingrese codigo afiliacion:</td>
            <td>
                <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Ingrese DNI:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
                
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnValidar" runat="server"  Text="Validar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style5">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
