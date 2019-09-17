using Sincronizador.Controller;
using System;
using System.Windows.Forms;

namespace Sincronizador.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Inicaliza();
        }
        private void Inicaliza()
        {
            SincronizadorController.lblStatus = LblStatus;
            SincronizadorController.IniciarTimerAuto(Ambiente.IniciarTimerAuto);
            CheckForIllegalCrossThreadCalls = false;
        }
        private void BtnMtoQuerys_Click(object sender, EventArgs e)
        {
            var form = new FrmMtoQueries();
            form.MdiParent = this;
            form.Show();
        }
        private void BtnConfigGral_Click(object sender, EventArgs e)
        {
            var form = new FrmConfig();
            form.MdiParent = this;
            form.Show();
        }
        private void BtnActualizarCat_Click(object sender, EventArgs e)
        {
            SincronizadorController.Update = true;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            SincronizadorController.IniciarTimer();
        }
        private void BtnDetener_Click(object sender, EventArgs e)
        {
            SincronizadorController.DetenerTimer();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (Ambiente.Question("Realmente quiere reiniciar"))
            {
                Application.Restart();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (Ambiente.Question("Realmente terminar la ejecución"))
            {
                Application.Restart();
            }
        }

        private void BtnLanzar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSectores_Click(object sender, EventArgs e)
        {
            var form = new FrmSectores();
            form.MdiParent = this;
            form.Show();
        }
    }
}
