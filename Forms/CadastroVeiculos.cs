using EstacionamentoAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
                placa = FormatarPlaca(placa);
                if (ValidarPlaca(placa))
                {
                    try
                    {
                        veiculoRepositories.Cadastrar(placa, modelo, cor);
                        MessageBox.Show("Veiculo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.ErrorCode == 19)
                        {
                            MessageBox.Show("Esta placa já está cadastrada no sistema!", "Placa Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Ocorreu um erro inesperado no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private string FormatarPlaca(string placa)
        {
            if (placa.Length == 8 && placa[3] == '-')
            {
                placa = placa.Remove(3, 1);
            }

            return placa.ToUpper();
        }

        private bool ValidarPlaca(string placa)
        {
            string padrao = @"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$";

            bool placaevalida = Regex.IsMatch(placa, padrao);
            if(!placaevalida)
            {
                MessageBox.Show("O campo de placa deve conter o formato antigo 'ABC1234' ou Mercosul 'ABC1D23'", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return placaevalida;
        }
    }
}
