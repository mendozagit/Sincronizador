using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class HttpRequestConfig
    {
        public int HttpRequestConfigId { get; set; }
        public string Sucursal { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }
    }
}
