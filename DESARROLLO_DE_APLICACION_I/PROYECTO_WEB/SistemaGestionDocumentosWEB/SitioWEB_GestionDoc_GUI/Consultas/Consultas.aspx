<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="SitioVentasWEB_GUI.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" Runat="Server">
    &nbsp;<table >
        <p class="tituloForm">CONSULTAS DEL SISTEMA </p>
        <tr>
            <td class="style2">
                <asp:Image ID="Image1" runat="server" Height="267px" 
                    ImageUrl="~/Images/Consultas.jpg" Width="274px" />
            </td>
            <td>
                
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="WindowsHelp">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
                    <Nodes>
                        <asp:TreeNode Text="Consultas" Value="Consultas">
                            <asp:TreeNode NavigateUrl="~/Consultas/WebConsultaPersona.aspx" Text="Personas" Value="Personas"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/Consultas/WebConsultaVehiculo.aspx" Text="Vehiculos" Value="Vehiculos"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/Consultas/WebConsultaGraficoPersona.aspx" Text="Estadísticas" Value="Estadísticas"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="1px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
                
            </td>
        </tr>
    </table>
&nbsp;
</asp:Content>


