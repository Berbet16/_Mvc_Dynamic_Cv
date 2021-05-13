using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCvEntities db = new DbCvEntities();

        public List<T> List()
        {
            //t den gelen değeri liste olarak döndür.
            //T =  tüm tabloların değeri
            return db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            //parametreden gelen değerleri ekle ve kaydet
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet(int id)
        {
            //T den gelen değeri id 'e göre bul
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
    }
}