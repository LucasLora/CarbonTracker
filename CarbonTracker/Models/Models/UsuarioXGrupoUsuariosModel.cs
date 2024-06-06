using Npgsql.Replication.PgOutput;

namespace CarbonTracker.Models.Models
{
    public class UsuarioXGrupoUsuariosModel
    {

        #region Properties

        public long IdUsuario { get; set; }
        public long IdGrupo { get; set; }
        public string NomeGrupoNRT { get; set; }
        public string DescricaoGrupoNRT { get; set; }
        public bool PresenteNRT { get; set; }

        #endregion

    }
}
