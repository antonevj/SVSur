using SVSur.Manager.Contracts;
using SVSur.Models;
using SVSur.Models.Domain;
using SVSur.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Manager
{
  public  class ChoferManager : IChoferManager
    {
        public IEnumerable<Chofer> GetAll(bool status)
        {
            using (var context = new ApplicationDbContext())
            {
                var lista = context.Choferes.Include("Categoria").Include("Marca").Where(K => K.Estado == status).ToList();
                return lista;
            }
        }

        public IEnumerable<ChoferDTO> GetAllDTO(bool status)
        {
            using (var context = new ApplicationDbContext())
            {
                var lista = context.Choferes
                    .Where(K => K.Estado == status)
                    .Select(K => new ChoferDTO
                    {

                        ChoferID = K.ChoferID,
                        Nombre = K.Nombre,
                        Apellidos = K.Apellidos,
                        Sexo = K.Sexo,
                        Edad = K.Edad,
                        DNI = K.DNI,
                        PlacaBus = K.Bus.PlacaBus,
                     


                    }).ToList();

                return lista;
            }

        }

        public Chofer Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Choferes.Where(k => k.ChoferID == id).SingleOrDefault();
            }
        }


        public int Insert(Chofer obj)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(obj).State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Update(Chofer obj)
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
                var obj = context.Choferes.Find(id);
                context.Entry(obj).State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }


    }
}
