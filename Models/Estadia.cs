using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoAuthSoft.Models
{
    internal class Estadia
    {
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
    }
}
