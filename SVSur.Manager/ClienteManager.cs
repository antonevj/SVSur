using SVSur.Manager.Contracts;
using SVSur.Models;
using SVSur.Models.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace SVSur.Manager
{
    public class ClienteManager : IClienteManager
    {
        public IEnumerable<Cliente> GetAll(bool status)
        {
            using (var context = new ApplicationDbContext())
            {
                var lista = context.Clientes.Where(K => K.Estado == status).ToList(); ;
                return lista;
            }
        }

        public Cliente Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Clientes.Where(K => K.ClienteID == id).SingleOrDefault();
            }
        }

        public int Insert(Cliente obj)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(obj).State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Update(Cliente obj)
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
                Cliente obj = context.Clientes.Find(id);
                context.Entry(obj).State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }

  
    }
}
