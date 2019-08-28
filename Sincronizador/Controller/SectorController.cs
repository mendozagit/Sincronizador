using Microsoft.EntityFrameworkCore;
using Sincronizador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sincronizador.Controller
{
    public class SectorController
    {
        public bool Delete(Sector o)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    db.Remove(o);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return false;
        }


        public bool Delete(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    var temp = db.Sector.FirstOrDefault(x => x.SectorId == Id);
                    if (temp != null)
                        db.Remove(temp);

                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return false;
        }

        public bool InsertOne(Sector o)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    db.Add(o);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return false;
        }

        public bool InsertRange(List<Sector> lista)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    db.AddRange(lista);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return false;
        }

        public List<Sector> SelectAll()
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Sector.ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public List<Sector> SelectMany(int cantidad)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Sector.Take(cantidad).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public Sector SelectOne(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Sector.FirstOrDefault(x => x.SectorId == Id);
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }
        public Sector SelectOneByClave(string cd_registro)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Sector.FirstOrDefault(x => x.CdSetorAtendimento.Equals(cd_registro.Trim()));
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public List<Sector> SelectOneOverList(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Sector.Where(x => x.SectorId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public bool Update(Sector o)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    db.Entry(o).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return false;
        }


    }
}
