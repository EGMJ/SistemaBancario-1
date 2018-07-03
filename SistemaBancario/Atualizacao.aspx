<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Atualizacao.aspx.cs" Inherits="SistemaBancario.Atualizacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Atualizar</h2>
    Id:<asp:TextBox ID="txtId" runat="server" Enabled="False"></asp:TextBox><br />
    Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
    Email:<asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox><br />
    Nascimento:<asp:TextBox ID="txtNasc" runat="server" TextMode="Date"></asp:TextBox><br />
    Senha:<asp:TextBox ID="txtSenha" runat="server"></asp:TextBox><br />
    Saldo:<asp:TextBox ID="txtSaldo" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click"  />
    <asp:Button ID="btnDeletar" runat="server" Text="Deletar"  OnClientClick='return confirm("Deseja mesmo deletar?")' OnClick="btnDeletar_Click"/>
    <asp:Label ID="lblResposta" runat="server" Text=""></asp:Label><br />
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Gerencia.aspx">Voltar</asp:HyperLink>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Logout</asp:HyperLink>

</asp:Content>
