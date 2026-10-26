using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoAuthSoft.Utils
{
    internal class Placa
    {
        public static string FormatarPlaca(string placa)
        {
            if (placa.Length >= 4 && placa[3] == '-')
            {
                placa = placa.Remove(3, 1);
            }

            return placa.ToUpper();
        }

        public static bool ValidarPlaca(string placa)
        {
            string padrao = @"^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$";

            bool placaevalida = Regex.IsMatch(placa, padrao);
            if (!placaevalida)
            {
                MessageBox.Show("O campo de placa deve conter o formato antigo 'ABC1234' ou Mercosul 'ABC1D23'", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return placaevalida;
        }
    }
}
