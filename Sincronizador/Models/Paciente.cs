using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Paciente
    {
        public int PacienteId { get; set; }
        public string CdPessoaFisica { get; set; }
        public string NmPessoaFisica { get; set; }
        public string NmUsuario { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string IeSexo { get; set; }
        public string NmAbreviado { get; set; }
        public string CdCurp { get; set; }
        public string CdRfc { get; set; }
        public string NmPrimeiroNome { get; set; }
        public string NmSobrenomePai { get; set; }
        public string NmSobrenomeMae { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
