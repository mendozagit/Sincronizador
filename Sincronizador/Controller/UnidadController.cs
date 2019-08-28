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
    public class UnidadController
    {
        public bool Delete(Unidad o)
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
                    var temp = db.Unidad.FirstOrDefault(x => x.UnidadId == Id);
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

        public bool InsertOne(Unidad o)
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

        public bool InsertRange(List<Unidad> lista)
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

        public List<Unidad> SelectAll()
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Unidad.ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public List<Unidad> SelectMany(int cantidad)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Unidad.Take(cantidad).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public Unidad SelectOneByClave(string cd_registro)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Unidad.FirstOrDefault(x => x.CdUnidadeBasica.Equals(cd_registro.Trim()));
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }
        public Unidad SelectOne(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Unidad.FirstOrDefault(x => x.UnidadId == Id);
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }


        public List<Unidad> SelectOneOverList(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Unidad.Where(x => x.UnidadId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public bool Update(Unidad o)
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
