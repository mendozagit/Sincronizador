using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class HttpRequest
    {
        public int HttpRequestId { get; set; }
        public string NrAtendimento { get; set; }
        public DateTime? DtEntrada { get; set; }
        public DateTime? DtAlta { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Parametros { get; set; }
        public string HttpResponse { get; set; }
        public bool? SuccessfulRequest { get; set; }
    }
}
