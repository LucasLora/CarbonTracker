using System;
using System.Collections.Generic;
using CarbonTracker.Models;
using Npgsql;

namespace CarbonTracker._Repositories
{
    public class EletrodomesticoRepository : RepositorioBase, IEletrodomesticoRepository
    {

        #region Construtor

        public EletrodomesticoRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(EletrodomesticoModel eletrodomesticoModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO eletrodomestico(id, nome, litroporhoraagua, kwporhoraeletricidade)
                                        VALUES (default, @nome, @litroporhoraagua, @kwporhoraeletricidade);";

                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = eletrodomesticoModel.Nome;
                    cmd.Parameters.AddWithValue("@litroporhoraagua", NpgsqlTypes.NpgsqlDbType.Double).Value = eletrodomesticoModel.LitroPorHoraAgua;
                    cmd.Parameters.AddWithValue("@kwporhoraeletricidade", NpgsqlTypes.NpgsqlDbType.Double).Value = eletrodomesticoModel.KWPorHoraEletricidade;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(EletrodomesticoModel eletrodomesticoModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE eletrodomestico
	                                    SET nome=@nome, litroporhoraagua=@litroporhoraagua, kwporhoraeletricidade=@kwporhoraeletricidade
	                                    WHERE id=@id";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = eletrodomesticoModel.Id;
                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = eletrodomesticoModel.Nome;
                    cmd.Parameters.AddWithValue("@litroporhoraagua", NpgsqlTypes.NpgsqlDbType.Double).Value = eletrodomesticoModel.LitroPorHoraAgua;
                    cmd.Parameters.AddWithValue("@kwporhoraeletricidade", NpgsqlTypes.NpgsqlDbType.Double).Value = eletrodomesticoModel.KWPorHoraEletricidade;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(long idEletrodomestico)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE FROM eletrodomestico
	                                    WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idEletrodomestico;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<EletrodomesticoModel> RetornarTodos()
        {
            var eletrodomesticoList = new List<EletrodomesticoModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM eletrodomestico ORDER BY id";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var eletrodomesticoModel = new EletrodomesticoModel();
                            eletrodomesticoModel.Id = (long)reader["id"];
                            eletrodomesticoModel.Nome = reader["nome"].ToString();
                            eletrodomesticoModel.LitroPorHoraAgua = (double)reader["litroporhoraagua"];
                            eletrodomesticoModel.KWPorHoraEletricidade = (double)reader["kwporhoraeletricidade"];
                            eletrodomesticoList.Add(eletrodomesticoModel);
                        }
                    }
                }
            }

            return eletrodomesticoList;
        }

        public IEnumerable<EletrodomesticoModel> RetornarPorId(string valor)
        {
            var eletrodomesticoList = new List<EletrodomesticoModel>();

            long eletrodomesticoId = long.TryParse(valor, out _) ? Convert.ToInt64(valor) : 0;
            string eletrodomesticoNome = valor;

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM eletrodomestico 
                                        WHERE Id = @Id OR Nome LIKE '%' || @Name || '%'
                                        ORDER BY id";

                    cmd.Parameters.AddWithValue("@Id", eletrodomesticoId);
                    cmd.Parameters.AddWithValue("@Name", eletrodomesticoNome);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var eletrodomesticoModel = new EletrodomesticoModel();
                            eletrodomesticoModel.Id = (long)reader["id"];
                            eletrodomesticoModel.Nome = reader["nome"].ToString();
                            eletrodomesticoModel.LitroPorHoraAgua = (double)reader["litroporhoraagua"];
                            eletrodomesticoModel.KWPorHoraEletricidade = (double)reader["kwporhoraeletricidade"];

                            eletrodomesticoList.Add(eletrodomesticoModel);
                        }
                    }
                }
            }

            return eletrodomesticoList;
        }

        #endregion

    }
}
