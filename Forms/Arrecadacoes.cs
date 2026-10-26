using EstacionamentoAuthSoft.DTO;
using EstacionamentoAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoAuthSoft.Forms
{
    public partial class Arrecadacoes : Form
    {
        public Arrecadacoes()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();

            this.Close();
        }

        private void DatePickerFiltro_ValueChanged(object sender, EventArgs e)
        {
            CarregarArrecadacoes();
        }

        private void Arrecadacoes_Load(object sender, EventArgs e)
        {
            dataGridArrecadacoes.AutoGenerateColumns = false;
            CarregarArrecadacoes();
        }

        private void CarregarArrecadacoes()
        {
            string data = datePickerFiltro.Value.ToString("yyyy-MM-dd");

            EstadiaRepository estadiaRepository = new EstadiaRepository();
            List<ArrecadacaoDTO> veiculos = estadiaRepository.ObterArrecadacoesPorDia(data);

            dataGridArrecadacoes.DataSource = veiculos;

            int total = 0;

            foreach (DataGridViewRow linha in dataGridArrecadacoes.Rows)
            {
                if (linha.Cells["valor"].Value != null)
                {
                    int valorLinha = Convert.ToInt32(linha.Cells["valor"].Value);
                    total += valorLinha;
                }
            }

            lblTotal.Text = "Total: R$" + total;
        }
    }
}
