<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="DemoConfirmButton.aspx.cs" Inherits="DemoWEB_AJAX.EjemploAjaxToolkit.DemoConfirmButton" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p>Demo Control Boton</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
        <ajaxToolkit:ConfirmButtonExtender ID="btnLimpiar_ConfirmButtonExtender" runat="server" BehaviorID="btnLimpiar_ConfirmButtonExtender" ConfirmText="¿Seguro de eliminar el texto?" TargetControlID="btnLimpiar" />
    </p>
</asp:Content>
