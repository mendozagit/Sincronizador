using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Unidad
    {
        public int UnidadId { get; set; }
        public string NrSeqInterno { get; set; }
        public string CdUnidadeBasica { get; set; }
        public string CdSetorAtendimento { get; set; }
        public string IeSituacao { get; set; }
        public string IeStatusUnidade { get; set; }
        public string DsUnidadeAtend { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
