using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sincronizador.Models
{
    public class Parametro
    {
        public int EmpresaId { get; set; }
        public string SucursalId { get; set; }
        public string NoAtencion { get; set; }
        public string NombreMedico { get; set; }

        public string CorreoMedico { get; set; }

        public string NombrePaciente { get; set; }

        public string CorreoPaciente { get; set; }
        public string TelefonoPaciente { get; set; }
        public string TelefonoMedico { get; set; }
        public DateTime FechaAlta { get; set; }

        public int Urgencias { get; set; }

        public string Serializar()
        {
            var s = SucursalId + "|" + NoAtencion + "|" + NombreMedico + "|" + CorreoMedico + "|" + TelefonoMedico + "|" + NombrePaciente + "|" + CorreoPaciente + "|" + TelefonoPaciente + "|" + FechaAlta.ToString("yyyy-MM-dd") + "|" + Urgencias;
            return s;
        }

    }
}
