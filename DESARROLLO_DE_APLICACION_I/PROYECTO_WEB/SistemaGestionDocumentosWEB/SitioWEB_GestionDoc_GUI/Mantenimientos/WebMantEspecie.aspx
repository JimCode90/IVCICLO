<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebMantEspecie.aspx.cs" Inherits="SitioWEB_GestionDoc_GUI.Mantenimientos.WebMantEspecie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
       <style type="text/css">
        .auto-style1 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 36px;
        }
        .auto-style3 {
            width: 70%;
        }
           .auto-style4 {
               width: 409px;
           }
           .auto-style5 {
               font-family: Verdana;
               font-size: 10pt;
               color: #993366;
               height: 36px;
               width: 409px;
           }
           .auto-style6 {
               font-family: Verdana;
               font-size: 10pt;
               color: #993366;
               width: 42%;
           }
           .auto-style7 {
               font-family: Verdana;
               font-size: 10pt;
               color: #993366;
               height: 36px;
               width: 42%;
           }
           .auto-style8 {
               width: 397px;
           }
           .auto-style9 {
               font-family: Verdana;
               font-size: 10pt;
               color: #993366;
               height: 36px;
               width: 397px;
           }
           .auto-style10 {
               font-family: Verdana;
               font-size: 10pt;
               color: #993366;
               width: 43%;
           }
           .auto-style11 {
               font-family: Verdana;
               font-size: 10pt;
               color: #993366;
               height: 36px;
               width: 43%;
           }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <%-- PLANTILLA PARA LA INSERCION DEL REGISTRO --%>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >
       
            <%--Aqui va el titulo del formulario--%>
            <div>
                <p class="tituloForm">MANTENIMIENTO DE ESPECIES</p>
            </div>

               <%--Boton ( o link button ) para mostrar el modal de insercion PopMant del nuevo registro--%>
            <asp:Button ID="btnNuevo" runat="server" Text="Nueva especie" OnClick="btnNuevo_Click" CssClass="boton2" />
            <br />

             <%--El grid view para el listado de registros, recuerde implementar la primera columna de tipo Button, con el CommanName (recomendado) Editar
                   y con un icono asociado a la accion de editar y formatear las columnas que desea mostrar--%>
            <br />
            <table class="auto-style3">
                <tr>
                    <td class="labelContenido">Ingrese descripción:</td>
                    <td>
                        <asp:TextBox ID="txtFiltro" runat="server" CssClass="TextBox" Width="255px"></asp:TextBox>
                        &nbsp;
                        <asp:ImageButton ID="btnFiltrar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnFiltrar_Click" style="width: 16px" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="grvEspecies" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="1031px" AutoGenerateColumns="False" CssClass="GriedView" AllowPaging="True" OnPageIndexChanging="grvEspecies_PageIndexChanging" PageSize="5" OnRowCommand="grvEspecies_RowCommand" OnRowDataBound="grvEspecies_RowDataBound" ShowHeaderWhenEmpty="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:ButtonField ButtonType="Image" CommandName="Editar" ImageUrl="~/Images/Editar.png" Text="Botón" />
                    <asp:BoundField DataField="Id_espec" HeaderText="Id Especie" />
                    <asp:BoundField DataField="Des_espec" HeaderText="Descripción" />
                    <asp:BoundField DataField="Mar_espec" HeaderText="Marca" />
                    <asp:BoundField DataField="Mod_espec" HeaderText="Modelo" />
                    <asp:BoundField DataField="Color" HeaderText="Color" />
                    <asp:BoundField DataField="Can_espec" HeaderText="Cantidad" />
                    <asp:BoundField DataField="Nro_serie" HeaderText="Nro. serie" />
                    <asp:BoundField DataField="Id_tip_espec" HeaderText="Tipo especie" />
                    <asp:BoundField DataField="Est_espec" HeaderText="Estado" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
            <br />
            <br />
            <br />
           
             <%-- PLANTILLA PARA LA INSERCION DEL REGISTRO --%>             
             <%--Control Target del ModalPopup de Insercion--%>
            <asp:LinkButton ID="lnkPopup1" runat="server"></asp:LinkButton>           
            <%--Panel cuyo contenido se mostrara en el ModalPopup de Insercion--%>
             <asp:Panel ID="PanelMan1" runat="server" CssClass="CajaDialogo" align="center" Style="display:table" Width="700">
              <table style="border: Solid 3px #D55500; height: 308px;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Nueva Especie</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style6">
                        &nbsp;</td>
                      <td align="left" class="auto-style4">
                          &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style6">
                        Descripción:</td>
                    <td align="left" class="auto-style4">
                        <asp:TextBox ID="txtDescripcion1" runat="server" Width="350px" CssClass="TextBox" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style6">
                        Marca:
                    </td>
                    <td align="left" class="auto-style4">
                        <asp:TextBox ID="txtMarca1" runat="server" Width="350px" CssClass="TextBox" />
                    </td>
                </tr>
                  <tr>
                      <td align="right" class="auto-style6">Modelo:</td>
                      <td align="left" class="auto-style4">
                          <asp:TextBox ID="txtModelo1" runat="server" CssClass="TextBox" Width="350px" />
                      </td>
                  </tr>
                <tr>
                    <td align="right" class="auto-style6">
                        Color:
                    </td>
                    <td align="left" class="auto-style4">
                        <asp:TextBox ID="txtColor1" runat="server" Width="350px" CssClass="TextBox" />
                    </td>
                </tr>
               
                     <tr>
                         <td align="right" class="auto-style6">Cantidad: </td>
                         <td align="left" class="auto-style4">
                             <asp:TextBox ID="txtCantidad1" runat="server" CssClass="TextBox" Width="350px" />
                         </td>
                     </tr>
                     <tr>
                         <td align="right" class="auto-style6">Nro. Serie</td>
                         <td align="left" class="auto-style4">
                             <asp:TextBox ID="txtNroSerie1" runat="server" CssClass="TextBox" Width="350px" />
                         </td>
                  </tr>
                     <tr>
                         <td align="right" class="auto-style6">Tipo de Especie:</td>
                         <td align="left" class="auto-style4">
                             <asp:DropDownList ID="cboTipoEspecie1" runat="server" Width="350px" OnSelectedIndexChanged="cboTipoEspecie1_SelectedIndexChanged">
                             </asp:DropDownList>
                         </td>
                  </tr>
                  <tr>
                      <td align="right" class="auto-style6">Estado:</td>
                      <td align="left" class="auto-style4">
                          <asp:CheckBox ID="chkEstado1" runat="server" CssClass="labelTitulo" Text="Activo" />
                      </td>
                  </tr>
                     <tr>
                         <td colspan="2">
                             <asp:Label ID="lblMensaje1" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style7">
                             &nbsp;</td>
                         <td class="auto-style5">
                             <asp:Button ID="btnGrabar1" runat="server" Text="Grabar" Width="100px" CssClass="boton" OnClick="btnGrabar1_Click" />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="btnCerrar1" runat="server"  Text="Cancelar" Width="100px" CssClass="boton" OnClick="btnCerrar1_Click" />
                         </td>
                     </tr>
              
            </table>
                        
        </asp:Panel>
              <%--Modalpopup extender PopMan01 para nuevos registros : vease el TargetControl que apunta al linkbutton  lnkPopup1 
                  y el PopupcontrolID que apunta al panel PanelMan1--%> 
             <ajaxToolkit:ModalPopupExtender ID="PopMan01" TargetControlID="lnkPopup1" 
                 PopupControlID="PanelMan1" runat="server" BackgroundCssClass="FondoAplicacion" ></ajaxToolkit:ModalPopupExtender>



          <%-- PLANTILLA PARA LA EDICION DEL REGISTRO (incluye un label para el codigo o PK del registro)--%>           
            <%--Control target del ModalPopup de edicion--%>
            <asp:LinkButton ID="lnkPopup2" runat="server"></asp:LinkButton>

             <%--Panel cuyo contenido de mostrara en el ModalPopup de Edicion--%>
       <asp:Panel ID="PanelMan2" runat="server" CssClass="CajaDialogo" align="center" Style="display:table" Width="700">
            <table style="border: Solid 3px #D55500; height: 308px;"
                cellpadding="0" cellspacing="0" >
                <tr style="background-color: darkred">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Actualizar especie</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style10">
                        &nbsp;</td>
                      <td align="left" class="auto-style8">
                          &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style10">
                        <asp:Label ID="lblEtiquetaCod" runat="server" Text="Codigo:"></asp:Label>
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:Label ID="lblCod" runat="server" CssClass="labelTitulo"></asp:Label>
                    </td>
                </tr>
               <tr>
                    <td align="right" class="auto-style10">
                        Descripción:
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtDescripcion2" runat="server" Width="350px" CssClass="TextBox" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style10">
                        Marca:
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtMarca2" runat="server" Width="350px" CssClass="TextBox" EnableTheming="True" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style10">Modelo:</td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtModelo2" runat="server" CssClass="TextBox" Width="350px" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style10">
                        Color:
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtColor2" runat="server" Width="350px" CssClass="TextBox" />
                    </td>
                </tr>
               
                     <tr>
                         <td align="right" class="auto-style10">Cantidad: </td>
                         <td align="left" class="auto-style8">
                             <asp:TextBox ID="txtCantidad2" runat="server" CssClass="TextBox" Width="350px" />
                         </td>
                     </tr>
                     <tr>
                         <td align="right" class="auto-style10">Nro. Serie</td>
                         <td align="left" class="auto-style8">
                             <asp:TextBox ID="txtNroSerie2" runat="server" CssClass="TextBox" Width="350px" />
                         </td>
                </tr>
                     <tr>
                         <td align="right" class="auto-style10">Tipo de Especie:</td>
                         <td align="left" class="auto-style8">
                             <asp:DropDownList ID="cboTipoEspecie2" runat="server" Width="350px" OnSelectedIndexChanged="cboTipoEspecie2_SelectedIndexChanged">
                             </asp:DropDownList>
                         </td>
                  </tr>
                  <tr>
                      <td align="right" class="auto-style10">Estado:</td>
                      <td align="left" class="auto-style8">
                          <asp:CheckBox ID="chkEstado2" runat="server" CssClass="labelTitulo" Text="Activo" />
                      </td>
                  </tr>
                     <tr>
                         <td colspan="2">
                             <asp:Label ID="lblMensaje2" runat="server" CssClass="labelErrores" Width="400px"></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style11">
                             &nbsp;</td>
                         <td class="auto-style9">
                             <asp:Button ID="btnGrabar2" runat="server" Text="Grabar" Width="100px" CssClass="boton" OnClick="btnGrabar2_Click" />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="btnCerrar2" runat="server"  Text="Cancelar" Width="100px" CssClass="boton" OnClick="btnCerrar2_Click" />
                         </td>
                     </tr>
              
            </table>
        </asp:Panel>
       <%--Modalpopup extender PopMan02 para el edicion de registros: vease el TargetControl que apunta al linkbutton  lnkPopup2 y el PopupcontrolID que apunta al panel PanelMan2--%> 
             <ajaxToolkit:ModalPopupExtender ID="PopMan02" TargetControlID="lnkPopup2" 
                 PopupControlID="PanelMan2" runat="server" BackgroundCssClass="FondoAplicacion"></ajaxToolkit:ModalPopupExtender>

      <%--CONFIGURACION DEL MODALPOPUP DE MENSAJES --%>
                <%--Control target para el ModalPopup de mensajes--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%-- El panel cuyo contenido se mostrara en el ModalPopup de mensajes--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="auto-style1" > 
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table>
                    <div> 
                        <asp:Label ID="lblMensajePopup" runat="server" ForeColor ="Black" CssClass="labelTitulo" /> 
                    </div>
                     <div>
                         <br />
                     </div>
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="boton" /> 
                    </div> 
                  <div>
                         <br />
                     </div>
                </asp:Panel> 
          <%--El ModalPopup  PopMensaje que hace referencia al ID del control target  (TargetControlID="lnkMensaje")
                    y al ID al panel (PopupControlID="pnlMensaje")--%>
                               <ajaxToolkit:ModalPopupExtender ID="PopMensaje" 
                                   TargetControlID="lnkMensaje" 
                                   PopupControlID="pnlMensaje" runat="server" BackgroundCssClass="FondoAplicacion"></ajaxToolkit:ModalPopupExtender>
        </ContentTemplate>

    </asp:UpdatePanel>
   <%--El UpdateProgress para el manejo del tiempo de refresco del UpdatePanel1 por la insercion , actualizacion o eliminacion--%>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0" AssociatedUpdatePanelID="UpdatePanel1">
        <%--<ProgressTemplate >
            <div class="overlay"  />
            <div class ="overlayContent" >
            <h2>  Procesando....</h2> 
                <p>
                    &nbsp;</p>
                <img src ="../Images/indicator.gif" alt ="Loading" border="0"/>
                </div> 
        </ProgressTemplate>--%>
    </asp:UpdateProgress>
</asp:Content>
