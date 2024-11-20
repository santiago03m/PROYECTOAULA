<%@ Page Title="Vista" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaCreditoCliente.aspx.cs" Inherits="LaQuiebraWeb.VistaCreditoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Créditos de Clientes: Informacion relevante respecto a clientes</h1>
    <asp:SqlDataSource ID="SqlDataSourceVistaCreditoCliente" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cadenaSQL %>" 
        ProviderName="System.Data.SqlClient"
        SelectCommand="SELECT * FROM VistaCreditoCliente ORDER BY Fecha_Vencimiento ASC">
    </asp:SqlDataSource>
    <asp:GridView ID="GridViewCreditosCliente" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceVistaCreditoCliente" CssClass="gridview-style" EmptyDataText="No se encontraron créditos">
    <Columns>
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
        <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
        <asp:BoundField DataField="Correo_Electronico" HeaderText="Correo Electrónico" SortExpression="Correo_Electronico" />
        <asp:BoundField DataField="Telefono" HeaderText="Teléfono" SortExpression="Telefono" />
        <asp:BoundField DataField="Monto_Total" HeaderText="Monto Total" SortExpression="Monto_Total" DataFormatString="{0:C2}" />
        <asp:BoundField DataField="Fecha_Inicio" HeaderText="Fecha Inicio" SortExpression="Fecha_Inicio" DataFormatString="{0:dd/MM/yyyy}" />
        <asp:BoundField DataField="Fecha_Vencimiento" HeaderText="Fecha Vencimiento" SortExpression="Fecha_Vencimiento" DataFormatString="{0:dd/MM/yyyy}" />
        <asp:TemplateField HeaderText="Tasa de Interés">
        <ItemTemplate>
            <%# Eval("Tasa_Interes") %>%
        </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Estado_Credito" HeaderText="Estado Crédito" SortExpression="Estado_Credito" />
        <asp:BoundField DataField="PagosRealizados" HeaderText="Pagos Realizados" SortExpression="PagosRealizados" DataFormatString="{0:C2}" />
        <asp:BoundField DataField="DeudaActual" HeaderText="Deuda Actual" SortExpression="DeudaActual" DataFormatString="{0:C2}" />
    </Columns>
    </asp:GridView>

</asp:Content>
