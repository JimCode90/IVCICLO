<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebGraficosPersonas.aspx.cs" Inherits="SitioWEB_GestionDoc_GUI.Consultas.WebGraficosPersonas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">Gráfico de personas registradas por año</p>
    <br />
    <br />
        <table width="1000px">
            <tr>
                <td class="labelContenido" >Ingrese Numero de Placa:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtNroPlaca" runat="server" CssClass="TextBoxDerecha" MaxLength="9" Width="70px"></asp:TextBox>
                &nbsp;
                    <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnBuscar_Click" style="width: 16px" CausesValidation="False"  />
                </td>
                <td class="auto-style4">
                    </td>
                <td class="auto-style4">
                    </td>
            </tr>
            <tr>
                <td class="labelContenido">Modelo:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtModelo" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="labelContenido">Color:</td>
                <td>
                    <asp:TextBox ID="txtColor" runat="server" CssClass="TextBoxDerecha" Width="299px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            </table>
</asp:Content>
