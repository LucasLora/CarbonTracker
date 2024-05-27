using System;
using System.Collections.Generic;
using CarbonTracker.Models;
using Npgsql;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker._Repositories
{
    public class TransporteRepository : BaseRepository, ITransporteRepository
    {

        #region Construtor

        public TransporteRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(TransporteModel transporteModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO transporte(nome, tipoveiculo, tipocombustivel, kmporlitrocombustivel)
	                                    VALUES (@nome, @tipoveiculo, @tipocombustivel, @kmporlitrocombustivel);";

                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = transporteModel.Nome;
                    cmd.Parameters.AddWithValue("@tipoveiculo", NpgsqlTypes.NpgsqlDbType.Smallint).Value = (short)transporteModel.TipoVeiculo;
                    cmd.Parameters.AddWithValue("@tipocombustivel", NpgsqlTypes.NpgsqlDbType.Smallint).Value = (short)transporteModel.TipoCombustivel;
                    cmd.Parameters.AddWithValue("@kmporlitrocombustivel", NpgsqlTypes.NpgsqlDbType.Real).Value = transporteModel.KmPorLitroCombustivel;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(TransporteModel transporteModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE transporte
	                                    SET nome=@nome, tipoveiculo=@tipoveiculo, tipocombustivel=@tipocombustivel, kmporlitrocombustivel=@kmporlitrocombustivel
	                                    WHERE id=@id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = transporteModel.Id;
                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = transporteModel.Nome;
                    cmd.Parameters.AddWithValue("@tipoveiculo", NpgsqlTypes.NpgsqlDbType.Smallint).Value = (short)transporteModel.TipoVeiculo;
                    cmd.Parameters.AddWithValue("@tipocombustivel", NpgsqlTypes.NpgsqlDbType.Smallint).Value = (short)transporteModel.TipoCombustivel;
                    cmd.Parameters.AddWithValue("@kmporlitrocombustivel", NpgsqlTypes.NpgsqlDbType.Real).Value = transporteModel.KmPorLitroCombustivel;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(long idTransporte)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE FROM transporte
	                                    WHERE id=@id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idTransporte;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TransporteModel> RetornarTodos()
        {
            var transporteList = new List<TransporteModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM transporte
                                        ORDER BY id";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transporteModel = new TransporteModel();
                            transporteModel.Id = (long)reader["id"];
                            transporteModel.Nome = reader["nome"].ToString();
                            transporteModel.TipoVeiculo =  (TipoVeiculo)(short)reader["tipoveiculo"];
                            transporteModel.TipoCombustivel = (TipoCombustivel)(short)reader["tipocombustivel"];
                            transporteModel.KmPorLitroCombustivel = (double)reader["KmPorLitroCombustivel"];
                            transporteList.Add(transporteModel);
                        }
                    }
                }
            }

            return transporteList;
        }

        public IEnumerable<TransporteModel> RetornarPorId(string valor)
        {
            var transporteList = new List<TransporteModel>();

            long transporteId = long.TryParse(valor, out _) ? Convert.ToInt64(valor) : 0;
            string transporteNome = valor;

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM transporte 
                                        WHERE Id=@Id OR Nome LIKE '%' || @Name || '%'
                                        ORDER BY id";

                    cmd.Parameters.AddWithValue("@Id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = transporteId;
                    cmd.Parameters.AddWithValue("@Name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = transporteNome;
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var transporteModel = new TransporteModel();
                            transporteModel.Id = (long)reader["id"];
                            transporteModel.Nome = reader["nome"].ToString();
                            transporteModel.TipoVeiculo = (TipoVeiculo)(short)reader["tipoveiculo"];
                            transporteModel.TipoCombustivel = (TipoCombustivel)(short)reader["tipocombustivel"];
                            transporteModel.KmPorLitroCombustivel = (double)reader["KmPorLitroCombustivel"];
                            transporteList.Add(transporteModel);
                        }
                    }
                }
            }

            return transporteList;
        }

        #endregion

    }
}
