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
    public partial class RegistrarSaida : Form
    {
        public RegistrarSaida(string placa)
        {
            InitializeComponent();
            txtPlaca.Text = placa;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            ConsultarEstacionados consultarEstacionados = new ConsultarEstacionados();

            consultarEstacionados.Show();
            this.Close();
        }
    }
}
