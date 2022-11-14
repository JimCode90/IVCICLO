<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="TestRangeValidator.aspx.cs" Inherits="DemoWEB_Sem10.DemoValidaciones.TestRangeValidator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style3 {
            width: 157px;
            height: 22px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style6 {
            height: 22px;
            width: 293px;
        }
        .auto-style7 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 29px;
        }
        .auto-style8 {
            width: 293px;
            height: 29px;
        }
        .auto-style9 {
            height: 29px;
        }
        .auto-style10 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        <br />
        Ejemplo de RangeValidator</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">Ingrese nota1:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtN1" runat="server" Width="50px"></asp:TextBox>
&nbsp;
                
            </td>
            <td class="auto-style9">
                
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Ingrese nota2:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtN2" runat="server" Width="50px"></asp:TextBox>
&nbsp;
                
            </td>
            <td class="auto-style4">
                
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Ingrese nota3:</td>
            <td class="auto-style8">
                <asp:TextBox ID="txtN3" runat="server" Width="50px"></asp:TextBox>
&nbsp;
                
            </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style6">
                <asp:Button ID="btnCalcular" runat="server"  Text="Calcular" />
            </td>
            <td class="auto-style4">
                <asp:Label ID="lblPromedio" runat="server" CssClass="labelContenido"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
