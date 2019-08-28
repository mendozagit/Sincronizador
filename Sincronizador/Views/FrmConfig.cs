using Sincronizador.Controller;
using Sincronizador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sincronizador.Views
{
    public partial class FrmConfig : Form
    {
        private ConfiguracionController configuracionController;
        private Configuracion config;
        public FrmConfig()
        {
            InitializeComponent();
            configuracionController = new ConfiguracionController();
            config = null;
            LlenaCampos();
        }

        private void LlenaCampos()
        {
            config = configuracionController.SelectTopOne();
            ChLanzarConWindows.Checked = config.InicarConWindows;
            Ninterval.Value = config.Ninterval;
            NMinAbiertas.Value = config.NminAbiertas;
            NMinCat.Value = config.NminCat;
            ChkLanzarTimer.Checked = config.IniciarTimerAuto;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (config == null)
            {
                Ambiente.Message("No se encontró el objeto para actualizar");
                return;
            }

            config = configuracionController.SelectTopOne();
            config.InicarConWindows = ChLanzarConWindows.Checked;
            config.Ninterval = (int)Ninterval.Value;
            config.NminAbiertas = (int)NMinAbiertas.Value;
            config.NminCat = (int)NMinCat.Value;
            config.IniciarTimerAuto = ChkLanzarTimer.Checked;

            if (configuracionController.Update(config))
            {
                Ambiente.Message("Proceso concluido con éxito");
                Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
