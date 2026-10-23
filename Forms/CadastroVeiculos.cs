using EstacionamentoAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            if (ChecarCamposVazios(placa,modelo,cor))
            {
                veiculoRepositories.Cadastrar(placa, modelo, cor);
            }
        }

        private bool ChecarCamposVazios(string placa, string modelo, string cor)
        {
            if(placa == "")
            {
                MessageBox.Show("O campo de placa deve ser preenchido","Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(modelo == "")
            {
                MessageBox.Show("O campo de modelo deve ser preenchido", "Campo Inválido", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }else if(cor == "")
            {
                MessageBox.Show("O campo de cor deve ser preenchido", "Campo Inválido", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
}
