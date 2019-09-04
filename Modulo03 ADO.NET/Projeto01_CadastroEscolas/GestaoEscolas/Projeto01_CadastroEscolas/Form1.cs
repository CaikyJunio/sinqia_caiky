using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto01_CadastroEscolas.RepositoryDao;
using Projeto02_AcessoDados.DAL;
using Projeto02_AcessoDados.Models;



namespace Projeto01_CadastroEscolas
{
	public partial class FormCadastro : Form
	{
		public FormCadastro()
		{
			InitializeComponent();
			
		}

		private void incluirCursobutton_Click(object sender, EventArgs e)
		{
		
		}

		private void incluirEscolaButton_Click(object sender, EventArgs e)
		{
			try
			{
				Escola escola = new Escola();
				EscolasDao dao = Repository.GetEscolasDao();

				escola.Descricao = descricaoTextBox.Text;
				escola.Endereco = enderecoTextBox.Text;
				escola.Telefone = telefoneTextBox.Text;

				// Limpando dados do campo
				descricaoTextBox.Clear();
				enderecoTextBox.Clear();
				telefoneTextBox.Clear();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			
			}
			
		}
	}
}
