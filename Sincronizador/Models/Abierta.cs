using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Abierta
    {
        public int AbiertaId { get; set; }
        public string NrAtendimento { get; set; }
        public string CdPaciente { get; set; }
        public string CdMedico { get; set; }
        public string CdEstabelecimento { get; set; }
        public string CdUnidadeBasica { get; set; }
        public string CdSetorAtendimento { get; set; }
        public DateTime? DtEntrada { get; set; }
        public DateTime? DtActualizacion { get; set; }
        public DateTime? DtAlta { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
