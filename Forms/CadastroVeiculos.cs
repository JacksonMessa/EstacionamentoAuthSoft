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
    public partial class CadastroVeiculos : Form
    {
        public CadastroVeiculos()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();

            telaInicial.Show();
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            VeiculoRepositorie veiculoRepositories = new VeiculoRepositorie();

            string placa = txtPlaca.Text;
            string modelo = txtModelo.Text;
            string cor = txtCor.Text;

            veiculoRepositories.Cadastrar(placa,modelo,cor);
        }
    }
}
