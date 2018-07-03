<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaBancario.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click" />
</asp:Content>
