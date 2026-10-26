using EstacionamentoAuthSoft.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoAuthSoft.Repositories
{
    internal class EstadiaRepository
    {
        private readonly string conexaoString = @"Data Source=..\..\Data\estacionamento.db;Version=3;";

        public bool RegistrarEntrada(int veiculoId, string entrada)
        {
            string sqlInsert = "INSERT INTO estadia (veiculo_id, entrada) VALUES (@veiculo_id, @entrada);";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlInsert, conexao))
                {
                    cmd.Parameters.AddWithValue("@veiculo_id", veiculoId);
                    cmd.Parameters.AddWithValue("@entrada", entrada);

                    bool houveLinhasAfetadas = cmd.ExecuteNonQuery() > 0;
                    return houveLinhasAfetadas;
                }
            }

        }

        public bool ContemVeiculoComOIdEstacionado(int veiculoId)
        {
            string sqlSelect = "SELECT COUNT(1) FROM estadia where veiculo_id = @veiculo_id AND saida IS NULL;";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlSelect, conexao))
                {
                    cmd.Parameters.AddWithValue("@veiculo_id", veiculoId);

                    int quantidade = Convert.ToInt32(cmd.ExecuteScalar());

                    return quantidade > 0;
                }
            }
        }

        public int ObterNumeroDeVagasOcupadas()
        {
            string sqlSelect = "SELECT COUNT(1) FROM estadia where saida IS NULL;";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlSelect, conexao))
                {
                    int quantidade = Convert.ToInt32(cmd.ExecuteScalar());

                    return quantidade;
                }
            }
        }
    }
}
