using SVSur.Manager.Contracts;
using SVSur.Models;
using SVSur.Models.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace SVSur.Manager
{
    public class BusManager : IBusManager
    {
        public IEnumerable<Bus> GetAll(bool status)
        {
            using (var context = new ApplicationDbContext())
            {
                var lista = context.Buses.ToList();
                return lista;
            }
        }

        public Bus Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Buses.Where(K => K.BusID == id).SingleOrDefault();
            }
        }

        public int Insert(Bus obj)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(obj).State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Update(Bus obj)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }

        public int Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                Bus obj = context.Buses.Find(id);
                context.Entry(obj).State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }

    }
}
