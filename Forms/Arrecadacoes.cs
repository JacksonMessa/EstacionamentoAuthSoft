using EstacionamentoAuthSoft.DTO;
using EstacionamentoAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog salvarCsvDialog = new SaveFileDialog())
            {
                salvarCsvDialog.Filter = "Arquivo CSV (*.csv)|*.csv|Todos os arquivos (*.*)|*.*";
                salvarCsvDialog.Title = "Salvar Relatório CSV";
                salvarCsvDialog.FileName = $"Relatorio_Estacionamento_{datePickerFiltro.Value:yyyyMMdd}.csv";

                if (salvarCsvDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(salvarCsvDialog.FileName, false, Encoding.UTF8))
                        {
                            StringBuilder linhaCsv = new StringBuilder();

                            for (int i = 0; i < dataGridArrecadacoes.Columns.Count; i++)
                            {

                                    linhaCsv.Append(dataGridArrecadacoes.Columns[i].HeaderText);
                                    if (i < dataGridArrecadacoes.Columns.Count - 1)
                                        linhaCsv.Append(";"); 
                            }
                            sw.WriteLine(linhaCsv.ToString());

                            foreach (DataGridViewRow row in dataGridArrecadacoes.Rows)
                            {
                                linhaCsv.Clear();
                                for (int i = 0; i < dataGridArrecadacoes.Columns.Count; i++)
                                {
                                    var valor = row.Cells[i].Value;
                                    linhaCsv.Append(valor != null ? valor.ToString() : "");

                                    if (i < dataGridArrecadacoes.Columns.Count - 1)
                                        linhaCsv.Append(";");
                                }
                                sw.WriteLine(linhaCsv.ToString());
                            }

                            sw.WriteLine();


                            sw.WriteLine(lblTotal.Text);
                        }

                        MessageBox.Show("Arquivo CSV exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
