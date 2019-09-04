using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesenvolvimentoWeb.Vendas.ViewModels
{
    public class ChamadosViewModel
    {
        public string Documento { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public int ChamadoId { get; set; }
        public DateTime Data { get; set; }
        public string Resposta { get; set ;} 
    }
}