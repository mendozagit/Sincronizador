using Sincronizador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Sincronizador.Controller
{
    public static class SincronizadorController
    {
        public static ToolStripStatusLabel lblStatus;
        public static BackgroundWorker worker;
        public static Timer timer;

        public static int i;
        public static string s;
        public static bool Update;
        public static bool success;
        public static bool ocupado;

        //controladores
        private static AbiertaController abiertaController;
        private static AltaController altaController;
        private static ConfiguracionController configuracionController;
        private static EstablecimientoController establecimientoController;
        private static MedicoController medicoController;
        private static PacienteController pacienteController;
        private static QueryController queryController;
        private static SectorController sectorController;
        private static UnidadController unidadController;
        private static ComplementoController complementoController;
        private static RequestController requestController;

        //Listas
        private static List<Abierta> abiertas;

        public static void Inicializa(int milliseconds)
        {
            //Configuracion del subproceso (hilo)
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);




            //Configuracion del timer
            timer = new Timer();
            timer.Interval = milliseconds;

            timer.Tick += new EventHandler(Timer_Tick);

            //Configuracion de controladores
            abiertaController = new AbiertaController();
            altaController = new AltaController();
            configuracionController = new ConfiguracionController();
            establecimientoController = new EstablecimientoController();
            medicoController = new MedicoController();
            pacienteController = new PacienteController();
            queryController = new QueryController();
            sectorController = new SectorController();
            unidadController = new UnidadController();
            complementoController = new ComplementoController();
            requestController = new RequestController();

            //Listas
            abiertas = new List<Abierta>();
            ocupado = true;
        }
        public static void IniciarTimerAuto(bool iniciarTimerAuto)
        {
            if (!timer.Enabled && iniciarTimerAuto)
                timer.Enabled = true;
        }
        private static void WriteStatus(string tabla, int i, int f)
        {
            lblStatus.BackColor = SystemColors.ButtonFace;
            lblStatus.Text = "SINCRONIZANDO " + tabla + ": " + i + " DE " + f + " REGISTROS";
        }
        public static void WriteStatus(string s)
        {
            lblStatus.BackColor = SystemColors.ButtonFace;
            lblStatus.Text = s;
        }
        public static void IniciarTimer()
        {
            if (!timer.Enabled)
                timer.Enabled = true;
            else
                Ambiente.Message("El subproceso ya está corriendo.");

        }
        public static void DetenerTimer()
        {

            timer.Enabled = false;
        }
        private static void Timer_Tick(object sender, EventArgs e)
        {
            if (worker.IsBusy)
                WriteTimeOut();
            else
                worker.RunWorkerAsync();
        }
        private static void WriteTimeOut()
        {
            lblStatus.BackColor = Color.Red;
            lblStatus.Text = "LA LATENCIA SUPERÓ EL TIEMPO DE LA OPERACIÓN [SUBA EL TIMER]";
        }
        private static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Sincronizar();
        }
        private static void Sincronizar()
        {
            ocupado = true;
            StatusCatalogos();

            if (Update)
                UpdateCat();

            var queries = queryController.SelectAll();
            try
            {
                foreach (var q in queries)
                {
                    switch (q.Clave)
                    {
                        case "ALTAS":
                            SincronizarAltas(q);
                            break;

                        case "ABIERTAS":
                            SincronizarAbiertas(q);
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteStatus(ex.Message);
            }
            ocupado = false;
        }
        private static void StatusCatalogos()
        {

        }
        private static void UpdateCat()
        {

            var Sqlestablecimientos = "select * from estabelecimento";
            var Sqlunidades = "select * from unidade_atendimento";
            var Sqlsectores = "select * from setor_atendimento";

            var establecimientos = Ambiente.Oracledb.Select(Sqlestablecimientos);
            var unidadaes = Ambiente.Oracledb.Select(Sqlunidades);
            var sectores = Ambiente.Oracledb.Select(Sqlsectores);

            if (establecimientos != null)
            {
                i = 0;
                foreach (DataRow row in establecimientos.Rows)
                {
                    var o = establecimientoController.SelectOneByClave(row["CD_ESTABELECIMENTO"].ToString());
                    WriteStatus("ESTABELECIMENTO", i, establecimientos.Rows.Count - 1);
                    InsertOrOpdate(o, row);
                    i++;
                }
            }
            if (sectores != null)
            {
                i = 0;
                foreach (DataRow row in sectores.Rows)
                {
                    var o = sectorController.SelectOneByClave(row["CD_SETOR_ATENDIMENTO"].ToString());
                    WriteStatus("SETOR_ATENDIMENTO", i, establecimientos.Rows.Count - 1);
                    InsertOrOpdate(o, row);
                    i++;
                }
            }

            if (unidadaes != null)
            {
                i = 0;
                foreach (DataRow row in unidadaes.Rows)
                {
                    var o = unidadController.SelectOneByClave(row["CD_UNIDADE_BASICA"].ToString());
                    WriteStatus("UNIDADE_BASICA", i, establecimientos.Rows.Count - 1);
                    InsertOrOpdate(o, row);
                    i++;
                }
            }


            Update = false;
        }
        private static void InsertOrOpdate(Establecimiento o, DataRow row)
        {
            if (o == null)
            {
                //Crear registro
                o = new Establecimiento();
                o.CdEstabelecimento = row["CD_ESTABELECIMENTO"].ToString();
                o.NmFantasiaEstab = row["NM_FANTASIA_ESTAB"].ToString();
                o.NmSiglaEstab = row["NM_SIGLA_ESTAB"].ToString();
                o.IeTipoCtbEstab = row["IE_TIPO_CTB_ESTAB"].ToString();
                o.IeAreaEstab = row["IE_AREA_ESTAB"].ToString();
                o.CdInterno = row["CD_INTERNO"].ToString();
                o.CreatedAt = DateTime.Now;
                o.UpdatedAt = null;
                if (!establecimientoController.InsertOne(o))
                    WriteStatus("ERROR INSERTANDO EL REGISTRO: " + o.CdEstabelecimento + " EN: ESTABELECIMENTO");


            }
            else
            {
                //actualizar
                o.CdEstabelecimento = row["CD_ESTABELECIMENTO"].ToString();
                o.NmFantasiaEstab = row["NM_FANTASIA_ESTAB"].ToString();
                o.NmSiglaEstab = row["NM_SIGLA_ESTAB"].ToString();
                o.IeTipoCtbEstab = row["IE_TIPO_CTB_ESTAB"].ToString();
                o.IeAreaEstab = row["IE_AREA_ESTAB"].ToString();
                o.CreatedAt = DateTime.Now;
                o.UpdatedAt = null;
                if (!establecimientoController.Update(o))
                    WriteStatus("ERROR ACTUALIZANDO EL REGISTRO: " + o.CdEstabelecimento + " EN: ESTABELECIMENTO");
            }
        }
        private static void InsertOrOpdate(Sector o, DataRow row)
        {
            if (o == null)
            {
                //Crear registro
                o = new Sector();
                o.CdSetorAtendimento = row["CD_SETOR_ATENDIMENTO"].ToString();
                o.DsSetorAtendimento = row["DS_SETOR_ATENDIMENTO"].ToString();
                o.NmUnidadeBasica = row["NM_UNIDADE_BASICA"].ToString();
                o.IeSituacao = row["IE_SITUACAO"].ToString();
                o.DsDescricao = row["DS_DESCRICAO"].ToString();
                // o.IE = row["IE_PROPRIO"].ToString();
                o.CreatedAt = DateTime.Now;
                o.UpdatedAt = null;
                if (!sectorController.InsertOne(o))
                    WriteStatus("ERROR INSERTANDO EL REGISTRO: " + o.CdSetorAtendimento + " EN: SETOR_ATENDIMENTO");


            }
            else
            {
                //actualizar
                o.CdSetorAtendimento = row["CD_SETOR_ATENDIMENTO"].ToString();
                o.DsSetorAtendimento = row["DS_SETOR_ATENDIMENTO"].ToString();
                o.NmUnidadeBasica = row["NM_UNIDADE_BASICA"].ToString();
                o.IeSituacao = row["IE_SITUACAO"].ToString();
                o.IeSituacao = row["DS_DESCRICAO"].ToString();
                o.DsDescricao = row["IE_PROPRIO"].ToString();
                o.CreatedAt = DateTime.Now;
                o.UpdatedAt = null;
                if (!sectorController.Update(o))
                    WriteStatus("ERROR INSERTANDO EL REGISTRO: " + o.CdSetorAtendimento + " EN: SETOR_ATENDIMENTO");

            }
        }
        private static void InsertOrOpdate(Unidad o, DataRow row)
        {
            if (o == null)
            {
                //Crear registro
                o = new Unidad();
                o.NrSeqInterno = row["NR_SEQ_INTERNO"].ToString();
                o.CdUnidadeBasica = row["CD_UNIDADE_BASICA"].ToString();
                o.CdSetorAtendimento = row["CD_SETOR_ATENDIMENTO"].ToString();
                o.IeSituacao = row["IE_SITUACAO"].ToString();
                o.IeStatusUnidade = row["IE_STATUS_UNIDADE"].ToString();
                o.DsUnidadeAtend = row["DS_UNIDADE_ATEND"].ToString();
                o.CreatedAt = DateTime.Now;
                o.UpdatedAt = null;
                if (!unidadController.InsertOne(o))
                    WriteStatus("ERROR INSERTANDO EL REGISTRO: " + o.CdUnidadeBasica + " EN: UNIDADE_BASICA");


            }
            else
            {
                //actualizar
                o.NrSeqInterno = row["NR_SEQ_INTERNO"].ToString();
                o.CdUnidadeBasica = row["CD_UNIDADE_BASICA"].ToString();
                o.CdSetorAtendimento = row["CD_SETOR_ATENDIMENTO"].ToString();
                o.IeSituacao = row["IE_SITUACAO"].ToString();
                o.IeStatusUnidade = row["IE_STATUS_UNIDADE"].ToString();
                o.DsUnidadeAtend = row["DS_UNIDADE_ATEND"].ToString();
                o.CreatedAt = DateTime.Now;
                o.UpdatedAt = null;
                if (!unidadController.Update(o))
                    WriteStatus("ERROR INSERTANDO EL REGISTRO: " + o.CdUnidadeBasica + " EN: UNIDADE_BASICA");

            }
        }
        private static void SincronizarAbiertas(Query q)
        {



            s = q.ComandoSql;
            if (q.Parametrizar)
                s += Ambiente.OracleDate(q.UltSincronizacion);
            else
            {
                var mins = (DateTime.Now - q.UltSincronizacion).TotalMinutes;
                if (mins <= Ambiente.MinAbiertas)
                    return;
            }

            abiertas = abiertaController.SelectAll();

            DataTable atencionesAbiertas = Ambiente.Oracledb.Select(s);

            if (atencionesAbiertas.Rows.Count > 0)
            {
                i = 0;
                foreach (DataRow a in atencionesAbiertas.Rows)
                {
                    var abiertalocal = abiertas.FirstOrDefault(x => x.NrAtendimento.Equals(a["NR_ATENDIMENTO"].ToString()));

                    if (abiertalocal != null)
                        continue;


                    var abierta = new Abierta();
                    abierta.NrAtendimento = a["NR_ATENDIMENTO"].ToString();
                    abierta.CdPaciente = a["CD_PACIENTE"].ToString();
                    abierta.CdMedico = a["CD_MEDICO"].ToString();
                    abierta.CdEstabelecimento = a["CD_ESTABELECIMENTO"].ToString();
                    abierta.DtEntrada = DateTime.Parse(a["DT_ENTRADA"].ToString());
                    abierta.CdUnidadeBasica = a["CD_UNIDADE_BASICA"].ToString();
                    abierta.CdSetorAtendimento = a["CD_SETOR_ATENDIMENTO"].ToString();
                    abierta.DtAlta = null;
                    abierta.DtActualizacion = null;
                    abierta.CreatedAt = DateTime.Now;
                    if (abiertaController.InsertOne(abierta))
                    {
                        WriteStatus("ATENCIONES ABIERTAS", i, atencionesAbiertas.Rows.Count - 1);
                        i++;
                    }
                }
                q.UltSincronizacion = DateTime.Now;
                queryController.Update(q);
            }
            else
                WriteStatus("TODO ESTÁ SINCRONIZADO " + DateTime.Now.ToString("HH:mm:ss"));
        }
        private static void SincronizarAltas(Query q)
        {
            s = q.ComandoSql;
            if (q.Parametrizar)
                s += Ambiente.OracleDate(q.UltSincronizacion);

            DataTable altasRemotas = Ambiente.Oracledb.Select(s);

            if (altasRemotas.Rows.Count > 0)
            {
                i = 0;
                foreach (DataRow a in altasRemotas.Rows)
                {

                    var alta = new Alta();
                    alta.NrAtendimento = a["NR_ATENDIMENTO"].ToString();
                    alta.CdPaciente = a["CD_PACIENTE"].ToString();
                    alta.CdMedico = a["CD_MEDICO"].ToString();
                    alta.CdEstabelecimento = a["CD_ESTABELECIMENTO"].ToString();
                    alta.DtEntrada = DateTime.Parse(a["DT_ENTRADA"].ToString());
                    alta.DtAlta = DateTime.Parse(a["DT_ALTA"].ToString());
                    alta.DtActualizacion = DateTime.Parse(a["DT_ACTUALIZACION"].ToString());
                    alta.CdUnidadeBasica = a["CD_UNIDADE_BASICA"].ToString();
                    alta.CdSetorAtendimento = a["CD_SETOR_ATENDIMENTO"].ToString();
                    alta.CreatedAt = DateTime.Now;
                    if (altaController.InsertOne(alta))
                    {
                        WriteStatus("ALTAS", i, altasRemotas.Rows.Count - 1);
                        i++;
                    }
                }
                SincronizaMedico(altasRemotas);
                SincronizaPaciente(altasRemotas);
                SincronizarComplementoMedico(altasRemotas);
                SincronizarComplementoPaciente(altasRemotas);
                PreparaHttpRequest(altasRemotas);
                LanzaHttpRequests();
                q.UltSincronizacion = DateTime.Now;
                queryController.Update(q);

            }
            else
                WriteStatus("TODO ESTÁ SINCRONIZADO " + DateTime.Now.ToString("HH:mm:ss"));
        }
        private static void SincronizarComplementoMedico(DataTable altasRemotas)
        {
            using (var db = new SyncContext())
            {
                i = 0;
                foreach (DataRow row in altasRemotas.Rows)
                {
                    var cmr = Ambiente.Oracledb.Select("select CD_PESSOA_FISICA, IE_TIPO_COMPLEMENTO, NR_TELEFONE, DS_EMAIL from COMPL_PESSOA_FISICA where IE_TIPO_COMPLEMENTO =1 and CD_PESSOA_FISICA=" + row["CD_MEDICO"].ToString());
                    if (cmr != null)
                    {
                        if (cmr.Rows.Count > 0)
                        {
                            DataRow cmedicoRemoto = cmr.Rows[0];

                            var cml = db.Complemento.FirstOrDefault(x => x.CdPessoaFisica.Equals(cmedicoRemoto["CD_PESSOA_FISICA"].ToString()));
                            if (cml == null)
                            {
                                //insertar
                                cml = new Complemento();
                                cml.CdPessoaFisica = cmedicoRemoto["CD_PESSOA_FISICA"].ToString();
                                cml.IeTipoComplemento = cmedicoRemoto["IE_TIPO_COMPLEMENTO"].ToString();
                                cml.NrTelefone = cmedicoRemoto["NR_TELEFONE"].ToString();
                                cml.DsEmail = cmedicoRemoto["DS_EMAIL"].ToString();
                                if (complementoController.InsertOne(cml))
                                {
                                    WriteStatus("COMPLEMENTO MEDICO", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }
                            else
                            {
                                //actulizar

                                cml.CdPessoaFisica = cmedicoRemoto["CD_PESSOA_FISICA"].ToString();
                                cml.IeTipoComplemento = cmedicoRemoto["IE_TIPO_COMPLEMENTO"].ToString();
                                cml.NrTelefone = cmedicoRemoto["NR_TELEFONE"].ToString();
                                cml.DsEmail = cmedicoRemoto["DS_EMAIL"].ToString();
                                if (complementoController.Update(cml))
                                {
                                    WriteStatus("COMPLEMENTO MEDICO", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }


                        }
                    }
                }
            }
        }
        private static void SincronizarComplementoPaciente(DataTable altasRemotas)
        {
            using (var db = new SyncContext())
            {
                i = 0;
                foreach (DataRow row in altasRemotas.Rows)
                {
                    var cpr = Ambiente.Oracledb.Select("select CD_PESSOA_FISICA, IE_TIPO_COMPLEMENTO, NR_TELEFONE, DS_EMAIL from COMPL_PESSOA_FISICA where IE_TIPO_COMPLEMENTO =1 and CD_PESSOA_FISICA=" + row["CD_PACIENTE"].ToString());
                    if (cpr != null)
                    {
                        if (cpr.Rows.Count > 0)
                        {
                            DataRow cpacienteRemoto = cpr.Rows[0];

                            var cml = db.Complemento.FirstOrDefault(x => x.CdPessoaFisica.Equals(cpacienteRemoto["CD_PESSOA_FISICA"].ToString()));
                            if (cml == null)
                            {
                                //insertar
                                cml = new Complemento();
                                cml.CdPessoaFisica = cpacienteRemoto["CD_PESSOA_FISICA"].ToString();
                                cml.IeTipoComplemento = cpacienteRemoto["IE_TIPO_COMPLEMENTO"].ToString();
                                cml.NrTelefone = cpacienteRemoto["NR_TELEFONE"].ToString();
                                cml.DsEmail = cpacienteRemoto["DS_EMAIL"].ToString();
                                if (complementoController.InsertOne(cml))
                                {
                                    WriteStatus("COMPLEMENTO PACIENTE", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }
                            else
                            {
                                //actulizar

                                cml.CdPessoaFisica = cpacienteRemoto["CD_PESSOA_FISICA"].ToString();
                                cml.IeTipoComplemento = cpacienteRemoto["IE_TIPO_COMPLEMENTO"].ToString();
                                cml.NrTelefone = cpacienteRemoto["NR_TELEFONE"].ToString();
                                cml.DsEmail = cpacienteRemoto["DS_EMAIL"].ToString();
                                if (complementoController.Update(cml))
                                {
                                    WriteStatus("COMPLEMENTO PACIENTE", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }


                        }
                    }
                }
            }
        }
        private static void PreparaHttpRequest(DataTable altasRemotas)
        {
            if (altasRemotas.Rows.Count > 0)
            {
                i = 0;
                foreach (DataRow a in altasRemotas.Rows)
                {
                    var param = GeneraParametros(a);

                    if (param.Trim().Length > 0)
                    {
                        var request = new HttpRequest();

                        request.NrAtendimento = a["NR_ATENDIMENTO"].ToString();
                        request.DtAlta = DateTime.Parse(a["DT_ALTA"].ToString());
                        request.Parametros = param;
                        request.Enviado = false;
                        request.Fenvio = null;
                        request.SuccessfulRequest = false;
                        request.HttpResponse = null;
                        request.CreatedAt = DateTime.Now;
                        if (requestController.InsertOne(request))
                        {
                            WriteStatus("PREPARANDO PETICIONES HTTP", i, altasRemotas.Rows.Count - 1);
                            i++;
                        }
                    }
                }
            }
            else
                WriteStatus("TODO ESTÁ SINCRONIZADO " + DateTime.Now.ToString("HH:mm:ss"));
        }
        public static void LanzaHttpRequests()
        {
            var requests = requestController.SelectAllPendientes();
            foreach (var r in requests)
                LanzaHttpRequest(r);
        }
        private static void LanzaHttpRequest(HttpRequest request)
        {
            string respuestahtml;
            string[] respuestaDesglosada;
            try
            {
                CookieContainer tempcookies = new CookieContainer();
                UTF8Encoding encoding = new UTF8Encoding();

                //request.Parametros = "1|596|JUAN ALEJANDRO FLORES VILADROZA|mendoza.git@gmail.com|NULL|Edson Roberto Hernandez Crisanto|mendoza.git@gmail.com|4611478175|2019-09-10|0";
                var byt = Encoding.UTF8.GetBytes(request.Parametros);


                var ParametrosBase64 = Convert.ToBase64String(byt);

                string strURLCompleto = @"https://hospitalesmac.com/encuestas/ws/encuestaPM.php";
                strURLCompleto += "?param=" + ParametrosBase64;

                HttpWebRequest postreq = (HttpWebRequest)WebRequest.Create(strURLCompleto);




                postreq.Method = "GET";
                postreq.KeepAlive = true;
                postreq.CookieContainer = tempcookies;
                postreq.UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
                postreq.ContentType = "text/html; charset=utf-8";
                postreq.Referer = strURLCompleto;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

                HttpWebResponse postresponse;
                postresponse = (HttpWebResponse)postreq.GetResponse();

                StreamReader postreqreader = new StreamReader(postresponse.GetResponseStream());
                string thepage = postreqreader.ReadToEnd();
                HttpWebResponse respuesta = postresponse;
                respuestahtml = thepage;
                // respuestaDesglosada = new[] { "1" };
            }
            catch (Exception ex)
            {
                respuestahtml = ex.Message;
                respuestaDesglosada = new[] { "-1" };
            }
        }
        private static string GeneraParametros(DataRow a)
        {

            Parametro parametros = new Parametro();
            Establecimiento establecimiento;
            Sector sector;
            Paciente paciente;
            Medico medico;
            Complemento complementop;
            Complemento complementom;

            using (var db = new SyncContext())
            {
                establecimiento = db.Establecimiento.FirstOrDefault(x => x.CdEstabelecimento.Equals(a["CD_ESTABELECIMENTO"].ToString()));
                medico = db.Medico.FirstOrDefault(x => x.CdPessoaFisica.Equals(a["CD_MEDICO"].ToString()));
                paciente = db.Paciente.FirstOrDefault(x => x.CdPessoaFisica.Equals(a["CD_PACIENTE"].ToString()));
                complementop = db.Complemento.FirstOrDefault(x => x.CdPessoaFisica.Equals(a["CD_PACIENTE"].ToString()));
                complementom = db.Complemento.FirstOrDefault(x => x.CdPessoaFisica.Equals(a["CD_MEDICO"].ToString()));
                sector = db.Sector.FirstOrDefault(x => x.CdSetorAtendimento.Equals(a["CD_SETOR_ATENDIMENTO"].ToString()));
            }
            if (sector == null)
            {
                WriteStatus("HTTPREQUEST MAL FORMADA: " + DateTime.Now.ToString("hh:mm:ss"));
                return "";
            }


            if (sector.LanzaHttprequest)
            {
                parametros.EmpresaId = 1; //Deberia ser dinamico
                if (establecimiento == null)
                    parametros.SucursalId = "NULL";
                else
                    parametros.SucursalId = establecimiento.CdInterno.Trim().Trim().Length == 0 ? "DESCONOCIDO" : establecimiento.CdInterno.Trim();
                parametros.NoAtencion = a["NR_ATENDIMENTO"].ToString().Trim().Length == 0 ? "DESCONOCIDO" : a["NR_ATENDIMENTO"].ToString();

                if (medico == null)
                    parametros.NombreMedico = "NULL";
                else
                    parametros.NombreMedico = medico.NmPessoaFisica.Trim().Length == 0 ? "DESCONOCIDO" : medico.NmPessoaFisica.Trim();

                if (complementom == null)
                    parametros.CorreoMedico = "NULL";
                else
                    //  parametros.CorreoMedico = complementom.DsEmail.Trim().Length == 0 ? "encuestas@hospitalesmac.com" : complementom.DsEmail.Trim();
                    parametros.CorreoMedico = complementom.DsEmail.Trim().Length == 0 ? "mendoza.git@gmail.com" : complementom.DsEmail.Trim();


                if (complementom == null)
                    parametros.TelefonoMedico = "NULL";
                else
                    parametros.TelefonoMedico = complementom.NrTelefone.Trim().Length == 0 ? "DESCONOCIDO" : complementom.NrTelefone.Trim();

                if (paciente == null)
                    parametros.NombrePaciente = "NULL";
                else
                    parametros.NombrePaciente = paciente.NmPessoaFisica.Trim().Length == 0 ? "DESCONOCIDO" : paciente.NmPessoaFisica.Trim();

                if (complementop == null)
                    parametros.CorreoPaciente = "NULL";
                else
                    parametros.CorreoPaciente = complementop.DsEmail.Trim().Length == 0 ? "mendoza.git@gmail.com" : complementop.DsEmail.Trim();

                if (complementop == null)
                    parametros.TelefonoPaciente = "null";
                else
                    parametros.TelefonoPaciente = complementop.NrTelefone.Trim().Length == 0 ? "" : complementop.NrTelefone.Trim();

                if (DateTime.TryParse(a["DT_ALTA"].ToString(), out DateTime datealta))
                    parametros.FechaAlta = datealta;
                else
                    parametros.FechaAlta = DateTime.Now;
                parametros.Urgencias = sector.Urgencias == true ? 1 : 0;

                return parametros.Serializar();
            }
            else return "";
        }
        private static void SincronizaPaciente(DataTable altasRemotas)
        {
            using (var db = new SyncContext())
            {

                i = 0;
                foreach (DataRow row in altasRemotas.Rows)
                {
                    var pr = Ambiente.Oracledb.Select("SELECT CD_PESSOA_FISICA,NM_PESSOA_FISICA,NM_USUARIO,DT_NASCIMENTO,IE_SEXO,NM_ABREVIADO,CD_CURP,CD_RFC,NM_PRIMEIRO_NOME,NM_SOBRENOME_PAI,NM_SOBRENOME_MAE from pessoa_fisica where CD_PESSOA_FISICA=" + row["CD_PACIENTE"].ToString());
                    if (pr != null)
                    {
                        if (pr.Rows.Count > 0)
                        {
                            DataRow pacienteRemoto = pr.Rows[0];

                            var pl = db.Paciente.FirstOrDefault(x => x.CdPessoaFisica.Equals(pacienteRemoto["CD_PESSOA_FISICA"].ToString()));
                            if (pl == null)
                            {
                                //insertar
                                pl = new Paciente();
                                pl.CdPessoaFisica = pacienteRemoto["CD_PESSOA_FISICA"].ToString();
                                pl.NmPessoaFisica = pacienteRemoto["NM_PESSOA_FISICA"].ToString();
                                pl.NmUsuario = pacienteRemoto["NM_USUARIO"].ToString();


                                success = DateTime.TryParse(pacienteRemoto["DT_NASCIMENTO"].ToString(), out DateTime fecha);
                                if (success)
                                    pl.DtNascimento = fecha;
                                else
                                    pl.DtNascimento = null;

                                pl.IeSexo = pacienteRemoto["IE_SEXO"].ToString();
                                pl.NmAbreviado = pacienteRemoto["NM_ABREVIADO"].ToString();
                                pl.CdCurp = pacienteRemoto["CD_CURP"].ToString();
                                pl.CdRfc = pacienteRemoto["CD_RFC"].ToString();
                                pl.NmPrimeiroNome = pacienteRemoto["NM_PRIMEIRO_NOME"].ToString();
                                pl.NmSobrenomePai = pacienteRemoto["NM_SOBRENOME_PAI"].ToString();
                                pl.NmSobrenomeMae = pacienteRemoto["NM_SOBRENOME_MAE"].ToString();
                                pl.CreatedAt = DateTime.Now;
                                pl.UpdatedAt = null;

                                if (pacienteController.InsertOne(pl))
                                {
                                    WriteStatus("MEDICO", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }
                            else
                            {
                                //actulizar
                                pl.CdPessoaFisica = pacienteRemoto["CD_PESSOA_FISICA"].ToString();
                                pl.NmPessoaFisica = pacienteRemoto["NM_PESSOA_FISICA"].ToString();
                                pl.NmUsuario = pacienteRemoto["NM_USUARIO"].ToString();


                                success = DateTime.TryParse(pacienteRemoto["DT_NASCIMENTO"].ToString(), out DateTime fecha);
                                if (success)
                                    pl.DtNascimento = fecha;
                                else
                                    pl.DtNascimento = null;

                                pl.IeSexo = pacienteRemoto["IE_SEXO"].ToString();
                                pl.NmAbreviado = pacienteRemoto["NM_ABREVIADO"].ToString();
                                pl.CdCurp = pacienteRemoto["CD_CURP"].ToString();
                                pl.CdRfc = pacienteRemoto["CD_RFC"].ToString();
                                pl.NmPrimeiroNome = pacienteRemoto["NM_PRIMEIRO_NOME"].ToString();
                                pl.NmSobrenomePai = pacienteRemoto["NM_SOBRENOME_PAI"].ToString();
                                pl.NmSobrenomeMae = pacienteRemoto["NM_SOBRENOME_MAE"].ToString();
                                pl.CreatedAt = DateTime.Now;
                                pl.UpdatedAt = null;

                                if (pacienteController.Update(pl))
                                {
                                    WriteStatus("PACIENTE", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }

                        }
                    }
                }
            }
        }
        private static void SincronizaMedico(DataTable altasRemotas)
        {

            using (var db = new SyncContext())
            {

                i = 0;
                foreach (DataRow row in altasRemotas.Rows)
                {
                    var mr = Ambiente.Oracledb.Select("SELECT CD_PESSOA_FISICA,NM_PESSOA_FISICA,NM_USUARIO,DT_NASCIMENTO,IE_SEXO,NM_ABREVIADO,CD_CURP,CD_RFC,NM_PRIMEIRO_NOME,NM_SOBRENOME_PAI,NM_SOBRENOME_MAE from pessoa_fisica where CD_PESSOA_FISICA=" + row["CD_MEDICO"].ToString());
                    if (mr != null)
                    {
                        if (mr.Rows.Count > 0)
                        {
                            DataRow medicoRemoto = mr.Rows[0];

                            var ml = db.Medico.FirstOrDefault(x => x.CdPessoaFisica.Equals(medicoRemoto["CD_PESSOA_FISICA"].ToString()));
                            if (ml == null)
                            {
                                //insertar
                                ml = new Medico();
                                ml.CdPessoaFisica = medicoRemoto["CD_PESSOA_FISICA"].ToString();
                                ml.NmPessoaFisica = medicoRemoto["NM_PESSOA_FISICA"].ToString();
                                ml.NmUsuario = medicoRemoto["NM_USUARIO"].ToString();

                                success = DateTime.TryParse(medicoRemoto["DT_NASCIMENTO"].ToString(), out DateTime fecha);
                                if (success)
                                    ml.DtNascimento = fecha;
                                else
                                    ml.DtNascimento = null;

                                ml.IeSexo = medicoRemoto["IE_SEXO"].ToString();
                                ml.NmAbreviado = medicoRemoto["NM_ABREVIADO"].ToString();
                                ml.CdCurp = medicoRemoto["CD_CURP"].ToString();
                                ml.CdRfc = medicoRemoto["CD_RFC"].ToString();
                                ml.NmPrimeiroNome = medicoRemoto["NM_PRIMEIRO_NOME"].ToString();
                                ml.NmSobrenomePai = medicoRemoto["NM_SOBRENOME_PAI"].ToString();
                                ml.NmSobrenomeMae = medicoRemoto["NM_SOBRENOME_MAE"].ToString();
                                ml.CreatedAt = DateTime.Now;
                                ml.UpdatedAt = null;

                                if (medicoController.InsertOne(ml))
                                {
                                    WriteStatus("MEDICO", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }
                            else
                            {
                                //actulizar
                                ml.CdPessoaFisica = medicoRemoto["CD_PESSOA_FISICA"].ToString();
                                ml.NmPessoaFisica = medicoRemoto["NM_PESSOA_FISICA"].ToString();
                                ml.NmUsuario = medicoRemoto["NM_USUARIO"].ToString();
                                success = DateTime.TryParse(medicoRemoto["DT_NASCIMENTO"].ToString(), out DateTime fecha);
                                if (success)
                                    ml.DtNascimento = fecha;
                                else
                                    ml.DtNascimento = null;
                                ml.IeSexo = medicoRemoto["IE_SEXO"].ToString();
                                ml.NmAbreviado = medicoRemoto["NM_ABREVIADO"].ToString();
                                ml.CdCurp = medicoRemoto["CD_CURP"].ToString();
                                ml.CdRfc = medicoRemoto["CD_RFC"].ToString();
                                ml.NmPrimeiroNome = medicoRemoto["NM_PRIMEIRO_NOME"].ToString();
                                ml.NmSobrenomePai = medicoRemoto["NM_SOBRENOME_PAI"].ToString();
                                ml.NmSobrenomeMae = medicoRemoto["NM_SOBRENOME_MAE"].ToString();
                                ml.CreatedAt = DateTime.Now;
                                ml.UpdatedAt = null;

                                if (medicoController.Update(ml))
                                {
                                    WriteStatus("MEDICO", i, altasRemotas.Rows.Count - 1);
                                    i++;
                                }
                            }


                        }
                    }
                }
            }
        }
    }
}
