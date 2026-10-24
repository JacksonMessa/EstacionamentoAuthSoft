using EstacionamentoAuthSoft.Models;
using EstacionamentoAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoAuthSoft.Forms
{
    public partial class ListarVeiculos : Form
    {
        public ListarVeiculos()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();

            telaInicial.Show();
            this.Close();
        }

        private void ListarVeiculos_Load(object sender, EventArgs e)
        {
            dataGridVeiculos.AutoGenerateColumns = false;
            CarregarLista();
        }

        private void CarregarLista()
        {
            VeiculoRepository veiculoRepository = new VeiculoRepository();
            List<Veiculo> veiculos = veiculoRepository.ObterTodosOsVeiculos();

            
            dataGridVeiculos.DataSource = veiculos;
        }

        private void DataGridVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string nomeColuna = dataGridVeiculos.Columns[e.ColumnIndex].Name;

            if (nomeColuna == "botoesEditar")
            {
                Veiculo veiculo = (Veiculo)dataGridVeiculos.Rows[e.RowIndex].DataBoundItem;

                CadastroVeiculos cadastroVeiculos = new CadastroVeiculos(veiculo);
                cadastroVeiculos.Show();

                this.Hide();
            }else if(nomeColuna == "botoesExcluir")
            {
                Veiculo veiculo = (Veiculo)dataGridVeiculos.Rows[e.RowIndex].DataBoundItem;

                DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir o veículo: {veiculo.Modelo} {veiculo.Cor} de placa {veiculo.Placa}","Excluir Veículo",MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    VeiculoRepository veiculoRepository = new VeiculoRepository();

                    try
                    {

                        veiculoRepository.Excluir(veiculo.Id);
                        MessageBox.Show("Veiculo excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarLista();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show($"Ocorreu um erro inesperado no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
