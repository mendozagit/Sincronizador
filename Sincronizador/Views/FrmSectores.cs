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
    public partial class FrmSectores : Form
    {
        private SectorController sectorController;

        public FrmSectores()
        {
            InitializeComponent();
            Inicializa();
        }
        private void Inicializa()
        {
            sectorController = new SectorController();
            Malla.DataSource = sectorController.SelectAll();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }
        private void GuardarCambios()
        {
            using (var db = new SyncContext())
            {
                foreach (DataGridViewRow row in Malla.Rows)
                {
                    var s = db.Sector.FirstOrDefault(x => x.SectorId == (int)row.Cells[0].Value);
                    s.LanzaHttprequest = (bool)row.Cells[8].Value;
                    s.Urgencias = (bool)row.Cells[9].Value;
                    db.Update(s);
                }
                db.SaveChanges();
                Ambiente.Message("Cambios guardados");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
