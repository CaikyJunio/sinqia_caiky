using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02_AcessoDados;
using Projeto02_AcessoDados.Models;

namespace Projeto02_AcessoDados.DAL
{
	public class EscolasDao : Dao<Escola, string>
	{
		public override Escola Buscar(string chave)
		{
			throw new NotImplementedException();
		}

		public int StatusInclusaoConvidado { get; set; }


		public override void Incluir(Escola elemento)
		{
			try
			{
				AbrirConexao();
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
		}

		public DataTable ListarEscolas(int id)
		{
			DataTable table = new DataTable();
			try
			{
				AbrirConexao();
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
			return table;
		}

		public override IEnumerable<Escola> Listar(int id = 0)
		{
			List<Escola> escolas = new List<Escola>();
			try
			{
				AbrirConexao();
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
			return escolas;
		}
	}

}
