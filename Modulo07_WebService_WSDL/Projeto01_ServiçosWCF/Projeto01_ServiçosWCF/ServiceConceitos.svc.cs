using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Projeto01_ServiçosWCF.Models;

namespace Projeto01_ServiçosWCF
{

    public class ServiceConceitos : IServiceConceitos
    {
        private List<Aluno> alunos = new List<Aluno>();
        
        public void AdicionarAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public double CalcularSoma(double x, double y)
        {
            return x + y;
        }

        public List<Aluno> ListarAlunos()
        {
            return alunos;
        }

        public List<string> ListarNomes()
        {
            return new List<string>()
            {
                "Francisco","Guilherme", "Luan", "Caiky", "Pedro"
            };
        }
    }
}
