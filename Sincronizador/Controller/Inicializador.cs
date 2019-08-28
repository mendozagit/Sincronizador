using Sincronizador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sincronizador.Controller
{
    public static class Inicializador
    {
        public static void Inicializar()
        {
            //Oracle connection
            Ambiente.Oracledb = new OracleContext("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = dbprd.cn44gpgzqk7s.us-east-1.rds.amazonaws.com)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = dbprd))); User Id = tasy; Password = aloisk;");

            //Local connection
            using (var db = new SyncContext())
            {
                try
                {
                    if (db.Database.EnsureCreated())
                        Ambiente.Message("No se encotró la base de datos, pero se creó una");
                    

                    var config = db.Configuracion.FirstOrDefault();

                    if (config != null)
                    {

                        Ambiente.Interval = config.Ninterval;
                        Ambiente.MinAbiertas = config.NminAbiertas;
                        Ambiente.IniciarConWin = config.InicarConWindows;
                        Ambiente.NMinCat = config.NminCat;
                        Ambiente.IniciarTimerAuto = config.IniciarTimerAuto;
                        SincronizadorController.Inicializa(Ambiente.Interval);
                    }
                    else
                    {
                        var c = new Configuracion();
                        c.InicarConWindows = true;
                        c.Ninterval = 2000;
                        c.NminAbiertas = 1;
                        c.NminCat = 5;
                        c.IniciarTimerAuto = false;

                        db.Add(c);
                        db.SaveChanges();

                        Ambiente.Interval = c.Ninterval;
                        Ambiente.MinAbiertas = c.NminAbiertas;
                        Ambiente.IniciarConWin = c.InicarConWindows;
                        Ambiente.NMinCat = c.NminCat;
                        Ambiente.IniciarTimerAuto = c.IniciarTimerAuto;
                        SincronizadorController.Inicializa(Ambiente.Interval);
                        Ambiente.Message("No se encontró el registro de configuración, pero se generó uno automáticamente. Configúrelo desde la configuración general.");
                    }
                }
                catch (Exception e)
                {
                    Ambiente.Message(e.Message);
                }

            }



        }
    }
}
