using System;
using System.Collections.Generic;

namespace Sincronizador.Models
{
    public partial class Configuracion
    {
        public int ConfiguracionId { get; set; }
        public bool InicarConWindows { get; set; }
        public int Ninterval { get; set; }
        public int NminAbiertas { get; set; }
        public bool IniciarTimerAuto { get; set; }
        public int NminCat { get; set; }
    }
}
