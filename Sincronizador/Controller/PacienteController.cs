using Microsoft.EntityFrameworkCore;
using Sincronizador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sincronizador.Controller
{
    public class PacienteController
    {
        public bool Delete(Paciente o)
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
                    var temp = db.Paciente.FirstOrDefault(x => x.PacienteId == Id);
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
        public bool InsertOne(Paciente o)
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
        public bool InsertRange(List<Paciente> lista)
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
        public List<Paciente> SelectAll()
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Paciente.ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }
        public List<Paciente> SelectMany(int cantidad)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Paciente.Take(cantidad).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }
        public Paciente SelectOne(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Paciente.FirstOrDefault(x => x.PacienteId == Id);
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }
        public List<Paciente> SelectOneOverList(int Id)
        {
            try
            {
                using (var db = new SyncContext())
                {
                    return db.Paciente.Where(x => x.PacienteId == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                Ambiente.Message("Algo salío mal con: " + MethodBase.GetCurrentMethod().Name + " @" + GetType().Name + "\n" + ex.Message);
            }
            return null;
        }
        public bool Update(Paciente o)
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
