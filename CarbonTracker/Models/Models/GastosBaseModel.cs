using System;

namespace CarbonTracker.Models.Models
{
    public abstract class GastosBaseModel
    {

        #region Propriedades

        public long Id { get; set; }

        public long IdUsuario { get; set; }
        
        public DateTime Dia { get; set; }

        #endregion

    }
}
