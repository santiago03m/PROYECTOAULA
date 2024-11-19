<%@ Page Title="Maestro Detalle" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaestroDB.aspx.cs" Inherits="LaQuiebraWeb.MaestroDB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>RELACIÓN DE CRÉDITOS Y PAGOS</h3>

    <p>
        Cliente:&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSourceClientes" DataTextField="Nombre" DataValueField="ID_Cliente" AutoPostBack="True">
        </asp:DropDownList>
        
        <asp:SqlDataSource ID="SqlDataSourceClientes" runat="server" 
            ConnectionString="<%$ ConnectionStrings:cadenaSQL %>" 
            ProviderName="<%$ ConnectionStrings:cadenaSQL.ProviderName %>" 
            SelectCommand="SELECT ID_Cliente, CONCAT(Nombre, ' ', Apellido) AS Nombre FROM [Clientes]">
        </asp:SqlDataSource>

    </p>

    <h4>Detalles de Créditos</h4>
    <asp:GridView ID="GridViewCreditos" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_Credito" DataSourceID="SqlDataSourceCreditos" Width="100%" BorderStyle="Solid" BorderWidth="1px" GridLines="Both">
        <Columns>
            <asp:BoundField DataField="ID_Credito" HeaderText="ID Crédito" ReadOnly="True" SortExpression="ID_Credito" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Monto_Total" HeaderText="Monto Total" SortExpression="Monto_Total" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Fecha_Inicio" HeaderText="Fecha Inicio" SortExpression="Fecha_Inicio" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Fecha_Vencimiento" HeaderText="Fecha Vencimiento" SortExpression="Fecha_Vencimiento" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceCreditos" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cadenaSQL %>" 
        ProviderName="<%$ ConnectionStrings:cadenaSQL.ProviderName %>" 
        SelectCommand="SELECT * FROM [Creditos] WHERE [ID_Cliente] = @ID_Cliente">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="ID_Cliente" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
