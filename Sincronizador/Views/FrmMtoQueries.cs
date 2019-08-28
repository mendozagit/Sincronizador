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
    public partial class FrmMtoQueries : Form
    {
        QueryController queryController;
        Query query;

        public FrmMtoQueries()
        {
            InitializeComponent();
            Inicializa();
        }

        #region Metodos 
        private void Inicializa()
        {
            query = null;
            queryController = new QueryController();
        }
        private void Reset()
        {
            query = null;
        }
        private void InsertOrUpdate()
        {
            //Probar el query vs tasy db
            if (Parametrizar.Checked)
            {
                var sql = TxtSql.Text.Trim() + Ambiente.OracleDate(DpFecha.Value);
                if (Ambiente.Oracledb.Probar(sql))
                {
                    Ambiente.Message("Query exitoso");

                }
                else
                {
                    Ambiente.Message("Proceso abortado, el query no es válido.");
                    return;
                }
            }
            else
            {
                if (Ambiente.Oracledb.Probar(TxtSql.Text.Trim()))
                {
                    Ambiente.Message("Query exitoso");
                }
                else
                {
                    Ambiente.Message("Proceso abortado, el query no es válido.");
                    return;
                }
            }

            //Llenado del objeto
            if (query == null)
            {
                query = new Query();
                LlenaObjeto();
                if (queryController.InsertOne(query))
                    Ambiente.Message("Proceso concluido con éxito");
            }
            else
            {

                LlenaObjeto();
                if (queryController.Update(query))
                    Ambiente.Message("Proceso concluido con éxito");
            }
        }
        private void LlenaObjeto()
        {
            if (query == null)
                return;

            if (string.IsNullOrEmpty(TxtClave.Text.Trim()) || string.IsNullOrEmpty(TxtDescrip.Text.Trim()) || string.IsNullOrEmpty(TxtSql.Text.Trim()))
            {
                Ambiente.Message("Proceso abortado, todos los campos son obligatorios");
                return;
            }

            query.Clave = TxtClave.Text.Trim();
            query.Descripcion = TxtDescrip.Text;
            query.ComandoSql = TxtSql.Text.Trim();
            query.Parametrizar = Parametrizar.Checked;
            query.UltSincronizacion = DpFecha.Value;
            query.Vigente = Vigente.Checked;
        }
        private void LlenaCampos()
        {
            if (query == null)
                return;
            TxtClave.Text = query.Clave;
            TxtDescrip.Text = query.Descripcion;
            TxtSql.Text = query.ComandoSql;
            Parametrizar.Checked = query.Parametrizar;
            Vigente.Checked = query.Vigente;
            DpFecha.Value = (DateTime)query.UltSincronizacion;
        }
        #endregion

        #region Eventos
        private void TxtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var form = new FrmBusqueda(TxtClave.Text, (int)Ambiente.Busquedas.Query))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        query = form.Query;
                        LlenaCampos();
                    }
                }
            }

        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            InsertOrUpdate();
            Close();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion
    }
}
