using Microsoft.AspNet.Identity.EntityFramework;
using SVSur.Models.Domain;
using SVSur.Models.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
             : base("name=miCadena", throwIfV1Schema: false)
        {
            Database.SetInitializer(
            new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>("miCadena"));
        }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<Chofer> Choferes { get; set; }
        public virtual DbSet<Ruta> Rutas { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
