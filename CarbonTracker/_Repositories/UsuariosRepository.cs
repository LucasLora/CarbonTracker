using CarbonTracker.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker._Repositories
{
    public class UsuariosRepository : RepositorioBase, IUsuariosRepository
    { 
        
        //Construtor
        public UsuariosRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        //Métodos
        public void Adicionar(UsuariosModel UsuariosModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO public.usuario(id, nome, senha, email, tipo, datacriacao)
	                                    VALUES (default, @nome, @senha, @email, @tipo, @datacriacao);";

                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Nome;
                    cmd.Parameters.AddWithValue("@senha", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Senha;
                    cmd.Parameters.AddWithValue("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Email;
                    cmd.Parameters.AddWithValue("@tipo", NpgsqlTypes.NpgsqlDbType.Smallint).Value = UsuariosModel.TipoUsuarios;
                    cmd.Parameters.AddWithValue("@datacriacao", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = UsuariosModel.DataCriacao;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Alterar(UsuariosModel UsuariosModel)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE public.usuario
	                                    SET nome=@nome, senha=@senha, email=@email, tipo=@tipo, datacriacao=@datacriacao
	                                    WHERE id=@id;";

                    cmd.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Bigint).Value = UsuariosModel.Id;
                    cmd.Parameters.AddWithValue("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = UsuariosModel.Nome;
                    cmd.Parameters.AddWithValue("@senha", NpgsqlTypes.NpgsqlDbType.Smallint).Value = UsuariosModel.Senha;
                    cmd.Parameters.AddWithValue("@email", NpgsqlTypes.NpgsqlDbType.Smallint).Value = UsuariosModel.Email;
                    cmd.Parameters.AddWithValue("@tipo", NpgsqlTypes.NpgsqlDbType.Double).Value = UsuariosModel.TipoUsuarios;
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

        public IEnumerable<UsuariosModel> RetornarTodos()
        {
            var usuarioList = new List<UsuariosModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM usuario ORDER BY id";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var UsuariosModel = new UsuariosModel();
                            UsuariosModel.Id = (long)reader["id"];
                            UsuariosModel.Nome = reader["nome"].ToString();
                            UsuariosModel.Senha = reader["senha"].ToString();
                            UsuariosModel.Email = reader["email"].ToString(); 
                            UsuariosModel.TipoUsuarios = (TipoUsuario)(short)reader["tipo"];
                            UsuariosModel.DataCriacao = (DateTime)reader["datacriacao"];
                            usuarioList.Add(UsuariosModel);
                        }
                    }
                }
            }

            return usuarioList;
        }

        public IEnumerable<UsuariosModel> RetornarPorId(string valor)
        {
            var usuarioList = new List<UsuariosModel>();

            long usuarioId = long.TryParse(valor, out _) ? Convert.ToInt64(valor) : 0;
            string usuarioNome = valor;

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = @"SELECT * FROM usuario 
                                        WHERE Id = @Id OR Nome LIKE '%' || @Name || '%'
                                        ORDER BY id";

                    cmd.Parameters.AddWithValue("@Id", usuarioId);
                    cmd.Parameters.AddWithValue("@Name", usuarioNome);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var UsuariosModel = new UsuariosModel();
                            UsuariosModel.Id = (long)reader["id"];
                            UsuariosModel.Nome = reader["nome"].ToString();
                            UsuariosModel.Senha = reader["senha"].ToString();
                            UsuariosModel.Email = reader["email"].ToString();
                            UsuariosModel.TipoUsuarios = (TipoUsuario)(short)reader["tipo"];
                            UsuariosModel.DataCriacao = (DateTime)reader["datacriacao"];
                            usuarioList.Add(UsuariosModel);
                        }
                    }
                }
            }

            return usuarioList;
        }
    }
}
