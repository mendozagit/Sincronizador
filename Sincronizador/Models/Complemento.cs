using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Complemento
    {
        public int ComplementoId { get; set; }
        public string CdPessoaFisica { get; set; }
        public string IeTipoComplemento { get; set; }
        public string NrTelefone { get; set; }
        public string DsEmail { get; set; }
    }
}
