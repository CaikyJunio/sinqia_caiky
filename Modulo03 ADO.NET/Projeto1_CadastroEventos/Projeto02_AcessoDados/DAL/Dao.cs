using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_AcessoDados.DAL
{

	public abstract class Dao<T, K>
	{
		public Dao()
		{
			cn = new SqlConnection(conexao);
			cmd = new SqlCommand();
			cmd.Connection = cn;
			adapter = new SqlDataAdapter();
		}
		//string de conexao
		protected string conexao = @"Password=Imp@ct@;Persist Security Info=True;User ID=sa;Initial Catalog=DB_EVENTOS;Data Source=.";

		//objetos de acesso a dados
		protected SqlConnection cn;
		protected SqlCommand cmd;

		protected SqlDataReader reader; //modo conectado unidirecional
		protected SqlDataAdapter adapter; //  modo desconectado multidirecional 
										  //metodos para abrir e fechar conexao

		protected void AbirConexao()
		{
			cn.Open();
		}

		protected void FecharConexao()
		{
			if (cn.State == ConnectionState.Open && cn != null)
				cn.Close();
		}

		//Metodos abstratos

		public abstract void Incluir(T elemento);
		public abstract T Buscar(K chave);
		public abstract IEnumerable<T> Listar(int id =0);
		
	}
}

