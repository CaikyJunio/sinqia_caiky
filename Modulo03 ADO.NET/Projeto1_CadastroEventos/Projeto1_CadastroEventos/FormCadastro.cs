using Projeto02_AcessoDados.DAL;
using Projeto02_AcessoDados.Models;
using Projeto1_CadastroEventos.RepositoryDao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1_CadastroEventos
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
			ListarEventos();
		}

		private void incluireventoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Evento evento = new Evento();
				evento.Descricao = descricaoMaskedTextBox.Text;
				evento.Responsavel = responsavelMaskedTextBox2.Text;
				evento.Data = Convert.ToDateTime(dataMaskedTextBox.Text);
				evento.Preco = Convert.ToDouble(precoMaskedTextBox.Text);

				EventosDao dao = Repository.GetEventosDao();
				dao.Incluir(evento);

				ListarEventos();
				MessageBox.Show("Evento incluído com sucesso");

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}
			private void ListarEventos()
			{
			try
			{
				EventosDao dao = Repository.GetEventosDao();
				EventocomboBox.DataSource = dao.Listar();
				EventocomboBox.DisplayMember = "Descricao"; ///text
				EventocomboBox.ValueMember = "Id"; ////Value
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
				
			}
			 
			}

		private void incluirConvidadoButton_Click(object sender, EventArgs e)
		{
			try
			{
				Convidado convidado = new Convidado();
				ConvidadosDao dao = Repository.GetConvidadosDao();

				convidado.Nome = nomeTextBox.Text;
				convidado.Cpf = cpfTextBox.Text;
				convidado.Email = emailTextBox.Text;
				convidado.Telefone = telefoneTextBox.Text;

				//obtendo o Id do evento a partir do combobox
				int id = (int)EventocomboBox.SelectedValue;
				convidado.EventoInfo = Repository.GetEventosDao().Buscar(id);

				// incluindo o convidado no banco de daods

				dao.Incluir(convidado);


				if(dao.StatusInclusaoConvidado == 1)
				{
					MessageBox.Show("Convidado alterado com sucesso");
				}
				else
				{
					MessageBox.Show("Convidado incluído com sucesso");
				}

				cpfTextBox.Clear();
				nomeTextBox.Clear();
				emailTextBox.Clear();
				telefoneTextBox.Clear();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buscarconvidadosButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)EventocomboBox.SelectedValue;
				ConvidadosDao dao = Repository.GetConvidadosDao();
				//convidadosdataGridView.DataSource = dao.Listar(id);
				convidadosdataGridView.DataSource = dao.ListarConvidados(id);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

}
