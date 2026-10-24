using EstacionamentoAuthSoft.Models;
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
            VeiculoRepository veiculoRepositorie = new VeiculoRepository();
            List<Veiculo> veiculos = veiculoRepositorie.ObterTodosOsVeiculos();

            dataGridVeiculos.AutoGenerateColumns = false;
            dataGridVeiculos.DataSource = veiculos;
        }
    }
}
