using Microsoft.EntityFrameworkCore;
using Sincronizador.Controller;
using Sincronizador.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sincronizador.Views
{
    public partial class FrmBusqueda : Form
    {

        public Query Query;

        private string SearchText;
        private int Catalogo;

        public FrmBusqueda()
        {
            InitializeComponent();
        }
        public FrmBusqueda(string searchText, int tipoBuscqueda)
        {
            InitializeComponent();
            SearchText = searchText;
            Catalogo = tipoBuscqueda;
            CargaGrid();
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            CargaGrid();
        }

        private void CargaGrid()
        {
            switch (Catalogo)
            {
                case (int)Ambiente.Busquedas.Query:

                    using (var db = new SyncContext())
                    {
                        Grid1.DataSource = db.Query.AsNoTracking()
                             .Where(x => x.Descripcion.Contains(SearchText))
                             .Select(x => new { x.QueryId, x.Clave, x.Descripcion }).ToList();
                    }
                    break;
                default:
                    MessageBox.Show("Error, no hay enumerador para catalogo");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionaRegistro();
            Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Dispose();
        }



        private void Grid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionaRegistro();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Abort;
                this.Dispose();
            }
        }

        private void SeleccionaRegistro()
        {
            if (Grid1.Rows.Count <= 0)
            {
                DialogResult = DialogResult.Abort;
                Dispose();
                return;
            }


            switch (Catalogo)
            {
                case (int)Ambiente.Busquedas.Query:

                    using (var db = new SyncContext())
                    {
                        Query = db.Query.Where(x => x.QueryId == (int)
                        Grid1.Rows[Grid1.CurrentCell.RowIndex].Cells[0].Value).FirstOrDefault();
                    }
                    break;
                default:
                    MessageBox.Show("Error, no hay enumerador para catalogo");
                    break;
            }

            DialogResult = DialogResult.OK;
        }


    }
}
