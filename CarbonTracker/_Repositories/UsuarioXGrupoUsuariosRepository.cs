using CarbonTracker.Models.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using Npgsql;
using System.Collections.Generic;

namespace CarbonTracker._Repositories
{
    public class UsuarioXGrupoUsuariosRepository : RepositorioBase, IUsuarioXGrupoUsuariosRepository
    {

        #region Construtor

        public UsuarioXGrupoUsuariosRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(UsuarioXGrupoUsuarios usuarioXGrupoUsuarios)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO usuariogrupo(idusuario, idgrupo)
	                                    VALUES (@idusuario, @idgrupo);";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = usuarioXGrupoUsuarios.IdUsuario;
                    cmd.Parameters.AddWithValue("@idgrupo", NpgsqlTypes.NpgsqlDbType.Bigint).Value = usuarioXGrupoUsuarios.IdGrupo;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirPorUsuario(long idUsuario)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE FROM usuariogrupo
	                                    WHERE idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<UsuarioXGrupoUsuarios> RetornarPorUsuario(long idUsuario)
        {
            var usuarioXGrupoUsuariosList = new List<UsuarioXGrupoUsuarios>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM usuariogrupo 
                                        WHERE idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuarioXGrupoUsuarios = new UsuarioXGrupoUsuarios();
                            usuarioXGrupoUsuarios.IdUsuario = (long)reader["idusuario"];
                            usuarioXGrupoUsuarios.IdGrupo = (long)reader["idgrupo"];
                            usuarioXGrupoUsuariosList.Add(usuarioXGrupoUsuarios);
                        }
                    }
                }
            }

            return usuarioXGrupoUsuariosList;
        }

        #endregion

    }
}
