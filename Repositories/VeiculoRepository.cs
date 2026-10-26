using EstacionamentoAuthSoft.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoAuthSoft.Repositories
{
    internal class VeiculoRepository
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
                    cmd.Parameters.AddWithValue("@cor", cor);

                    bool houveLinhasAfetadas = cmd.ExecuteNonQuery() > 0;
                    return houveLinhasAfetadas;
                }
            }

        }

        public List<Veiculo> ObterTodosOsVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            string sqlSelect = "SELECT id, placa, modelo, cor FROM veiculo;";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlSelect, conexao))
                {
                    using (SQLiteDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            Veiculo veiculo = new Veiculo(
                                Convert.ToInt32(leitor["id"]),
                                leitor["placa"].ToString(),
                                leitor["modelo"].ToString(),
                                leitor["cor"].ToString()
                            );

                            veiculos.Add(veiculo);
                        }
                    }
                }
            }

            return veiculos;
        }

        public List<string> ObterTodasAsPlacas()
        {
            List<string> placas = new List<string>();
            string sqlSelect = "SELECT id, placa FROM veiculo;";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlSelect, conexao))
                {
                    using (SQLiteDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            placas.Add(leitor["placa"].ToString());
                        }
                        
                    }
                }
            }

            return placas;
        }

        public int ObterIdPelaPlaca(string placa)
        {
            string sqlSelect = "SELECT id FROM veiculo where placa = @placa;";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlSelect, conexao))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);

                    using (SQLiteDataReader leitor = cmd.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            return Convert.ToInt32(leitor["id"]);
                        }

                    }
                }
            }

            return -1;
        }

        public bool Editar(int id, string placa, string modelo, string cor)
        {
            string sqlUpdate = "Update Veiculo " +
                "set placa = @placa, modelo = @modelo, cor = @cor " +
                "where id = @id;";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlUpdate, conexao))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@cor", cor);
                    cmd.Parameters.AddWithValue("@id", id);

                    bool houveLinhasAfetadas = cmd.ExecuteNonQuery() > 0;
                    return houveLinhasAfetadas;
                }
            }
        }

        public bool Excluir(int id)
        {
            string sqlDelete = "Delete from veiculo " +
                "where id = @id;";

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sqlDelete, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    bool houveLinhasAfetadas = cmd.ExecuteNonQuery() > 0;
                    return houveLinhasAfetadas;
                }
            }
        }
    }
}
