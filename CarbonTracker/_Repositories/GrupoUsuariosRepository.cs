using CarbonTracker.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace CarbonTracker._Repositories
{
    public class GrupoUsuariosRepository : RepositorioBase, IGrupoUsuariosRepository
    {

        #region Construtor

        public GrupoUsuariosRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(GrupoUsuariosModel grupoUsuariosModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO grupousuario(nome, descricao)
                                        VALUES (@nome, @descricao);";

                    cmd.Parameters.AddWithValue("@nome", NpgsqlDbType.Varchar).Value = grupoUsuariosModel.Nome;
                    cmd.Parameters.AddWithValue("@descricao", NpgsqlDbType.Varchar).Value = grupoUsuariosModel.Descricao;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(GrupoUsuariosModel grupoUsuariosModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE grupousuario
	                                    SET nome=@nome, descricao=@descricao
                                        WHERE id=@id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlDbType.Bigint).Value = grupoUsuariosModel.Id;
                    cmd.Parameters.AddWithValue("@nome", NpgsqlDbType.Varchar).Value = grupoUsuariosModel.Nome;
                    cmd.Parameters.AddWithValue("@descricao", NpgsqlDbType.Varchar).Value = grupoUsuariosModel.Descricao;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(long idUsuario)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE FROM grupousuario
	                                    WHERE id=@id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlDbType.Bigint).Value = idUsuario;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<GrupoUsuariosModel> RetornarTodos()
        {
            var grupoUsuariosList = new List<GrupoUsuariosModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM grupousuario ORDER BY id";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var grupoUsuariosModel = new GrupoUsuariosModel();
                            grupoUsuariosModel.Id = (long)reader["id"];
                            grupoUsuariosModel.Nome = reader["nome"].ToString();
                            grupoUsuariosModel.Descricao = reader["descricao"].ToString();
                            grupoUsuariosList.Add(grupoUsuariosModel);
                        }
                    }
                }
            }

            return grupoUsuariosList;
        }

        public IEnumerable<GrupoUsuariosModel> RetornarPorId(string valor)
        {
            var grupoUsuariosList = new List<GrupoUsuariosModel>();

            long grupoUsuariosId = long.TryParse(valor, out _) ? Convert.ToInt64(valor) : 0;
            string grupoUsuariosNome = valor;

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM grupousuario 
                                        WHERE Id=@Id OR Nome LIKE '%' || @Name || '%'
                                        ORDER BY id";

                    cmd.Parameters.AddWithValue("@Id", grupoUsuariosId);
                    cmd.Parameters.AddWithValue("@Name", grupoUsuariosNome);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var grupoUsuariosModel = new GrupoUsuariosModel();
                            grupoUsuariosModel.Id = (long)reader["id"];
                            grupoUsuariosModel.Nome = reader["nome"].ToString();
                            grupoUsuariosModel.Descricao = reader["descricao"].ToString();
                            grupoUsuariosList.Add(grupoUsuariosModel);
                        }
                    }

                    return grupoUsuariosList;
                }
            }
        }

        #endregion

    }
}
