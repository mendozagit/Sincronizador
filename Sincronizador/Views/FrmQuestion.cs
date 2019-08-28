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
    public partial class FrmQuestion : Form
    {
        private string pregunta;
        private string mensaje;

        public FrmQuestion()
        {
            InitializeComponent();
        }

        public FrmQuestion(string pregunta, string mensaje = "")
        {
            InitializeComponent();
            this.pregunta = pregunta;
            this.mensaje = mensaje;
            txtMensaje.Text = mensaje.Trim().Length == 0 ? "" : mensaje + Environment.NewLine;
            txtMensaje.Text += "¿" + pregunta + "?";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.No;
            Close();
        }
    }
}
