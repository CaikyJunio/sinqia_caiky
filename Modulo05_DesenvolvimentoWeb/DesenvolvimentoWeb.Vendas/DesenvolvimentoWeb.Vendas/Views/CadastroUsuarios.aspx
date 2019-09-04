<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroUsuarios.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    
    <div class="container">
        <h2 class="text-center text-primary">Cadastro de Usuários</h2>
      
      
    </div>

      <div class="row container">
            <div class="col-md-5">


                <div class="form-group">
                    <asp:Label ID="documentoLabel" runat="server" Text="Nome:"></asp:Label>
                    <asp:TextBox ID="nomeTextBox" CssClass="form-control" MaxLenght="20" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="nomeRequiredFieldValidator"
                        runat="server"
                        CssClass="text-danger"
                        ControlToValidate="nomeTextBox"
                        ErrorMessage="O Nome do usuário deve ser informado"
                        Display="Dynamic">

                    </asp:RequiredFieldValidator>
                </div>


                <div class="form-group">
                    <asp:Label ID="senhaLabel" runat="server" Text="Senha:"></asp:Label>
                    <asp:TextBox ID="senhaTextBox" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="senhaRequiredFieldValidator"
                        runat="server"
                        CssClass="text-danger"
                        ControlToValidate="senhaTextBox"
                        ErrorMessage="A senha do usuário deve ser informada"
                        Display="Dynamic">

                    </asp:RequiredFieldValidator>
                </div>



                <div class="form-group">
                    <asp:Label ID="confirmaLabel" runat="server" Text="Confirme sua Senha:"></asp:Label>
                    <asp:TextBox ID="confirmaTextBox" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>

                    <asp:CompareValidator ID="confirmaCompareValidator1"
                        runat="server"
                        ErrorMessage="As senhas não conferem"
                        ControlToValidate="confirmaTextBox"
                        ControlToCompare="senhaTexTBox"
                        Display="Dynamic">                   

                    </asp:CompareValidator>
                    </div>


                    <div class="form-group">
                        <asp:Button ID="enviarButton" CssClass="btn btn-primary"
                            runat="server" Text="Incluir Usuário"
                            OnClick="enviarButton_Click" />
                    </div>

                    <div>
                        <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                    </div>

                


            </div>
        </div>
</asp:Content>
