using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoAuthSoft.DTO
{
    internal class ArrecadacaoDTO
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Entrada { get; set; }
        public string Saida { get; set; }
        public string Permanencia { get; set; }
        public int Valor { get; set; }

        public ArrecadacaoDTO(string placa, string modelo, string entrada, string saída, string permanencia, int valor)
        {
            Placa = placa;
            Modelo = modelo;
            Entrada = entrada;
            Saida = saída;
            Permanencia = permanencia;
            Valor = valor;
        }
    }
}
