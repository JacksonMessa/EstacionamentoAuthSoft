using EstacionamentoAuthSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoAuthSoft.DTO
{
    internal class VeiculoEstacionadoDTO
    {
        public int EstadiaId { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Entrada { get; set; }
        public string Permanencia { get; set; }
        public int ValorAtual { get; set; }

        public VeiculoEstacionadoDTO(int estadiaId, string placa, string modelo, string entrada, string permanencia, int valorAtual)
        {
            EstadiaId = estadiaId;
            Placa = placa;
            Modelo = modelo;
            Entrada = entrada;
            Permanencia = permanencia;
            ValorAtual = valorAtual;
        }
    }
}
