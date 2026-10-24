using EstacionamentoAuthSoft.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoAuthSoft
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroVeiculos cadastroVeiculos = new CadastroVeiculos();

            cadastroVeiculos.Show();

            this.Hide();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarVeiculos cadastroVeiculos = new ListarVeiculos();

            cadastroVeiculos.Show();

            this.Hide();
        }
    }
}
