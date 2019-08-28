using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Query
    {
        public int QueryId { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public DateTime UltSincronizacion { get; set; }
        public string ComandoSql { get; set; }
        public bool Vigente { get; set; }
        public bool Parametrizar { get; set; }
    }
}
