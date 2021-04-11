using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Solutions4.Model
{
    public class Patente
    {
        [Key]
        public int Id { get; set; }
        public int NumeroPedido { get; set; }
        public string Titulo { get; set; }
        public string Regiao { get; set; }
        public DateTime DataDeposito { get; set; }
        public DateTime DataPublicacao { get; set; }
        public DateTime DataEntradaNacional { get; set; }
        public string PaisPrioridade { get; set; }
        public int NumeroPrioridade { get; set; }
        public DateTime DataPrioridade { get; set; }
        public string ClassificacaoIPC { get; set; }
        public string Depositante { get; set; }
        public string Autor { get; set; }
        public string Procurador { get; set; }
        public int RPI { get; set; }
        public DateTime DataRPI { get; set; }
        public int Despacho { get; set; }
        public string DescricaoDespacho { get; set; }
        public string ComplementoDespacho { get; set; }
        public int NumeroPacote { get; set; }
        public DateTime DataPacote { get; set; }
        public string CodigoWO { get; set; }
        public DateTime DataWO { get; set; }
    }
}
