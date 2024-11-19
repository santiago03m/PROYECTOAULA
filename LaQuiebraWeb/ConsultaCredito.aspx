<%@ Page Title="Consulta Credito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaCredito.aspx.cs" Inherits="LaQuiebraWeb.ConsultaCredito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Consulta de Créditos</h2>
    <div>
        <asp:Label ID="lblIdCliente" runat="server" Text="ID Cliente:"></asp:Label>
        <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNombreCliente" runat="server" Text="Nombre Cliente:"></asp:Label>
        <asp:TextBox ID="txtNombreCliente" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    </div>
    <br />
    <asp:GridView ID="gvResultados" runat="server" AutoGenerateColumns="false" CssClass="centrado" BorderStyle="Solid" BorderWidth="2px">
    <Columns>
        <asp:BoundField DataField="ID_Credito" HeaderText="ID Crédito">
            <ItemStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Monto_Total" HeaderText="Monto Inicial">
            <ItemStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Pagos_Realizados" HeaderText="Total Pagado">
            <ItemStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
        <asp:BoundField DataField="Monto_Pendiente" HeaderText="Monto Pendiente">
            <ItemStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" />
        </asp:BoundField>
    </Columns>
        <PagerStyle BorderStyle="Solid" />
        <RowStyle BorderStyle="Solid" />
</asp:GridView>

</asp:Content>