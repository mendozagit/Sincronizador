using Sincronizador.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sincronizador.Controller
{
    public static class Ambiente
    {
        public static int NMinCat { get; set; }
        public static bool IniciarTimerAuto { get; set; }
        public static OracleContext Oracledb { get; set; }
        public static int Interval { get; set; }
        public static int MinAbiertas { get; set; }
        public static bool IniciarConWin { get; internal set; }
      
        public enum Busquedas
        {
            Query = 1
        }
        public static string OracleDate(DateTime fecha)
        {
            return " TO_DATE('" + fecha.ToString("yyyy/MM/dd HH:mm:ss") + "', 'YYYY-MM-DD HH24:MI:SS')";
        }


        public static void Message(string s)
        {
            var m = new FrmMessage(s);
            m.ShowDialog();
        }
        public static bool Question(string pregunta, string mensaje = "")
        {

            using (var p = new FrmQuestion(pregunta, mensaje))
            {
                return p.ShowDialog() == DialogResult.Yes ? true : false;

            }
        }
    }
}
