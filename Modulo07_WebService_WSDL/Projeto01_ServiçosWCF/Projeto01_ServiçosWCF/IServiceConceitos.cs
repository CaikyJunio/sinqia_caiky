using Projeto01_ServiçosWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projeto01_ServiçosWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServiceConceitos
    {
        [OperationContract]
        List<Aluno> ListarAlunos();

        [OperationContract]
        void AdicionarAluno(Aluno aluno);

        //métodos adicionais
        [OperationContract]
        List<string> ListarNomes();

        [OperationContract]
        double CalcularSoma(double x, double y);

        
    }


    
}
