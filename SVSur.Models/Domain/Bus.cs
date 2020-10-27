using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSur.Models.Domain
{
    [Table("Buses")]
    public class Bus
    {
        public int BusID { get; set; }

        [Required(ErrorMessage = "El campo Modelo de bus es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo no puede contener mas de 50 caracteres")]
        public string Modelo { get; set; }

        [Required]
        public int NLlantas { get; set; }

        [Required]
        public string Chasis { get; set; }

        [Required]
        public int AñoFabricacion { get; set; }

        [Required(ErrorMessage = "El campo Combustible de bus es obligatorio")]
        [StringLength(20, ErrorMessage = "El campo no puede contener mas de 20 caracteres")]
        public string Combustible { get; set; }

        [Required(ErrorMessage = "El campo rutina de bus es obligatorio")]
        [StringLength(20, ErrorMessage = "El campo no puede contener mas de 20 caracteres")]
        public string Rutina { get; set; }


        [Required(ErrorMessage = "El campo placa  de bus es obligatorio")]
        [StringLength(8, ErrorMessage = "El campo no puede contener mas de 7 caracteres")]
        public string PlacaBus { get; set; }


        [Required]
        public int CapacidadBus { get; set; }
        
        [Required]
        public bool Estado { get; set; }

        //propiedades de navegacion
        public virtual ICollection<Chofer> Choferes { get; set; }
    }
}
