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
                    cmd.Parameters.AddWithValue("@tempouso", NpgsqlTypes.NpgsqlDbType.Double).Value = gastosEletrodomestico.TempoUso;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(GastosEletrodomesticoModel gastosEletrodomestico)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE gastoseletrodomestico
                                        SET tempouso = @tempouso
                                        WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = gastosEletrodomestico.Id;
                    cmd.Parameters.AddWithValue("@tempouso", NpgsqlTypes.NpgsqlDbType.Double).Value = gastosEletrodomestico.TempoUso;

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
                    cmd.CommandText = @"SELECT 
                                        	A.id AS IdEletrodomestico,
                                        	A.nome AS NomeNRT,
                                        	A.litroporhoraagua AS LitroPorHoraAguaNRT,
                                        	A.kwporhoraeletricidade AS KwPorHoraEletricidadeNRT,	
 	                                        CAST(COALESCE(B.id, 0) AS BIGINT) AS Id,
                                         	CAST(COALESCE(B.tempouso, 0) AS DOUBLE PRECISION) AS TempoUso
                                         
                                        FROM eletrodomestico A
                                        LEFT JOIN gastoseletrodomestico B
                                        	ON B.ideletrodomestico = A.id
                                        	AND B.dia = @dia
                                        	AND B.idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Date).Value = dia;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {   
                            var gastosEletrodomestico = new GastosEletrodomesticoModel();
                            gastosEletrodomestico.Id = (long)reader["Id"];
                            gastosEletrodomestico.IdUsuario = idUsuario;
                            gastosEletrodomestico.Dia = dia;
                            gastosEletrodomestico.IdEletrodomestico = (long)reader["IdEletrodomestico"];
                            gastosEletrodomestico.TempoUso = (double)reader["TempoUso"];
                            gastosEletrodomestico.NomeNRT = (string)reader["NomeNRT"];
                            gastosEletrodomestico.LitroPorHoraAguaNRT = (double)reader["LitroPorHoraAguaNRT"];
                            gastosEletrodomestico.KWPorHoraEletricidadeNRT = (double)reader["KwPorHoraEletricidadeNRT"];
                            gastosEletrodomesticoList.Add(gastosEletrodomestico);
                        }
                    }
                }
            }

            return gastosEletrodomesticoList;
        }

        #endregion

    }
}
