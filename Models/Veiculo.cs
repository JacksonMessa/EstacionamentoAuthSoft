using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoAuthSoft.Models
{
    internal class Veiculo
    {
        public Veiculo(int id, string placa, string modelo, string cor)
        {
            this.Id = id;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Cor = cor;
        }

        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
    }
}
