using EstacionamentoAuthSoft.Repositories;
using EstacionamentoAuthSoft.Utils;
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
    public partial class RegistrarSaida : Form
    {
        private int estadiaId;
        private DateTime entrada;
        public RegistrarSaida(string placa, int estadiaId, DateTime entrada)
        {
            InitializeComponent();
            txtPlaca.Text = placa;
            this.estadiaId = estadiaId;
            this.entrada = entrada;

            datePickerEntrada.MinDate = entrada;
            timePickerEntrada.MinDate = entrada;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void Voltar()
        {
            ConsultarEstacionados consultarEstacionados = new ConsultarEstacionados();

            consultarEstacionados.Show();
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            EstadiaRepository estadiaRepository = new EstadiaRepository();

            DateTime apenasData = datePickerEntrada.Value.Date;
            TimeSpan apenasHora = timePickerEntrada.Value.TimeOfDay;
            DateTime saida = apenasData + apenasHora;

            try
            {
                int permanencia = CalculoEstadia.CalcularPermanencia(entrada, saida);
                int valor = CalculoEstadia.ObterValorEstadiaEmCentavos(permanencia);
                if (estadiaRepository.RegistrarSaida(estadiaId,saida.ToString("yyyy-MM-dd HH:mm"), valor)){
                    MessageBox.Show($"Saída registrada com sucesso! Valor = {valor}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Voltar();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro inesperado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void DatePickerEntrada_ValueChanged(object sender, EventArgs e)
        {
            DateTime apenasData = datePickerEntrada.Value.Date;
            TimeSpan apenasHora = timePickerEntrada.Value.TimeOfDay;
            DateTime horario = apenasData + apenasHora;
            if (horario > entrada)
            {
                timePickerEntrada.Value = horario;
            }
            else
            {
                timePickerEntrada.Value = entrada;
            }
            
        }
    }
}
