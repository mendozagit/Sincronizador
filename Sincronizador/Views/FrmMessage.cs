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
    public partial class FrmMessage : Form
    {
        public FrmMessage(string s)
        {
            InitializeComponent();
            txtMensaje.Text = s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
