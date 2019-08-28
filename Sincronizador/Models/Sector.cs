using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Sector
    {
        public int SectorId { get; set; }
        public string CdSetorAtendimento { get; set; }
        public string DsSetorAtendimento { get; set; }
        public string NmUnidadeBasica { get; set; }
        public string IeSituacao { get; set; }
        public string DsDescricao { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
