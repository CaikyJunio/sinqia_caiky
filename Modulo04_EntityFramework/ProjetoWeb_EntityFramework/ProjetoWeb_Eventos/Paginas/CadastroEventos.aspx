<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroEventos.aspx.cs" Inherits="ProjetoWeb_Eventos.Paginas.CadastroEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro de Eventos</h1>

            </div>

            <div>
                <asp:Label ID="descricaoLabel" runat="server" Text="Descrição:"></asp:Label><br />  
                <asp:TextBox ID="descricacoTextBox" runat="server"></asp:TextBox><br />  

                <asp:Label ID="responsavelLabel" runat="server" Text="Responsável:"></asp:Label><br />  
                <asp:TextBox ID="responsavelTextBox" runat="server"></asp:TextBox><br />  
            
                <asp:Label ID="dataLabel" runat="server" Text="Data: "></asp:Label><br />   
                <asp:TextBox ID="dataTextBox" TextMode="Date" runat="server"></asp:TextBox><br />  

                <asp:Label ID="precoLabel" runat="server" Text="Preço:"></asp:Label><br />  
                <asp:TextBox ID="precoTextBox" runat="server"></asp:TextBox><br />  
                
                <asp:Button ID="incluirButton" runat="server" Text="Incluir Evento" OnClick="incluirButton_Click" /><br />
       
                <asp:Label ID="mensagemLabel" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
