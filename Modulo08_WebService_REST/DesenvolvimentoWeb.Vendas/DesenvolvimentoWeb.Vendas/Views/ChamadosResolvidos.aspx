<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ChamadosResolvidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.MostrarChamadosResolvidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="col-md-7">
            <h3>Lista de Chamados Resolvidos </h3>
            <asp:Repeater ID="chamadosRepeater" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>Chamado</th>
                                <th>Assunto</th>
                                <th>Descrição</th>
                                <th>Documento</th>
                                <th>Data</th>
                                <th>Resposta</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label runat="server" Text='<%# Eval("ChamadoId") %>'></asp:Label>
                        </td>

                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Assunto") %>'></asp:Label>
                        </td>

                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Descricao") %>'></asp:Label>
                        </td>

                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Documento") %>'></asp:Label>
                        </td>

                         <td>
                            <asp:Label runat="server" Text='<%# Eval("Data") %>'></asp:Label>
                        </td>

                        <td>
                            <asp:Label runat="server" Text='<%# Eval("Resposta") %>'></asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>

        </div>
</asp:Content>
