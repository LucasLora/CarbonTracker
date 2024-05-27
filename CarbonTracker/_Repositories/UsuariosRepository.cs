using System;
using System.Collections.Generic;
using CarbonTracker.Models;
using Npgsql;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker._Repositories
{
    public class UsuariosRepository : BaseRepository, IUsuariosRepository
    {

        #region Construtor

        public UsuariosRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(UsuarioModel UsuariosModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO usuario(nome, senha, email, tipo, datacriacao)
	                                    VALUES (@nome, @senha, @email, @tipo, @datacriacao);";

                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Nome;
                    cmd.Parameters.AddWithValue("@senha", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Senha;
                    cmd.Parameters.AddWithValue("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Email;
                    cmd.Parameters.AddWithValue("@tipo", NpgsqlTypes.NpgsqlDbType.Smallint).Value = (short)UsuariosModel.TipoUsuario;
                    cmd.Parameters.AddWithValue("@datacriacao", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = UsuariosModel.DataCriacao;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(UsuarioModel UsuariosModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE usuario
	                                    SET nome=@nome, senha=@senha, email=@email, tipo=@tipo
	                                    WHERE id=@id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = UsuariosModel.Id;
                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Nome;
                    cmd.Parameters.AddWithValue("@senha", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Senha;
                    cmd.Parameters.AddWithValue("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Email;
                    cmd.Parameters.AddWithValue("@tipo", NpgsqlTypes.NpgsqlDbType.Smallint).Value = (short)UsuariosModel.TipoUsuario;
                    cmd.Parameters.AddWithValue("@datacriacao", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = UsuariosModel.DataCriacao;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(long idusuario)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE FROM usuario
	                                    WHERE id=@id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idusuario;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<UsuarioModel> RetornarTodos()
        {
            var usuarioList = new List<UsuarioModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM usuario 
                                        ORDER BY id";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuariosModel = new UsuarioModel();
                            usuariosModel.Id = (long)reader["id"];
                            usuariosModel.Nome = reader["nome"].ToString();
                            usuariosModel.Senha = reader["senha"].ToString();
                            usuariosModel.Email = reader["email"].ToString();
                            usuariosModel.TipoUsuario = (TipoUsuario)(short)reader["tipo"];
                            usuariosModel.DataCriacao = (DateTime)reader["datacriacao"];
                            usuarioList.Add(usuariosModel);
                        }
                    }
                }
            }

            return usuarioList;
        }

        public IEnumerable<UsuarioModel> RetornarPorId(string valor)
        {
            var usuarioList = new List<UsuarioModel>();

            long usuarioId = long.TryParse(valor, out _) ? Convert.ToInt64(valor) : 0;
            string usuarioNome = valor;

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM usuario 
                                        WHERE Id=@Id OR Nome LIKE '%' || @Name || '%'
                                        ORDER BY id";

                    cmd.Parameters.AddWithValue("@Id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = usuarioId;
                    cmd.Parameters.AddWithValue("@Name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = usuarioNome;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuariosModel = new UsuarioModel();
                            usuariosModel.Id = (long)reader["id"];
                            usuariosModel.Nome = reader["nome"].ToString();
                            usuariosModel.Senha = reader["senha"].ToString();
                            usuariosModel.Email = reader["email"].ToString();
                            usuariosModel.TipoUsuario = (TipoUsuario)(short)reader["tipo"];
                            usuariosModel.DataCriacao = (DateTime)reader["datacriacao"];
                            usuarioList.Add(usuariosModel);
                        }
                    }
                }
            }

            return usuarioList;
        }

        #endregion

    }
}
