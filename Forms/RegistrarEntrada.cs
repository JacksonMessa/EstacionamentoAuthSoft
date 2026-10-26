using EstacionamentoAuthSoft.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EstacionamentoAuthSoft.Forms
{
    public partial class RegistrarEntrada : Form
    {
        public RegistrarEntrada()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();

            telaInicial.Show();
            this.Close();
        }

        private void RegistrarEntrada_Load(object sender, EventArgs e)
        {
            VeiculoRepository veiculoRepository = new VeiculoRepository();

            List<string> placas = veiculoRepository.ObterTodasAsPlacas();

            foreach (string placa in placas)
            {
                cmbPlaca.Items.Add(placa);
            }
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbPlaca.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhuma placa foi selecionada!", "Campo Inválio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VeiculoRepository veiculoRepository = new VeiculoRepository();
                int veiculoId = veiculoRepository.ObterIdPelaPlaca(cmbPlaca.Text);

                DateTime apenasData = datePickerEntrada.Value.Date;
                TimeSpan apenasHora = timePickerEntrada.Value.TimeOfDay;
                DateTime entrada = apenasData + apenasHora;

                EstadiaRepository estadiaRepository = new EstadiaRepository();

                try
                {
                    if(estadiaRepository.RegistrarEntrada(veiculoId, entrada.ToString("yyyy-MM-dd HH: mm")))
                    {
                        MessageBox.Show("Entrada registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Ocorreu um erro inesperado");
                    }

                    cmbPlaca.SelectedIndex = -1;
                    datePickerEntrada.Value = DateTime.Now;
                    timePickerEntrada.Value = DateTime.Now;
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
}
