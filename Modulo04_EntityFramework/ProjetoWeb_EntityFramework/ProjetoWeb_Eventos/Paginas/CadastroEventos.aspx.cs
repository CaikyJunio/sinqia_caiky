using ProjetoWeb_Eventos.Dados;
using ProjetoWeb_Eventos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoWeb_Eventos.Paginas
{
	public partial class CadastroEventos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void incluirButton_Click(object sender, EventArgs e)
		{
			try
			{
				Evento evento = new Evento();
				evento.Descricao = descricacoTextBox.Text;
				evento.Responsavel = responsavelTextBox.Text;
				evento.Data = Convert.ToDateTime(dataTextBox.Text);
				evento.Preco = Convert.ToDouble(precoTextBox.Text);

				EventosDao.IncluirEvento(evento);

				mensagemLabel.ForeColor = System.Drawing.Color.Blue;
				mensagemLabel.Text = "Evento incluído com sucesso";

			}
			catch (Exception ex)
			{

				mensagemLabel.ForeColor = System.Drawing.Color.Red;
				mensagemLabel.Text = ex.Message;
			}
		}
	}
}