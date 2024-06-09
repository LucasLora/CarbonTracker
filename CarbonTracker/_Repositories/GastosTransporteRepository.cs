using CarbonTracker.Models.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker._Repositories
{
    public class GastosTransporteRepository : BaseRepository, IGastosTransporteRepository
    {

        #region Construtor

        public GastosTransporteRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(GastosTransporteModel gastosTransporte)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO gastostransporte(idusuario, dia, idtransporte, kmrodados, qtdepassageiros)
	                                    VALUES (@idusuario, @dia, @idtransporte, @kmrodados, @qtdepassageiros);";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = gastosTransporte.IdUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = gastosTransporte.Dia;
                    cmd.Parameters.AddWithValue("@idtransporte", NpgsqlTypes.NpgsqlDbType.Bigint).Value = gastosTransporte.IdTransporte;
                    cmd.Parameters.AddWithValue("@kmrodados", NpgsqlTypes.NpgsqlDbType.Double).Value = gastosTransporte.KmRodados;
                    cmd.Parameters.AddWithValue("@qtdepassageiros", NpgsqlTypes.NpgsqlDbType.Integer).Value = gastosTransporte.QtdePassageiros;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(GastosTransporteModel gastosTransporte)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE gastostransporte
                                        SET kmrodados = @kmrodados, qtdepassageiros = @qtdepassageiros
                                        WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = gastosTransporte.Id;
                    cmd.Parameters.AddWithValue("@kmrodados", NpgsqlTypes.NpgsqlDbType.Double).Value = gastosTransporte.KmRodados;
                    cmd.Parameters.AddWithValue("@qtdepassageiros", NpgsqlTypes.NpgsqlDbType.Integer).Value = gastosTransporte.QtdePassageiros;

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
                    cmd.CommandText = @"DELETE gastostransporte
	                                    WHERE idusuario = @idusuario
                                        AND dia = @dia;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dia;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<GastosTransporteModel> RetornarPorUsuarioEDia(long idUsuario, DateTime dia)
        {
            var gastosTransporteList = new List<GastosTransporteModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT
                                        	A.id AS IdTransporte,
                                        	A.nome AS NomeNRT,
                                        	A.tipoveiculo AS TipoVeiculoNRT,
                                        	A.tipocombustivel AS TipoCombustivelNRT,
                                        	A.kmporlitrocombustivel AS KmPorLitroCombustivelNRT,
                                        	CAST(COALESCE(B.id, 0) AS BIGINT) AS Id,
                                        	CAST(COALESCE(B.kmrodados, 0) AS DOUBLE PRECISION) AS KmRodados,
                                        	CAST(COALESCE(B.qtdepassageiros, 0) AS INTEGER) AS QtdePassageiros
                                        
                                        FROM transporte A
                                        LEFT JOIN gastostransporte B
                                        	ON B.idtransporte = A.id
                                        	AND B.dia = @dia
                                        	AND B.idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dia;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var gastosTransporte = new GastosTransporteModel();
                            gastosTransporte.Id = (long)reader["id"];
                            gastosTransporte.IdUsuario = idUsuario;
                            gastosTransporte.Dia = dia;
                            gastosTransporte.IdTransporte = (long)reader["idtransporte"];
                            gastosTransporte.KmRodados = (double)reader["kmrodados"];
                            gastosTransporte.QtdePassageiros = (int)reader["qtdepassageiros"];
                            gastosTransporte.NomeNRT = (string)reader["NomeNRT"];
                            gastosTransporte.TipoVeiculoNRT = (TipoVeiculo)reader["TipoVeiculoNRT"];
                            gastosTransporte.TipoCombustivelNRT = (TipoCombustivel)reader["TipoCombustivelNRT"];
                            gastosTransporte.KmPorLitroCombustivelNRT = (double)reader["KmPorLitroCombustivelNRT"];
                            gastosTransporteList.Add(gastosTransporte);
                        }
                    }
                }
            }

            return gastosTransporteList;
        }

        #endregion

    }
}
