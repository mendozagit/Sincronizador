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
    public class HttpRequestConfigController
    {
        public bool Delete(HttpRequestConfig o)
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
                    var temp = db.HttpRequestConfig.FirstOrDefault(x => x.HttpRequestConfigId == Id);
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

        public bool InsertOne(HttpRequestConfig o)
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

        public bool InsertRange(List<HttpRequestConfig> lista)
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

        public List<HttpRequestConfig> SelectAll()
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.HttpRequestConfig.ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }
        public List<HttpRequestConfig> SelectAllVigentes()
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.HttpRequestConfig.Where(x => x.IsDeleted == false).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public List<HttpRequestConfig> SelectMany(int cantidad)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.HttpRequestConfig.Take(cantidad).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public HttpRequestConfig SelectOne(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.HttpRequestConfig.FirstOrDefault(x => x.HttpRequestConfigId == Id);
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }


        public List<HttpRequestConfig> SelectOneOverList(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.HttpRequestConfig.Where(x => x.HttpRequestConfigId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public bool Update(HttpRequestConfig o)
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
