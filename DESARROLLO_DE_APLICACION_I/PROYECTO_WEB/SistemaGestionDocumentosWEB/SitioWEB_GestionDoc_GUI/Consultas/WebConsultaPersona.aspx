<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebConsultaPersona.aspx.cs" Inherits="SitioWEB_GestionDoc_GUI.Consultas.WebConsultaPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 27px;
        }
        .auto-style4 {
            text-align: center;
            height: 27px;
        }
        .auto-style5 {
            width: 171px;
        }
        .auto-style6 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 27px;
            width: 171px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        <br />
        CONSULTA DE PERSONAS POR NUMERO DE DNI</p>
    <table width="1000px">
        <tr>
            <td class="labelContenido" >Ingrese DNI:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtDni" runat="server" CssClass="TextBoxDerecha" MaxLength="9" Width="70px"></asp:TextBox>
            &nbsp;
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnBuscar_Click" style="width: 16px" CausesValidation="False"  />
            </td>
            <td class="auto-style4">
                </td>
            <td class="auto-style4">
                </td>
        </tr>
        <tr>
            <td class="labelContenido">Nombres:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtNombres" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido">Apellidos:</td>
            <td>
                <asp:TextBox ID="txtApellidos" runat="server" CssClass="TextBoxDerecha" Width="299px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Edad:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtEdad" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido">Dirección:</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Tipo de Documento:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtTipoDocumento" runat="server" CssClass="TextBoxDerecha" Width="298px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido">Genero:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtGenero" runat="server" CssClass="TextBoxDerecha" Width="298px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Tipo Persona</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtTipoPersona" runat="server" CssClass="TextBoxDerecha" Width="294px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido">Nacionalidad</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="TextBoxDerecha" Width="298px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Estado</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtEstado" runat="server" CssClass="TextBoxDerecha" Width="294px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="labelContenido">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
       
        <tr>
            <td colspan="3">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
           <%--Este es el modal popup  que contiene los mensajes --%>
                <%--1 Control target (cualquier control)--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%--2 el panel que se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="center"> 
                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table>
                  <div>
                      <br />
                  </div>
                    <div> 
                        <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo"  /> 
                    </div> 
                  <div>
                       <br />
                  </div>
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" CssClass="boton-new" /> 
                    </div> 
                   <div>
                       <br />
                  </div>
                </asp:Panel> 
         <%--3 el Modal popup que hace referencia al control target  (1) y al panel (2)--%>
                <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />

</asp:Content>

