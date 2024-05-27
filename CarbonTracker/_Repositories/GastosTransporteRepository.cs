using CarbonTracker.Models.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using Npgsql;
using System;
using System.Collections.Generic;

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
                    cmd.Parameters.AddWithValue("@kmrodados", NpgsqlTypes.NpgsqlDbType.Real).Value = gastosTransporte.KmRodados;
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
                    cmd.CommandText = @"SELECT * gastostransporte
	                                    WHERE idusuario = @idusuario
                                        AND dia = @dia;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;
                    cmd.Parameters.AddWithValue("@dia", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dia;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var gastosTransporte = new GastosTransporteModel();
                            gastosTransporte.Id = (long)reader["id"];
                            gastosTransporte.IdUsuario = (long)reader["idusuario"];
                            gastosTransporte.Dia = (DateTime)reader["dia"];
                            gastosTransporte.IdTransporte = (long)reader["idtransporte"];
                            gastosTransporte.KmRodados = (double)reader["kmrodados"];
                            gastosTransporte.QtdePassageiros = (int)reader["qtdepassageiros"];
                        }
                    }
                }
            }

            return gastosTransporteList;
        }

        #endregion

    }
}
