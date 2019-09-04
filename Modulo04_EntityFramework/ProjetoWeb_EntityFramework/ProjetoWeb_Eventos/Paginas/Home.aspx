<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjetoWeb_Eventos.Paginas.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Gestão de Eventos</h1>
            <h2>Escolha uma opção:</h2>
            <ul>
                <li>
                    <asp:HyperLink ID="eventosHyperLink" runat="server" Text="Cadastro de Eventos" NavigateUrl="~/Paginas/CadastroEventos.aspx">Cadastro de Eventos</asp:HyperLink></li>
                <li>
                    <asp:HyperLink ID="cadastrosHyperLink" runat="server" NavigateUrl ="~/Paginas/CadastroConvidados.aspx">Cadastro de Convidados</asp:HyperLink></li>
            </ul>
        </div>
    </form>
</body>
</html>
