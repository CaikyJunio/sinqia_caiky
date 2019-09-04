using DesenvolvimentoWeb.Vendas.Data;
using DesenvolvimentoWeb.Vendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesenvolvimentoWeb.Vendas.Views
{
	public partial class CadastroClientes : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ListarReapeaterClientes();
		}
		protected void enviarButton_Click(object sender, EventArgs e)
		{
			try
			{
				Cliente cliente = new Cliente();
				cliente.Documento = documentoTextBox.Text;
				cliente.Nome = nomeTextBox.Text;
				cliente.Email = emailTextBox.Text;
				cliente.Telefone = telefoneTextBox.Text;

				ClientesDao.IncluirCliente(cliente);

				ListarReapeaterClientes();

				mensagemLabel.CssClass = "alert alert-success";
				mensagemLabel.Text = "Cliente incluido com sucesso";
			}
			catch (Exception ex)
			{
				mensagemLabel.CssClass = "alert alert-danger";
				mensagemLabel.Text = ex.Message;
				throw;
			}
		}

		private void ListarReapeaterClientes()
		{
			clientesRepeater.DataSource = ClientesDao.ListarClientes();
			clientesRepeater.DataBind();

		}
	}
}