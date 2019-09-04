using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Projeto02_AcessoDados;
using Projeto02_AcessoDados.DAL;
using Projeto02_AcessoDados.Models;


namespace Projeto02_AcessoDados.DAL
{
	public class CursosDao : Dao<Curso, int>
	{
		
		public override Curso Buscar(int chave)
		{
			Curso curso = null;

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
			return curso;
		}

		public override void Incluir(Curso elemento)
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

		public override IEnumerable<Curso> Listar(int id = 0)
		{
			List<Curso> cursos = new List<Curso>();
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
			return cursos;
		}
	}


}
