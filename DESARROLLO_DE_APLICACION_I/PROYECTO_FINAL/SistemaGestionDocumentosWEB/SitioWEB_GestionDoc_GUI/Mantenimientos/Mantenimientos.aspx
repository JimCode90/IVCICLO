<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Mantenimientos.aspx.cs" Inherits="SitioVentasWEB_GUI.Mantenimientos.Mantenimientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="Server">
    <table>
        <p class="tituloForm">MANTENIMIENTOS DE TABLAS MAESTRAS </p>
        <tr>
            <td width="180px">
                <asp:Image ID="Image1" runat="server" Height="285px"
                    ImageUrl="~/Images/Mantenimientos.jpg" Width="248px" />
            </td>
            <td>
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="WindowsHelp">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
                    <Nodes>
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/WebMantEspecie.aspx" Text="Especies" Value="Especies"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="1px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
            </td>
        </tr>
    </table>


</asp:Content>

