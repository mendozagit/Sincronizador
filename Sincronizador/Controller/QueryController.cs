
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
    public class QueryController
    {
        public bool Delete(Query o)
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
                    var temp = db.Query.FirstOrDefault(x => x.QueryId == Id);
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

        public bool InsertOne(Query o)
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

        public bool InsertRange(List<Query> lista)
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

        public List<Query> SelectAll()
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Query.Where(x => x.Vigente == true).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public List<Query> SelectMany(int cantidad)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Query.Take(cantidad).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public Query SelectOne(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Query.FirstOrDefault(x => x.QueryId == Id);
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }


        public List<Query> SelectOneOverList(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Query.Where(x => x.QueryId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }

        public bool Update(Query o)
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
