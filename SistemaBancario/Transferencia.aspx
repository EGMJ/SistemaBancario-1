<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Transferencia.aspx.cs" Inherits="SistemaBancario.Transferencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblidtransf" runat="server" Text="" Visible="False"></asp:Label>
    <asp:Label ID="lblCliente" runat="server" Text=""></asp:Label><br />        
    <asp:Label ID="lblSaldo" runat="server" Text=""></asp:Label><br />        
    <asp:TextBox ID="txtBusca" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" /><br />
    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblIdreceb" runat="server" Text="" Visible="False"></asp:Label>
    <asp:TextBox ID="txtQuantia" runat="server"></asp:TextBox>
    <asp:Button ID="btnTransferir" runat="server" Text="Transferir" OnClick="btnTransferir_Click" Enabled="False" /><br />
    <asp:Label ID="lblResultadoo" runat="server" Text=""></asp:Label><br />        
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Logout</asp:HyperLink>
</asp:Content>
