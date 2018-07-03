<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Gerencia.aspx.cs" Inherits="SistemaBancario.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <th>Nome</th>
            <th>Email</th>
            <th>Nascimento</th>
            <th>Senha</th>
            <th>Saldo</th>
            <th>Ação</th>
        </tr>
        <asp:ListView ID="ListaContato" runat="server" DataSourceID="ObjectDataSource1">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("nome") %></td>
                    <td><%# Eval("email") %></td>
                    <td><%# Eval("dataNasc","{0:dd/MM/yyyy}") %></td>
                    <td><%# Eval("senha") %></td>
                    <td><%# Eval("saldo") %></td>
                    <td>
                        <asp:LinkButton ID="lbOrder" runat="server" PostBackUrl='<%# "~/Atualizacao.aspx?id="+ Eval("id")%>'> Editar/Remover</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </table>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Listar" TypeName="SistemaBancario.DAO.ClientesDAO"></asp:ObjectDataSource>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Logout</asp:HyperLink>
</asp:Content>
