using EstacionamentoAuthSoft.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoAuthSoft.Repositories
{
    internal class VeiculoRepositorie
    {
        private readonly string conexaoString = @"Data Source=..\..\Data\estacionamento.db;Version=3;";

        public bool Cadastrar(string placa, string modelo, string cor)
        {
            string sqlInsert = "INSERT INTO Veiculo (Placa, Modelo, Cor) VALUES (@placa, @modelo, @cor);";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlInsert, conexao))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@cor", modelo);

                    bool houveLinhasAfetadas = cmd.ExecuteNonQuery() > 0;
                    return houveLinhasAfetadas;
                }
            }

        }
    }
}
