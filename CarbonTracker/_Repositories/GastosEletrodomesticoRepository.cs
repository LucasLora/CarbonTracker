using CarbonTracker.Models.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using Npgsql;
using System;
using System.Collections.Generic;

namespace CarbonTracker._Repositories
{
    public class GastosEletrodomesticoRepository : BaseRepository, IGastosEletrodomesticoRepository
    {

        #region Construtor

        public GastosEletrodomesticoRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(GastosEletrodomesticoModel gastosEletrodomestico)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO gastoseletrodomestico(idusuario, dia, ideletrodomestico, tempouso)
	                                    VALUES (@idusuario, @dia, @ideletrodomestico, @tempouso);";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = gastosEletrodomestico.IdUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = gastosEletrodomestico.Dia;
                    cmd.Parameters.AddWithValue("@ideletrodomestico", NpgsqlTypes.NpgsqlDbType.Bigint).Value = gastosEletrodomestico.IdEletrodomestico;
                    cmd.Parameters.AddWithValue("@tempouso", NpgsqlTypes.NpgsqlDbType.Real).Value = gastosEletrodomestico.TempoUso;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirPorUsuarioEDia(long idUsuario, DateTime dia)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE gastoseletrodomestico
	                                    WHERE idusuario = @idusuario
                                        AND dia = @dia;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dia;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<GastosEletrodomesticoModel> RetornarPorUsuarioEDia(long idUsuario, DateTime dia)
        {
            var gastosEletrodomesticoList = new List<GastosEletrodomesticoModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * gastoseletrodomestico
	                                    WHERE idusuario = @idusuario
                                        AND dia = @dia;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Date).Value = dia;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var gastosEletrodomestico = new GastosEletrodomesticoModel();
                            gastosEletrodomestico.Id = (long)reader["id"];
                            gastosEletrodomestico.IdUsuario = (long)reader["idusuario"];
                            gastosEletrodomestico.Dia = (DateTime)reader["dia"];
                            gastosEletrodomestico.IdEletrodomestico = (long)reader["ideletrodomestico"];
                            gastosEletrodomestico.TempoUso = (double)reader["tempouso"];
                        }
                    }
                }
            }

            return gastosEletrodomesticoList;
        }

        #endregion

    }
}
