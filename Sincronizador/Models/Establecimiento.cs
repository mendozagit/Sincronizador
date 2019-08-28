using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Establecimiento
    {
        public int EstablecimientoId { get; set; }
        public string CdEstabelecimento { get; set; }
        public string NmFantasiaEstab { get; set; }
        public string NmSiglaEstab { get; set; }
        public string IeTipoCtbEstab { get; set; }
        public string IeAreaEstab { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
