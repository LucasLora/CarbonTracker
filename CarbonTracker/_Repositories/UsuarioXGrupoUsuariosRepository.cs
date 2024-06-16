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

        public IEnumerable<UsuarioXGrupoUsuariosModel> RetornarTodosGruposComInformacoesDePresencaDoUsuario(long idUsuario)
        {
            var usuarioXGrupoUsuariosList = new List<UsuarioXGrupoUsuariosModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT
                                            A.id AS IdGrupo,
                                            A.nome AS NomeGrupoNRT,
                                            A.descricao AS DescricaoGrupoNRT,
                                            CAST(COALESCE(B.idgrupo, 0) AS SMALLINT) AS PresencaNRT
                                        	
                                        FROM grupousuario A
                                        LEFT JOIN usuarioxgrupousuarios B 
                                            ON B.idgrupo = A.id
                                            AND B.idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuarioXGrupoUsuariosModel = new UsuarioXGrupoUsuariosModel();
                            usuarioXGrupoUsuariosModel.IdUsuario = idUsuario;
                            usuarioXGrupoUsuariosModel.IdGrupo = (long)reader["idgrupo"];
                            usuarioXGrupoUsuariosModel.NomeGrupoNRT = reader["nomegruponrt"].ToString();
                            usuarioXGrupoUsuariosModel.DescricaoGrupoNRT = reader["descricaogruponrt"].ToString();
                            usuarioXGrupoUsuariosModel.PresenteNRT = (short)reader["presencanrt"] == 0 ? false : true;
                            usuarioXGrupoUsuariosList.Add(usuarioXGrupoUsuariosModel);
                        }
                    }
                }
            }

            return usuarioXGrupoUsuariosList;
        }

        public IEnumerable<UsuarioXGrupoUsuariosModel> RetornarTodosGruposQueOUsuarioEhParticipante(long idUsuario)
        {
            var usuarioXGrupoUsuariosList = new List<UsuarioXGrupoUsuariosModel>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT 
                                        	A.idusuario,
                                        	A.idgrupo,
                                        	B.nome AS NomeGrupoNRT,
                                        	B.Descricao AS DescricaoGrupoNRT
                                        
                                        FROM usuarioxgrupousuarios A
                                        INNER JOIN grupousuario B 
                                        	ON B.id = A.idgrupo
                                        
                                        WHERE A.idusuario = @idusuario;";

                    cmd.Parameters.AddWithValue("@idusuario", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idUsuario;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuarioXGrupoUsuariosModel = new UsuarioXGrupoUsuariosModel();
                            usuarioXGrupoUsuariosModel.IdUsuario = (long)reader["idusuario"];
                            usuarioXGrupoUsuariosModel.IdGrupo = (long)reader["idgrupo"];
                            usuarioXGrupoUsuariosModel.NomeGrupoNRT = reader["NomeGrupoNRT"].ToString();
                            usuarioXGrupoUsuariosModel.DescricaoGrupoNRT = reader["DescricaoGrupoNRT"].ToString();
                            usuarioXGrupoUsuariosList.Add(usuarioXGrupoUsuariosModel);
                        }
                    }
                }
            }

            return usuarioXGrupoUsuariosList;
        }  
        
        public IEnumerable<long> RetornarTodosIdsUsuariosPorGrupo(long idGrupo)
        {
            var ids = new List<long>();

            using (var conn = new NpgsqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT 
                                        	A.idusuario
                                        	
                                        FROM usuarioxgrupousuarios A
                                        
                                        WHERE idgrupo = @idgrupo;";

                    cmd.Parameters.AddWithValue("@idgrupo", NpgsqlTypes.NpgsqlDbType.Bigint).Value = idGrupo;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ids.Add((long)reader["idusuario"]);
                        }
                    }
                }
            }

            return ids;
        }

        #endregion

    }
}
