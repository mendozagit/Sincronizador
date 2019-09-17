using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class HttpRequest
    {
        public int HttpRequestId { get; set; }
        public string NrAtendimento { get; set; }
        public DateTime? DtAlta { get; set; }
        public string Parametros { get; set; }
        public bool Enviado { get; set; }
        public DateTime? Fenvio { get; set; }
        public bool SuccessfulRequest { get; set; }
        public string HttpResponse { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
