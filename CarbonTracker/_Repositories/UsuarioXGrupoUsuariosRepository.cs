using CarbonTracker.Models.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using Npgsql;
using System.Collections.Generic;

namespace CarbonTracker._Repositories
{
    public class UsuarioXGrupoUsuariosRepository : BaseRepository, IUsuarioXGrupoUsuariosRepository
    {

        #region Construtor

        public UsuarioXGrupoUsuariosRepository(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        #endregion

        #region Métodos

        public void Adicionar(UsuarioXGrupoUsuariosModel usuarioXGrupoUsuarios)
        {
            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO usuarioxgrupousuarios(idusuario, idgrupo)
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
                    cmd.CommandText = @"DELETE FROM usuarioxgrupousuarios
	                                    WHERE idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<UsuarioXGrupoUsuariosModel> RetornarPorUsuario(long idUsuario)
        {
            var usuarioXGrupoUsuariosList = new List<UsuarioXGrupoUsuariosModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT * FROM usuarioxgrupousuarios 
                                        WHERE idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuarioXGrupoUsuariosModel = new UsuarioXGrupoUsuariosModel();
                            usuarioXGrupoUsuariosModel.IdUsuario = (long)reader["idusuario"];
                            usuarioXGrupoUsuariosModel.IdGrupo = (long)reader["idgrupo"];
                            usuarioXGrupoUsuariosList.Add(usuarioXGrupoUsuariosModel);
                        }
                    }
                }
            }

            return usuarioXGrupoUsuariosList;
        }

        #endregion

    }
}
