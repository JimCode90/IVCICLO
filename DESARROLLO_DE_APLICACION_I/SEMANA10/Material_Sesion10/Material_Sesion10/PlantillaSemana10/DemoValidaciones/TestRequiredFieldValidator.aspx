<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="TestRequiredFieldValidator.aspx.cs" Inherits="DemoWEB_Sem10.DemoValidaciones.TestRequiredFieldValidator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 80%;
    }
    .auto-style2 {
        width: 193px;
    }
    .auto-style3 {
        width: 239px;
    }
        .auto-style4 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 26px;
        }
        .auto-style5 {
            width: 239px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
    <br />
    Ejemplos de RequiredFieldValidator y RegularExpressionValidator</p>
<table class="auto-style1">
    <tr>
        <td class="auto-style4">Ingrese nombre:</td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style6">
            
        </td>
    </tr>
    <tr>
        <td class="labelContenido">Ingrese apellido:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td class="labelContenido">Ingrese direccion:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
           
        </td>
    </tr>
    <tr>
        <td class="auto-style4">Ingrese telefono:</td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style6">
            
        </td>
    </tr>
    <tr>
        <td class="auto-style4">Ingrese Email:</td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style6">
            
        </td>
    </tr>
    <tr>
        <td colspan="3" class="auto-style7">
            <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
            <asp:Button ID="btnGrabar" runat="server"  Text="Grabar" />
        </td>
        <td>
            <asp:Button ID="btnSalir" runat="server"  Text="Salir" CausesValidation="False" />
        </td>
    </tr>
</table>
</asp:Content>
